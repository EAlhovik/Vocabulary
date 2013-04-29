using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vocabulary.Business.Contracts;
using Vocabulary.Business.Entities;
using Vocabulary.Data.Contracts;

namespace Vocabulary.Business.Services
{
    public class VocabularyService : IVocabularyService
    {
        private readonly IVocabularyUow vocabularyUow;
        public VocabularyService(IVocabularyUow vocabularyUow)
        {
            this.vocabularyUow = vocabularyUow;
        }

        public IEnumerable<Word> GetAll()
        {
            return vocabularyUow.Words.All();
        }
    }
}
