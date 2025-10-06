using System.Diagnostics;
using Xunit;
using Assert = Xunit.Assert;

public class HexCheckerTest
{
    [Fact]
    public void ValidateHex_ShouldReturnTrue_WhenInputIsValid()
    {
        // Arrange
        HexChecker checker = new HexChecker();
        // Act
        bool result = checker.ValidateHex("#BABAS");
        // Assert
        Assert.True(result);
    }


    [Fact]
    public void ValidateHex_ShouldReturnFalse_WhenInputIsNotValid()
    {
        // Arrange
        HexChecker checker = new HexChecker();
        // Act
        bool result = checker.ValidateHex("BABAS");
        // Assert
        Assert.True(result);
    }
}

public class HexChecker
{
    public bool ValidateHex(string hexCode)
    {
        string inputString;
        inputString = hexCode;
        if (inputString[0] != '#')
        {
            return false;
        }

        bool isValid = true;
        foreach (char c in inputString.Substring(1))
        {
            int ascii = (int)c;
            if ((ascii >= 65 && ascii <= 70) || (ascii >= 48 && ascii <= 57))
            {
                continue;
            }

            isValid = false;
            break;
        }

        if (isValid)
        {
            return true;
        }
        return false;
    }
}