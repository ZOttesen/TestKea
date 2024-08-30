using System.Text.RegularExpressions;

namespace Week1;

public class RomanNumeralConverter
{
    
    private static readonly Dictionary<char, int> RomanMap = new Dictionary<char, int>
    {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000}
    };

    public int RomanToInt(string romanNumeral)
    {
        romanNumeral = romanNumeral.ToUpper();
        NotNullOrEmpty(romanNumeral);
        ValidRomanNumeral(romanNumeral);
        ValidateRomanNumeral(romanNumeral);
        
        int total = 0;
        for (int i = 0; i < romanNumeral.Length; i++)
        {
            if (i + 1 < romanNumeral.Length && RomanMap[romanNumeral[i]] < RomanMap[romanNumeral[i + 1]])
            {
                total -= RomanMap[romanNumeral[i]];
            }
            else
            {
                total += RomanMap[romanNumeral[i]];
            }
        }
        return total;
    }
    
    public void NotNullOrEmpty(string romanNumeral)
    {
        if (string.IsNullOrEmpty(romanNumeral))
        {
            throw new ArgumentException("Invalid Roman Numeral");
        }
    }
    
    public void ValidRomanNumeral(string romanNumeral)
    {
        foreach (char c in romanNumeral)
        {
            if (!RomanMap.ContainsKey(c))
            {
                throw new ArgumentException("Invalid Roman Numeral");
            }
        }
    }
    

    public void ValidateRomanNumeral(string romanNumeral)
    {
        string romanPattern = @"^M{0,3}(CM|CD|D?C{0,3})(XC|XL|L?X{0,3})(IX|IV|V?I{0,3})$";
        if (!Regex.IsMatch(romanNumeral, romanPattern))
        {
            throw new ArgumentException("Invalid Roman Numeral");
        }
    }

}