using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechDas.WebSocket
{
    public class AppConfig
    {
        private static readonly Lazy<AppConfig> lazy = new Lazy<AppConfig>(() => new AppConfig());
        public static AppConfig Current { get { return lazy.Value; } }

        protected readonly string serviceURL;

        protected readonly int webServerPort;

        protected readonly string webServerFolder;

        protected readonly string webServerURL;


        public AppConfig()
        {
            this.serviceURL = ConfigurationManager.AppSettings["ServiceURL"].ToString();
            this.webServerPort = Convert.ToInt32(ConfigurationManager.AppSettings["WebServerPort"].ToString());
            this.webServerFolder = ConfigurationManager.AppSettings["WebServerFolder"].ToString();
            this.webServerURL = ConfigurationManager.AppSettings["WebServerURL"].ToString();
        }

        public string ServiceURL
        {
            get
            {
                return this.serviceURL;
            }
        }

        public int WebServerPort
        {
            get
            {
                return this.webServerPort;
            }
        }

        public string WebServerFolder
        {
            get
            {
                return this.webServerFolder;
            }
        }

        public string WebServerURL
        {
            get
            {
                return this.webServerURL;
            }
        }

        
    }
}
