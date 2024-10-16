namespace Day2
{
    public class InputValidation
    {
        public static bool IsNumberAndInRange(string input, int min, int max, out int number)
        {
            bool IsValid = int.TryParse(input, out number);
            return (IsValid && number <= max && number >= min);
        }
    }
}
