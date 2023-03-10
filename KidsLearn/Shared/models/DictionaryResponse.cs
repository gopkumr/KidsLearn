using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsLearn.Shared.models
{
    public class Definition
    {
        public string definition { get; set; }
        public string example { get; set; }
        public List<object> synonyms { get; set; }
        public List<object> antonyms { get; set; }
    }

    public class Meaning
    {
        public string partOfSpeech { get; set; }
        public List<Definition> definitions { get; set; }
    }

    public class Phonetic
    {
        public string text { get; set; }
        public string audio { get; set; }
    }

    public class DictionaryResponse
    {
        public string word { get; set; }
        public string phonetic { get; set; }
        public List<Phonetic> phonetics { get; set; }
        public string origin { get; set; }
        public List<Meaning> meanings { get; set; }
    }
}
