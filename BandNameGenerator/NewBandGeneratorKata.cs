namespace BandNameGenerator
{
    public class NewBandGeneratorKata
    {
        public string GetNewBandName(string str)
        {
            return IsDiffFirstEndLetter(str) ? $"The {TheFirstLetterToUpper(str) + GetTheStringWithoutFirstLetter(str)}" : $"{TheFirstLetterToUpper(str) + GetTheStringWithoutFirstLetter(str) + GetTheStringWithoutFirstLetter(str)}";
        }

        private static bool IsDiffFirstEndLetter(string str)
        {
            return str[0] != str[str.Length - 1];
        }

        private static string GetTheStringWithoutFirstLetter(string str)
        {
            return str.Substring(1, str.Length - 1);
        }

        private static string TheFirstLetterToUpper(string str)
        {
            return str[0].ToString().ToUpper();
        }
    }
}