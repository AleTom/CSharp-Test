namespace Reverse
{
    public class CharReverse
    {
        public string Reverse(string input)
        {
            var words = input.Split(' ');
            var result = "";
            for (int i = 0; i < words.Length; i++) 
            {
                var reversedWord = reverseWord(words[i]);
                if (i < words.Length - 1) {
                    result += reversedWord + " ";
                } else {
                    result += reversedWord;
                }
            }
            return result;
        }

        bool isPunctuation(char c) 
        {
            if (c.Equals(',') || c.Equals(';') || c.Equals(':') || c.Equals('.'))
                return true;
            return false;
        }

        string collectPunctuation(string wrd)
        {
            var chars = wrd.ToCharArray();
            var result = "";
            for (var i = wrd.Length - 1; i >= 0; i--)
            {
                if (isPunctuation(chars[i]))
                {
                    result += chars[i];
                }
                else
                {
                    return result;
                }
            }
            return result;
        }

        string reverseWord(string wrd)
        {
            var punctuation = "";
            var chars = wrd.ToCharArray();
            var startAt = chars.Length;
            if (wrd.Length > 0 && isPunctuation(wrd.Last()))
            {
                punctuation = collectPunctuation(wrd);
                startAt -= punctuation.Length;
            }
            
            var result = "";
            
            for (var i = startAt - 1; i >= 0; i--)
            {
                if (isPunctuation(chars[i]))
                {
                    var wordSplit = wrd.Substring(0, i + 1);
                    return reverseWord(wordSplit) + result;
                }
                else
                {
                    result += chars[i];
                }
            }
            return result + punctuation;
        }
    }
}