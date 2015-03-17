namespace _01.StringBuilderSubstring
{
    using System.Text;

    public static class Extensions
    {
        public static StringBuilder Substring(this StringBuilder str, int index, int length)
        {
            var sb = new StringBuilder();

            for (int i = index; i < index + length && i < str.Length; i++)
            {
                sb.Append(str[i]);
            }

            return sb;
        }
    }
}
