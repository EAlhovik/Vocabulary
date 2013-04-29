using System.Collections.Generic;
using System.Data.Entity;
using Vocabulary.Business.Entities;

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
            List<Word> words = new List<Word>()
                                   {
                                       new Word(){Key = "крааль",Language = LanguageEnum.Ru, Description = "kraal"},
                                       new Word(){Key = "князь",Language = LanguageEnum.Ru, Description = "prince"},
                                       new Word(){Key = "нравиться",Language = LanguageEnum.Ru, Description = "please"},
                                       new Word(){Key = "нравоучение",Language = LanguageEnum.Ru, Description = "lecture, moral admonition;"},
                                       new Word(){Key = "ко всем чертям!",Language = LanguageEnum.Ru, Description = "to hell with it!"},
                                   };
            foreach (Word word in words)
            {
                context.Words.Add(word);
            }
            context.SaveChanges();
        }
    }
}
