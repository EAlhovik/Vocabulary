using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Vocabulary.Business.Entities
{
    /// <summary>
    /// Base class for entities.
    /// </summary>
    public class Entity:IEntity
    {
        /// <summary>
        /// Gets or sets the entity id.
        /// </summary>
        [XmlIgnore]
        [Key]
        public long Id { get; set; }

        /// <summary>
        /// Checks if entity is new.
        /// </summary>
        /// <returns>
        /// Returns a value indicating whether provided entity is new (not added previously).
        /// </returns>
        public bool IsNew()
        {
            return (Id == 0);
        }
    }
}
