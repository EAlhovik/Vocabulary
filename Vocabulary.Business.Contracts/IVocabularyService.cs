using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vocabulary.Business.Entities;

namespace Vocabulary.Business.Contracts
{
    /// <summary>
    /// Interface for vocabulary sercice
    /// </summary>
    public interface IVocabularyService
    {
        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns>lsit words</returns>
        IEnumerable<Word> GetAll();

        /// <summary>
        /// Gets the by key.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>The word</returns>
        Word GetByKey(String key);

        /// <summary>
        /// Updates the word.
        /// </summary>
        /// <param name="word">The word.</param>
        void UpdateWord(Word word);

        /// <summary>
        /// Deletes the word.
        /// </summary>
        /// <param name="word">The word.</param>
        void DeleteWord(Word word);
    }
}
