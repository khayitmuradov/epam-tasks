using NUnit.Framework.Internal;
using UnitTestFrameworks.ClassLib;

namespace UnitTestFrameworks.Test;

[TestFixture]
public class StringUtilsTests
{
    [Test]
    public void GetMaxUnequalConsecutiveChars_WhenInputIsEmpty_ReturnsZero()
    {
        // Arramge
        string? input = "";

        // Act
        int result = StringUtilities.GetMaxUnequalConsecutiveChars(input);

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void GetMaxUnequalConsecutiveChars_WhenInputHasRepeatingChars_ReturnsMaxCount()
    {
        // Arrange
        string input = "aabbcccdddeeeeffff";

        // Act
        int result = StringUtilities.GetMaxUnequalConsecutiveChars(input);

        // Assert
        Assert.That(result, Is.EqualTo(2));
    }

    [Test]
    public void GetMaxConsecutiveLetters_WhenInputIsEmpty_ReturnsZero()
    {
        // Arrange
        string input = "";

        // Act
        int result = StringUtilities.GetMaxConsecutiveLetters(input);

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void GetMaxConsecutiveLetters_WhenInputHasNoConsecutiveLetters_ReturnsOne()
    {
        // Arrange
        string input = "12345";

        // Act
        int result = StringUtilities.GetMaxConsecutiveLetters(input);

        // Assert
        Assert.That(result, Is.EqualTo(1));
    }

    [Test]
    public void GetMaxConsecutiveLetters_WhenInputHasConsecutiveLetters_ReturnsMaxCount()
    {
        // Arrange
        string input = "aabbccdefggg";

        // Act
        int result = StringUtilities.GetMaxConsecutiveLetters(input);

        // Assert
        Assert.That(result, Is.EqualTo(3));
    }

    [Test]
    public void GetMaxConsecutiveDigits_WhenInputIsEmpty_ReturnsZero()
    {
        // Arrange
        string input = "";

        // Act
        int result = StringUtilities.GetMaxConsecutiveDigits(input);

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void GetMaxConsecutiveDigits_WhenInputHasNoConsecutiveDigits_ReturnsOne()
    {
        // Arrange
        string input = "abcd";

        // Act
        int result = StringUtilities.GetMaxConsecutiveDigits(input);

        // Assert
        Assert.That(result, Is.EqualTo(1));
    }

    [Test]
    public void GetMaxConsecutiveDigits_WhenInputHasConsecutiveDigits_ReturnsMaxCount()
    {
        // Arrange
        string input = "123333444455555";

        // Act
        int result = StringUtilities.GetMaxConsecutiveDigits(input);

        // Assert
        Assert.That(result, Is.EqualTo(5));
    }
}
