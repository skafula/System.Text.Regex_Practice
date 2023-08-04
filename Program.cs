using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        //Regular expression is for to check if input value is match with the condition (like i want to accept only digits) -> Best pattern matching for input validation
        //System.Text.RegularExpressions -> Regex

        //Best way to find validations is Googl :) -> most of the possible Regex validations are already exists

        Regex regexDig = new Regex("^[0-9]*$"); //^-> starts with, [...] range of valid characters, * -> it could be more characters, $ -> must be end with
        Regex regexAlph = new Regex("^[a-zA-Z ]*$");

        Console.WriteLine("Enter a digit: ");
        string input = "";
        bool regMatch = false;
        do
        {
            input = Console.ReadLine();
            regMatch = regexDig.IsMatch(input);
            Console.WriteLine(regMatch.ToString());
        } while (!regMatch);

        Console.WriteLine("Enter your full name: ");
        do
        {
            input = Console.ReadLine();
            regMatch = regexAlph.IsMatch(input);
            Console.WriteLine(regMatch.ToString());
        } while (!regMatch);

    }
}