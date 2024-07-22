namespace StringReversalAPI
{
    public class StringHelper
    {
        public string ReverseString(string input)
        {
            // Convert the input string to a character array.
            char[] charArray = input.ToCharArray();

            // Reverse the character array in place.
            Array.Reverse(charArray);

            // Create a new string from the reversed character array.
            return new string(charArray);
        }

        public bool IsPalindrome(string input)
        {
            var reversedString = ReverseString(input);

            // Compare the original string with the reversed string
            return string.Equals(input, reversedString, StringComparison.OrdinalIgnoreCase);
        }
    }


}
