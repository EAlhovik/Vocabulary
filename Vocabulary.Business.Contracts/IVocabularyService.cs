using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vocabulary.Business.Entities;

namespace Vocabulary.Business.Contracts
{
    public interface IVocabularyService
    {
        IEnumerable<Word> GetAll();
    }
}
