using System;
using System.Linq;
using SignalR;
using SignalR.Hubs;
using Vocabulary.Business.Contracts;
using Vocabulary.Business.Services;
using Vocabulary.Controllers;
using Vocabulary.Data;
using Vocabulary.Data.Contracts;
using Vocabulary.Data.Helpers;
using Autofac;

namespace Vocabulary.Hubs
{
    [HubName("vocabularyHub")]
    public class VocabularyHub : Hub
    {
        public void SearchWords(string term)
        {
            var uow = new VocabularyUow(new VocabularyDbContext());


            foreach (var item in uow.Words.All().ToList())
            {
                Clients.PublishWords(String.Format("{0}", item.Key));
            }
            Clients.PublishWords(String.Format("{0}-{0}-{1}", term, term));
        }
    }
}