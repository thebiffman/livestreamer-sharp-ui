using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace LiveStreamerGUI
{
    public partial class LivestreamerGuiForm : Form
    {
        private ApplicationData _applicationData;
        private BindingSource _urlsBinding;
        
        /// <summary>
        /// Not a very reliable method of finding vlc, which is why the default 
        /// behavior is to let livestreamer choose.
        /// </summary>
        readonly string[] VLC_LOCS = new string[2]
        {
            "C:\\Program Files (x86)\\VideoLAN\\VLC\\vlc.exe",
            "C:\\Program Files\\VideoLAN\\VLC\\vlc.exe"
        };

        private readonly string XML_FILE_NAME = "ApplicationData.xml";

        public LivestreamerGuiForm()
        {
            InitializeComponent();

            // Makes sure that the "save to XML" code is run when the application are closed.
            Application.ApplicationExit += new EventHandler(this.OnApplicationExit);

            // Read history from XML.
            DeserializeAppData();

            // Binds the list of URLs to the combobox.
            _urlsBinding = new BindingSource();
            _urlsBinding.DataSource = _applicationData.Urls;
            cbStreamURLs.DataSource = _urlsBinding;

            // Sets default state of the "Open with" checkbox and updates 
            // the UI to reflect the choice.
            cbUseCustomApp.Checked = false;
            HandleApplicationCheckbox();
        }

        /// <summary>
        /// Makes a feeble attempt to find vlc.
        /// </summary>
        private void LocateVlc()
        {
            foreach (string loc in VLC_LOCS)
            {
                if (File.Exists(loc))
                {
                    tbApplication.Text = loc;
                    AddOutput("Found VLC: " + loc);
                    break;
                }
            }
        }

        /// <summary>
        /// Attempts to deserialize the Application Data object from the XML file 
        /// defined in the XML_FILE_NAME variable. If no file was found a new
        /// instance will be created. 
        /// </summary>
        public void DeserializeAppData()
        {
            try
            {
                FileStream xmlFile = new FileStream(XML_FILE_NAME, FileMode.Open);
                if (!xmlFile.CanRead)
                {
                    _applicationData = new ApplicationData();
                }
                else
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(ApplicationData));
                    _applicationData = (ApplicationData)serializer.Deserialize(xmlFile);
                    tbLivestreamerLoc.Text = _applicationData.LivestreamerLoc;
                }

                xmlFile.Close();
            }
            catch (FileNotFoundException fileNotFoundException)
            {
                AddOutput("No saved application data found (" + fileNotFoundException.Message + ").");
                _applicationData = new ApplicationData();
            }
            
        }

        /// <summary>
        /// Attempts to serialize the Application Data object to a XML file with
        /// the name defined in the XML_FILE_NAME variable. 
        /// </summary>
        public void SerializeAppData()
        {
            try
            {
                FileStream xmlFile = new FileStream(XML_FILE_NAME, FileMode.Create);

                if (!xmlFile.CanWrite)
                {
                    MessageBox.Show("Could not save application data to file (cannot write).");
                }
                else
                {
                    XmlSerializer serializer = new XmlSerializer(_applicationData.GetType());
                    serializer.Serialize(xmlFile, _applicationData);
                }

                xmlFile.Close();
            }
            catch (UnauthorizedAccessException accessException)
            {
                MessageBox.Show("Could not save application data to file ("+ accessException.Message + ").");
            }
        }

        /// <summary>
        /// Starts livestreamer with the correct parameters and with the output 
        /// redirected to the output textbox.
        /// Stolen from: http://stackoverflow.com/questions/415620/redirect-console-output-to-textbox-in-separate-program
        /// </summary>
        private void btnOpen_Click(object sender, EventArgs e)
        {
            // Old method
            // Process.Start(tbLivestreamerLoc.Text, tbStreamURL.Text + " " + "best");

            Process livestreamerProcess = new Process();
            livestreamerProcess.StartInfo.FileName = tbLivestreamerLoc.Text;
            livestreamerProcess.StartInfo.Arguments = cbStreamURLs.Text + " " + "best";
            livestreamerProcess.StartInfo.UseShellExecute = false;
            livestreamerProcess.StartInfo.RedirectStandardOutput = true;
            livestreamerProcess.StartInfo.RedirectStandardError = true;
            livestreamerProcess.EnableRaisingEvents = true;
            livestreamerProcess.StartInfo.CreateNoWindow = true;

            livestreamerProcess.ErrorDataReceived += process_DataReceived;
            livestreamerProcess.OutputDataReceived += process_DataReceived;

            livestreamerProcess.Start();

            livestreamerProcess.BeginErrorReadLine();
            livestreamerProcess.BeginOutputReadLine();

            UpdateHistory();

        }

        /// <summary>
        /// Adds the current stream URL to history list (and removes the last one if
        /// there are more than 10 entries in the list). Also saves the current 
        /// livestreamer.exe location in the Application Data object.
        /// </summary>
        private void UpdateHistory()
        {
            _applicationData.LivestreamerLoc = tbLivestreamerLoc.Text;
   
            if (_applicationData.Urls.Count > 9)
            {
                _applicationData.Urls.RemoveAt(_applicationData.Urls.Count-1);
            }

            _urlsBinding.Insert(0, cbStreamURLs.Text);

            cbStreamURLs.SelectedIndex = 0;

            #if DEBUG
            foreach (string url in _applicationData.Urls)
            {
                AddOutput("URL: " + url);
            }
            #endif
        }

        /// <summary>
        /// Event that is used when output and error messages is recieved from 
        /// livestreamer.exe. It simply adds them to the output textbox with
        /// some help from the AddOutput methods that adds timestamp and newline char.
        /// </summary>
        void process_DataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                AddOutput(e.Data.ToString());
            }
        }

        delegate void SetOutputCallback(string text);

        /// <summary>
        /// Adds the given string to the output textbox with timestamp and newline char.
        /// Uses the SetOutputCallback delegate if needed (for livestreamer.exe messages).
        /// This is needed since those messages are coming from another thread.
        /// </summary>
        /// <param name="text">The text to add to the output textbox.</param>
        private void AddOutput(string text)
        {
            if (this.tbOutput.InvokeRequired)
            {
                SetOutputCallback d = new SetOutputCallback(AddOutput);
                this.Invoke(d, new object[] { text + "\n" });
            }
            else
            {
                string timestamp = DateTime.Now.ToString("[HH:mm:ss]");
                tbOutput.AppendText(timestamp + text + "\n");
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Method for the browse button (for livestreamer location). Will show a 
        /// file dialog that lets the user choose the location of livestreamer.exe.
        /// </summary>
        private void btnLivestreamerLocBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog livestreamerLocDialog = new OpenFileDialog();

            livestreamerLocDialog.Filter = "Livestreamer exe file (livestreamer.exe)|livestreamer.exe";
            livestreamerLocDialog.FilterIndex = 1;
            livestreamerLocDialog.Multiselect = false;

            if (livestreamerLocDialog.ShowDialog() == DialogResult.OK)
            {
                tbLivestreamerLoc.Text = livestreamerLocDialog.FileName;
            }
        }

        /// <summary>
        /// Method for when the checkbox cbUseCustomApp changes.
        /// </summary>
        private void cbUseCustomApp_CheckedChanged(object sender, EventArgs e)
        {
            HandleApplicationCheckbox();
        }

        /// <summary>
        /// Used when the checkbox changes state (and at startup).
        /// Enables or disables the media player path textbox.
        /// </summary>
        private void HandleApplicationCheckbox()
        {
            if (cbUseCustomApp.Checked)
            {
                tbApplication.Enabled = true;
                LocateVlc();
            }
            else
            {
                tbApplication.Enabled = false;
                tbApplication.Text = "Letting livestreamer decide";
            }
        }

        private void OnApplicationExit(object sender, EventArgs e)
        {
            // When the application is exiting, write the application data to file.
            SerializeAppData();
        }

        /// <summary>
        /// The File->Exit option in the menu. Closes the application.
        /// </summary>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// The about option in the menu. Shows a small popup window with the version number and 
        /// links to this applications GitHub page as well as the livestreamer GitHub page.
        /// </summary>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Livestreamer Sharp UI \n" +
                            "Version 0.2\n" +
                            "https://github.com/thebiffman/livestreamer-sharp-ui" + "\n" +
                            "https://github.com/chrippa/livestreamer/");
        }

        /// <summary>
        /// Supported plugins link. Opens a new DocumentationWindow and loads the supported 
        /// plugins page from the livestreamer documenation.
        /// </summary>
        private void linkPlugins_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DocumentationWindow pluginsWindow = new DocumentationWindow("http://docs.livestreamer.io/plugin_matrix.html");
            pluginsWindow.Text = "Supported plugins";
            pluginsWindow.Show();
        }

        /// <summary>
        /// Supported players link. Opens a new DocumentationWindow and loads the supported 
        /// players page from the livestreamer documenation.
        /// </summary>
        private void linkPlayers_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DocumentationWindow pluginsWindow = new DocumentationWindow("http://docs.livestreamer.io/players.html");
            pluginsWindow.Text = "Supported players";
            pluginsWindow.Show();
        }

        /// <summary>
        /// Download livestreamer link. Opens the install section of the livestreamer 
        /// documentation in the default browser.
        /// </summary>
        private void linkDownload_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://docs.livestreamer.io/install.html");
        }
    }
}
