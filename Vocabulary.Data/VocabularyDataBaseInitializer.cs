using System.Data.Entity;

namespace Vocabulary.Data
{
    /// <summary>
    /// The data base initializer
    /// </summary>
    /// <remarks>
    /// Drop and create database if model change
    /// </remarks>
    internal class VocabularyDataBaseInitializer : DropCreateDatabaseIfModelChanges<VocabularyDbContext>
    {
        protected override void Seed(VocabularyDbContext context)
        {
            context.SaveChanges();
        }
    }
}
