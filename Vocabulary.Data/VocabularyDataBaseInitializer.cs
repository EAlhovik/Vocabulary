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
                                       new Word(){Key = "крааль",Theme = ThemeEnum.All, Description = "kraal"},
                                       new Word(){Key = "князь",Theme = ThemeEnum.All, Description = "prince"},
                                       new Word(){Key = "нравиться",Theme = ThemeEnum.All, Description = "please"},
                                       new Word(){Key = "нравоучение",Theme = ThemeEnum.All, Description = "lecture, moral admonition;"},
                                       new Word(){Key = "ко всем чертям!",Theme = ThemeEnum.All, Description = "to hell with it!"},
                                   };
            foreach (Word word in words)
            {
                context.Words.Add(word);
            }
            context.SaveChanges();
        }
    }
}
