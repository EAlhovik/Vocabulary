using System.ComponentModel;
using Vocabulary.Business.Entities;

namespace Vocabulary.Business.ViewModels
{
    /// <summary>
    /// Represents display list veiw model
    /// </summary>
    public class DisplayListViewModel
    {
        /// <summary>
        /// Gets or sets the theme.
        /// </summary>
        [DisplayName("Тема")]
        public ThemeEnum Theme { get; set; }
    }
}