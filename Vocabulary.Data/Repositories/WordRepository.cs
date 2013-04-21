using System.Data.Entity;
using Vocabulary.Business.Entities;
using Vocabulary.Data.Contracts;

namespace Vocabulary.Data.Repositories
{
    /// <summary>
    /// Represents Word repository
    /// </summary>
    public class WordRepository : EFRepository<Word>, IWordRepository
    {
        public WordRepository(DbContext dbContext)
            : base(dbContext)
        {

        }
    }
}
