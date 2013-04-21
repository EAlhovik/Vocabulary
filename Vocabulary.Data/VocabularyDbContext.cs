using System.Data.Entity;
using Vocabulary.Business.Entities;

namespace Vocabulary.Data
{
    /// <summary>
    /// Represents db context for vocabulary models
    /// </summary>
    public class VocabularyDbContext: DbContext
    {
        static VocabularyDbContext()
        {
            Database.SetInitializer(new VocabularyDataBaseInitializer());
        }

        public VocabularyDbContext(string connectionStringName)
            : base(connectionStringName)
        {
        }

        /// <summary>
        /// Gets or sets the words.
        /// </summary>
        public DbSet<Word> Words { get; set; }
    }
}
