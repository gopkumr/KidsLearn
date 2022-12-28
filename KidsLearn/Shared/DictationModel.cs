namespace KidsLearn.Shared
{
    public class DictationModel
    {
        public int Index { get; set; }
        public string Word { get; set; } = string.Empty;
        public string EnteredWord { get; set; } = string.Empty;

        public bool IsCorrect => string.Equals(Word, EnteredWord, StringComparison.InvariantCultureIgnoreCase);
    }
}