using Vocabulary.Business.Entities;

namespace Vocabulary.Data.Contracts
{
    /// <summary>
    /// Declares interface for unity of work of vocabulary context
    /// </summary>
    public interface IVocabularyUow
    {
        /// <summary>
        /// Gets the words from repository.
        /// </summary>
        IRepository<Word> Words { get; }

        /// <summary>
        /// Commits info from DbContext to database.
        /// </summary>
        void Commit();
    }
}
