using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveStreamerGUI
{
    public partial class DocumentationWindow : Form
    {
        //public string Url { get; set; }

        public DocumentationWindow(string url)
        {
            InitializeComponent();
            webBrowser.ScriptErrorsSuppressed = true;
            webBrowser.Navigate(url);
        }

        
    }
}
