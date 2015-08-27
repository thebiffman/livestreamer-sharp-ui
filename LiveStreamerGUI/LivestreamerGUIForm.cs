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

        public LivestreamerGuiForm()
        {
            InitializeComponent();

            Application.ApplicationExit += new EventHandler(this.OnApplicationExit);

            // Read history from XML.
            DeserializeAppData();

            _urlsBinding = new BindingSource();
            _urlsBinding.DataSource = _applicationData.Urls;
            cbStreamURLs.DataSource = _urlsBinding;

            //cbStreamURLs.DataSource = _recentUrls;

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

        public void DeserializeAppData()
        {
            try
            {
                FileStream xmlFile = new FileStream("ApplicationData.xml", FileMode.Open);
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

        public void SerializeAppData()
        {
            try
            {
                FileStream xmlFile = new FileStream("ApplicationData.xml", FileMode.Create);

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
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        private void UpdateHistory()
        {

            _applicationData.LivestreamerLoc = tbLivestreamerLoc.Text;
   
            if (_applicationData.Urls.Count > 9)
            {
                _applicationData.Urls.RemoveAt(_applicationData.Urls.Count-1);
            }

            _urlsBinding.Insert(0, cbStreamURLs.Text);

            cbStreamURLs.SelectedIndex = 0;

            // DEBUG
            foreach (string url in _applicationData.Urls)
            {
                AddOutput("URL: " + url);
            }
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Livestreamer Sharp UI \n" +
                            "Version 0.2\n" +
                            "https://github.com/thebiffman/livestreamer-sharp-ui" + "\n" +
                            "https://github.com/chrippa/livestreamer/");
        }
    }
}
