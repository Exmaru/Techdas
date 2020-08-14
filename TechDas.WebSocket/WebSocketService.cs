using Adsnsoft.SelfHost;
using Adsnsoft.WebSocket;
using Microsoft.Owin.Hosting;
using System;
using System.Threading;

namespace TechDas.WebSocket
{
    public partial class WebSocketService : WebSocketServer
    {
        protected Thread thread { get; set; }

        public WebSocketService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            thread = new Thread(new ThreadStart(ThreadProc));
            thread.Start();

            this.SeverStart(AppConfig.Current.ServiceURL, new Action(() =>
            {
                if (Environment.UserInteractive)
                {
                    Console.WriteLine($"Socket Server running on {AppConfig.Current.ServiceURL}");
                    Console.ReadLine();
                }
            }));
        }

        private void ThreadProc()
        {
            SelfHostServer server = new SelfHostServer();
            server.WebServerFolder = AppConfig.Current.WebServerFolder;
            server.Open(AppConfig.Current.WebServerPort);
        }

        protected override void OnStop()
        {
        }

        public void Start()
        {
            this.OnStart(null);
        }
    }
}
