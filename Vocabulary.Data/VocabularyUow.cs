using System;
using System.Data.Entity;
using Vocabulary.Business.Entities;
using Vocabulary.Data.Contracts;
using Vocabulary.Data.Helpers;
using Vocabulary.Data.Repositories;

namespace Vocabulary.Data
{
    /// <summary>
    /// Represents uniti of work for vacabulary db
    /// </summary>
    public class VocabularyUow : IVocabularyUow, IDisposable
    {
        private readonly DbContext dbContext;
     //   private IRepositoryProvider RepositoryProvider { get; set; }

        public VocabularyUow(VocabularyDbContext dbContext
            //, IRepositoryProvider repositoryProvider
            )
        {
            this.dbContext = dbContext;
            ConfigureDbContext();
         //   RepositoryProvider = repositoryProvider;
        }

        #region IDisposable Members

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion

        #region IVocabularyUow Members

        /// <summary>
        /// Gets the words from repository.
        /// </summary>
        public IRepository<Word> Words
        {
            get
            {
                return new WordRepository(dbContext);
             //   return GetStandardRepo<Word>();
            }
        }

        /// <summary>
        /// Commits info from DbContext to database.
        /// </summary>
        public void Commit()
        {
            dbContext.SaveChanges();
        }

        #endregion

        //private IRepository<T> GetStandardRepo<T>() where T : class, IEntity
        //{
        //    return RepositoryProvider.GetRepositoryForEntityType<T>();
        //}

        /// <summary>
        /// Dispose of the appropriate parameter value
        /// </summary>
        /// <param name="disposing"><c>true</c> if disposing;</param>
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (dbContext != null)
                {
                    dbContext.Dispose();
                }
            }
        }

        /// <summary>
        /// Creates dbcontext for database
        /// </summary>
        protected void ConfigureDbContext()
        {
            dbContext.Configuration.ProxyCreationEnabled = false;
            dbContext.Configuration.LazyLoadingEnabled = false;
        }
    }
}
