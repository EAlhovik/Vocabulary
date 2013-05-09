using System;
using SignalR.Hubs;
using Vocabulary.Business.Contracts;
using Vocabulary.Business.Entities;
using Vocabulary.Business.Services;
using Vocabulary.Data;

namespace Vocabulary.Hubs
{
    [HubName("vocabularyHub")]
    public class VocabularyHub : Hub
    {
        public void SearchWords(string term, ThemeEnum theme)
        {
            var uow = new VocabularyUow(new VocabularyDbContext());
            ISearchService searchService = new SearchService(uow);

            foreach (var item in searchService.SearchByTerm(term, theme))
            {
                Clients.PublishWords(String.Format("{0} - {1}", item.Key, theme.ToString()));
            }
        }
    }
}