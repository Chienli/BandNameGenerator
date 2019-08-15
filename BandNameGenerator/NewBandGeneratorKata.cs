namespace BandNameGenerator
{
    public class NewBandGeneratorKata
    {
        public string GetNewBandName(string str)
        {
            if (str[0] != str[str.Length - 1])
            {
                return $"The {str[0].ToString().ToUpper() + str.Substring(1, str.Length - 1)}";
            }
            else
            {
                return
                    $"{str[0].ToString().ToUpper() + str.Substring(1, str.Length - 1) + str.Substring(1, str.Length - 1)}";
            }
        }
    }
}