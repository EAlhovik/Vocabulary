using System;
using System.Collections.Generic;
using System.Linq;
using Vocabulary.Business.Contracts;
using Vocabulary.Business.Entities;
using Vocabulary.Data.Contracts;

namespace Vocabulary.Business.Services
{
    /// <summary>
    /// Represents search service
    /// </summary>
    public class SearchService : ISearchService
    {
        private readonly IVocabularyUow vocabularyUow;

        public SearchService(IVocabularyUow vocabularyUow)
        {
            this.vocabularyUow = vocabularyUow;
        }

        /// <summary>
        /// Searches the by term.
        /// </summary>
        /// <param name="term">The search term.</param>
        /// <returns> Collection words. </returns>
        public IEnumerable<Word> SearchByTerm(string term, LanguageEnum language)
        {
            if (String.IsNullOrEmpty(term))
            {
                return vocabularyUow.Words.All().Where(w => w.Language == language);
            }
            return vocabularyUow.Words.All().Where(w => w.Key.Contains(term) && w.Language == language);
        }
    }
}