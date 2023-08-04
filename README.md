# System.Text.Regex_Practice
Pretty basic demo for understanding the syntax. Best way to write a validation is Google it.

**How can you use regular expressions in C# for string manipulation and pattern matching? Write some sample scenarios.**

Regular expressions in C# are powerful tools for performing string manipulation and pattern matching operations. 
You can use the System.Text.RegularExpressions namespace to work with regular expressions in C#. The Regex class provides methods for searching, 
replacing, and validating strings based on regular expression patterns.

For example, you can use the Regex.Match() method to find the first occurrence of a pattern in a string, 
and the Regex.Replace() method to replace all occurrences of a pattern in a string.

string input = "The quick brown fox jumps over the lazy dog";
string pattern = @"\b\w{5}\b"; // pattern to match 5-letter words
Match match = Regex.Match(input, pattern);
if (match.Success)
{
  Console.WriteLine($"Found match: {match.Value}");
}

string replaced = Regex.Replace(input, "fox", "cat");
Console.WriteLine($"Replaced string: {replaced}");
