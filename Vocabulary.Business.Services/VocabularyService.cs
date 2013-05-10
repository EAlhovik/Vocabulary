using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vocabulary.Business.Contracts;
using Vocabulary.Business.Entities;
using Vocabulary.Data.Contracts;

namespace Vocabulary.Business.Services
{
    public class VocabularyService : IVocabularyService
    {
        private readonly IVocabularyUow vocabularyUow;
        public VocabularyService(IVocabularyUow vocabularyUow)
        {
            this.vocabularyUow = vocabularyUow;
        }

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns>List words</returns>
        public IEnumerable<Word> GetAll()
        {
            return vocabularyUow.Words.All();
        }

        /// <summary>
        /// Gets the by key.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns> The word </returns>
        public Word GetByKey(String key)
        {
            return vocabularyUow.Words.All().First(w => w.Key.Equals(key));
        }

        /// <summary>
        /// Updates the word.
        /// </summary>
        /// <param name="word">The word.</param>
        public void UpdateWord(Word word)
        {
            if(word.IsNew())
            {
                vocabularyUow.Words.InsertOrUpdate(word, true);
            }
            else
            {
                var dbWord = vocabularyUow.Words.GetById(word.Id);
                vocabularyUow.Words.InsertOrUpdate(dbWord, true);
                dbWord.Key = word.Key;
                dbWord.Theme = word.Theme;
                dbWord.Description = word.Description;
            }
            
            vocabularyUow.Commit();
        }

        /// <summary>
        /// Deletes the word.
        /// </summary>
        /// <param name="word">The word.</param>
        public void DeleteWord(Word word)
        {
            vocabularyUow.Words.Delete(word);
            vocabularyUow.Commit();
        }
    }
}
