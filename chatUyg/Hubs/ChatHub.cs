using System;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using chatUyg.Models;

namespace SignalRChat.Hubs
 
{
    public class ChatHub : Hub
    {
        readonly DatabaseContext _dbContext;
       public ChatHub(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task SendMessage(string user, string message)
        {
            Message messageObject = new Message()
            {
                UserName = user,
                MessageText = message,
                MessageDate = DateTime.Now
            };
            _dbContext.Messages.Add(messageObject);
            await _dbContext.SaveChangesAsync();
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
