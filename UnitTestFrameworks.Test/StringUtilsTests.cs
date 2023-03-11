using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestFrameworks.ClassLib;

namespace UnitTestFrameworks.Test;

[TestFixture]
public class StringUtilsTests
{
    private StringUtilities _stringUtilities;

    [SetUp]
    public void Setup()
    {
        _stringUtilities = new StringUtilities();
    }


    [Test]
    public void GetMaxUnequalConsecutiveChars_WhenInputIsEmpty_ReturnsZero()
    {
        // Arramge
        string? input = "";

        // Act
        //int result = StringUtilities.
    }
}
