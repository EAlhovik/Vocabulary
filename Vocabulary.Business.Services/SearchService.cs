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
        /// <param name="theme"> </param>
        /// <returns> Collection words. </returns>
        public IEnumerable<Word> SearchByTerm(string term, ThemeEnum theme)
        {
            if (String.IsNullOrEmpty(term))
            {
                return vocabularyUow.Words.All().Where(w => w.Theme == theme);
            }
            return vocabularyUow.Words.All().Where(w => w.Key.Contains(term) && w.Theme == theme);
        }
    }
}