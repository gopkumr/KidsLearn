using KidsLearn.Shared.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsLearn.Shared.services
{
    public interface IDictionaryService
    {
        public Task<List<DictionaryResponse>> GetMoreAboutTheWord(string word);
    }
}
