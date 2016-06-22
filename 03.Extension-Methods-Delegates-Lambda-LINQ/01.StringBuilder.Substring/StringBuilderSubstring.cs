namespace ExtensionMethod
{
    using System;
    using System.Text;

    public static class ExtensionStringBuilder
    {
        public static StringBuilder SubstringExtension(this string input, int index, int length)
        {
            if (((index >= input.Length || index < 0)) || ((length > input.Length - index) || (length <= 0)))
            {
                throw new ArgumentOutOfRangeException();
            }
            StringBuilder substr = new StringBuilder();
            for (int i = index; i < index + length; i++)
            {
                substr.Append(input[i]);
            }
            return substr;
        }
    }
}
