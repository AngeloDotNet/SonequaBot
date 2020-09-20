using SonequaBot.Commands.Interfaces.Responses;
using TwitchLib.Client.Events;

namespace SonequaBot.Commands
{
    public class CommandDevastante : CommandBase, IResponseVisual
    {
        protected new string Command = "!devastante";
        
        public string GetVisualEvent(OnMessageReceivedArgs e)
        {
            return "SendDevastante";
        }
    }
}