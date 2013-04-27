using System;
using SignalR.Hubs;

namespace Vocabulary.Hubs
{
    public class VocabularyHub : Hub
    {
        public void SearchWords(string term)
        {
            for (var i = 0; i < 100;i++ )
            {
                System.Threading.Thread.Sleep(1);
                Clients.PublishWords(String.Format("{0}-{0}-{1}", term,i));
            }
        }
    }
}