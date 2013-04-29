using System;

namespace Vocabulary.Business.Entities
{
    /// <summary>
    /// The vocabluary entity
    /// </summary>
    public class Word : Entity
    {
        public String Key { get; set; }
        public LanguageEnum Language { get; set; }
        public String Description { get; set; }
    }
}
