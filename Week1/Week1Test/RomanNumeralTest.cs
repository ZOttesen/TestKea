using Week1;

namespace Week1Test;

public class RomanNumeralTest
{
    private readonly RomanNumeralConverter _romanNumeralConverter = new RomanNumeralConverter();
    
    [Theory]
    [InlineData("I", 1)]
    [InlineData("II", 2)]
    [InlineData("III", 3)]
    [InlineData("V", 5)]
    [InlineData("X", 10)]
    [InlineData("L", 50)]
    [InlineData("C", 100)]
    [InlineData("D", 500)]
    [InlineData("M", 1000)]
    [InlineData("MCDXLIII", 1443)]
    [InlineData("MMMDCCCLXXXVIII", 3888)]
    public void CorrectNumber(string romanNumeral, int expected)
    {
        Assert.Equal(expected, _romanNumeralConverter.RomanToInt(romanNumeral));
    }
    
    [Theory]
    [InlineData("i", 1)]
    [InlineData("ii", 2)]
    [InlineData("iii", 3)]
    [InlineData("v", 5)]
    [InlineData("x", 10)]
    [InlineData("l", 50)]
    [InlineData("c", 100)]
    [InlineData("d", 500)]
    [InlineData("m", 1000)]
    [InlineData("mcdxliii", 1443)]
    [InlineData("mmmdccclxxxviii", 3888)]    
    public void LowerCaseLetters(string romanNumeral, int expected)
    {
        Assert.Equal(expected, _romanNumeralConverter.RomanToInt(romanNumeral));
    }
    
    [Theory]
    [InlineData("Q")]
    [InlineData("A")]
    [InlineData("MMCP")]
    [InlineData("")]
    [InlineData("1234")]
    [InlineData("?!:")]
    public void InvalidRomanNumeral(string romanNumeral)
    {
        Assert.Throws<ArgumentException>(() => _romanNumeralConverter.RomanToInt(romanNumeral));
    }
    
    [Theory]
    [InlineData("IIII")]
    [InlineData("VV")]
    [InlineData("XXXX")]
    [InlineData("LL")]
    [InlineData("CCCC")]
    [InlineData("DD")]
    [InlineData("MMMM")]
    [InlineData("IM")]
    [InlineData("ID")]
    [InlineData("XD")]
    [InlineData("XM")]
    [InlineData("IL")]
    [InlineData("IC")]
    [InlineData("VM")]
    [InlineData("VL")]
    [InlineData("VC")]
    [InlineData("VD")]
    [InlineData("LD")]
    [InlineData("LC")]
    [InlineData("LM")]
    [InlineData("DM")]
    [InlineData("IIV")]
    [InlineData("IIX")]
    [InlineData("XXL")]
    public void InvalidRomanNumeralPattern(string romanNumeral)
    {
        Assert.Throws<ArgumentException>(() => _romanNumeralConverter.RomanToInt(romanNumeral));
    }

    [Fact]
    public void NullInput()
    {
        Assert.Throws<NullReferenceException>(() => _romanNumeralConverter.RomanToInt(null));
    }

    
}