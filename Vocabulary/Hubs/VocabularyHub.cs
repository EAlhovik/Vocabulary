using System;
using System.Linq;
using SignalR;
using SignalR.Hubs;
using Vocabulary.Business.Contracts;
using Vocabulary.Business.Entities;
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
        public void SearchWords(string term, LanguageEnum fromLanguage)
        {
            var uow = new VocabularyUow(new VocabularyDbContext());
            ISearchService searchService = new SearchService(uow);

            foreach (var item in searchService.SearchByTerm(term, fromLanguage))
            {
                Clients.PublishWords(String.Format("{0} - {1}", item.Key, fromLanguage.ToString()));
            }
        }
    }
}