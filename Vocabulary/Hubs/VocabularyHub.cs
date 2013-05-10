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
        public void SearchWords(String term, ThemeEnum theme)
        {
            var uow = new VocabularyUow(new VocabularyDbContext());
            ISearchService searchService = new SearchService(uow);
      

            foreach (var item in searchService.SearchByTerm(term, theme))
            {
                Clients.PublishWords(item.Key);
            }
        }

        public void GetDescription(String key)
        {
            var uow = new VocabularyUow(new VocabularyDbContext());
            IVocabularyService vocabularyService = new VocabularyService(uow);

            Word word = vocabularyService.GetByKey(key);
            Clients.PublishDescription(word.Key, word.Theme, word.Description);
        }

        public void GetDescriptionForModal(String key)
        {
            var uow = new VocabularyUow(new VocabularyDbContext());
            IVocabularyService vocabularyService = new VocabularyService(uow);

            Word word = vocabularyService.GetByKey(key);
            Clients.PublishDescriptionForModal(word);
        }

        public void UpdateWord(Word word)
        {
            var uow = new VocabularyUow(new VocabularyDbContext());
            IVocabularyService vocabularyService = new VocabularyService(uow);

            try
            {
                vocabularyService.UpdateWord(word);
                Clients.PublishUpdated("Успех!");
            }
            catch(Exception)
            {
                Clients.PublishUpdated("Ошибка");
                
            }
        }
    }
}