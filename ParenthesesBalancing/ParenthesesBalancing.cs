using System.Text.RegularExpressions;

namespace ParenthesesBalancing
{
    public class ParenthesesBalancing
    {
        /// <summary>
        /// assumptions: first guard clause checks wether the input is empty and it returns true
        /// the the string is scanned and a counter is assigned to open and close parentheses, the assumption is that is not possible to start with a closing parenthteses
        /// therefore as soon as the close parentheses outweight the open ones a false is returned as it is an unbalanced scenario.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public bool IsBalanced(string input)
        {
            if(input.Equals(""))
                return true;

            var chars = input.ToCharArray();
            var counter = 0;
            for (int i = 0; i < chars.Length; i++) 
            {
                if (chars[i].Equals('('))
                    counter++;
                if (chars[i].Equals(')'))
                    counter--;
                if (counter < 0)
                    return false;
            }
            if (counter != 0)
                return false;
            return true;
        }
    }
}