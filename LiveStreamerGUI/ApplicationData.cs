using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LiveStreamerGUI
{
    public class ApplicationData
    {
        private List<string> _recentUrls;
        private string _livestreamerLoc;

        public List<string> Urls 
        {
            get { return _recentUrls; }
            set { _recentUrls = value; }
        }

        public string LivestreamerLoc
        {
            get { return _livestreamerLoc; }
            set { _livestreamerLoc = value; }
        }

        public ApplicationData()
        {
            _recentUrls = new List<string>();
            _livestreamerLoc = String.Empty;
        }

    }
}
