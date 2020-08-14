using Adsnsoft.WebSocket;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechDas.DTO;

namespace TechDas.WebSocket
{
    [HubName("sender")]
    public class PythonHub : Hub
    {
        public void SendString(string str)
        {
            Clients.All.toSendString(str);
        }

        public void SendSingle(PythonData data)
        {
            Clients.All.toSendSingle(data);
        }

        public void SendArray(List<PythonData> list)
        {
            Clients.All.toSendArray(list);
        }

        public void SendRandom(string id)
        {
            Clients.All.toSendSingle(PythonData.CreateRandom(id));
        }

    }
}
