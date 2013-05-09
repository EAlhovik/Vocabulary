using System;
using System.Collections.Generic;
using Vocabulary.Business.Entities;

namespace Vocabulary.Business.Contracts
{
    /// <summary>
    /// Interface for search service
    /// </summary>
    public interface ISearchService
    {
        /// <summary>
        /// Searches the by term.
        /// </summary>
        /// <param name="term">The search term.</param>
        /// <param name="theme">type theme </param>
        /// <returns>Collection words</returns>
        IEnumerable<Word> SearchByTerm(String term, ThemeEnum theme);
    }
}