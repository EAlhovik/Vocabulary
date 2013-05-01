using Vocabulary.Business.Entities;

namespace Vocabulary.Business.ViewModels
{
    /// <summary>
    /// Represents vocabulary veiw model
    /// </summary>
    public class VocabularyViewModel
    {
        /// <summary>
        /// Gets or sets from language.
        /// </summary>
        public LanguageEnum FromLanguage { get; set; }

        /// <summary>
        /// Gets or sets to language.
        /// </summary>
        public LanguageEnum ToLanguage { get; set; }
    }
}
