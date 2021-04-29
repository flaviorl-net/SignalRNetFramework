using Microsoft.AspNet.SignalR;
using System.Threading;

namespace SignalRNetFramework.Hubs
{
    public class ChatHub : Hub
    {
        public void Send(string name, string message)
        {
            // Call the addNewMessageToPage method to update clients.
            Clients.All.addNewMessageToPage(name, message);
        }

        public void SystemMessage()
        {
            string[] messages = new string[5] { "Testing...", "1", "2", "3", "Finished" };

            foreach (var item in messages)
            {
                Thread.Sleep(1000);
                Clients.Caller.addNewMessageToPage("Adm", item);
            }
        }

    }
}