using Microsoft.VisualStudio.TestTools.UnitTesting;
using UtilityLibraries;
namespace StringLibraryTest;

[TestClass]
public class UnitTest1
{
  
   [TestMethod]
    public void Test_Add_TwoPositiveNumbers_ReturnSum()
    {
        // Assign values
        decimal x = 2.2m;
        decimal y = 4.5m;
        decimal expectedSum = 6.7m;

        // Actual Sum
        decimal actualSum = StringLibrary.Add(x, y);

        // Assert
        Assert.AreEqual(expectedSum, actualSum);
    }
    [TestMethod]
    public void Test_Add_PositiveAndNegativeNumber_ReturnSum()
    {
    // Assign values
    decimal x = 11.2m;
    decimal y = -5.4m;
    decimal expectedSum = 5.8m;

    // Actual Sum
    decimal actualSum = StringLibrary.Add(x, y);

    // Assert
    Assert.AreEqual(expectedSum, actualSum);
    }

    [TestMethod]
    public void Test_Add_TwoNegativeNumbers_ReturnSum()
    {
    // Assign values
    decimal x = -10.5m;
    decimal y = -3.8m;
    decimal expectedSum = -14.3m;

    // Actual Sum
    decimal actualSum = StringLibrary.Add(x, y);

    // Assert
    Assert.AreEqual(expectedSum, actualSum);
    }

    [TestMethod]
    public void Test_Add_TwoZeroNumbers_ReturnSum()
    {
    // Assign values
    decimal x = 0m;
    decimal y = 0m;
    decimal expectedSum = 0m;

    // Actual Sum
    decimal actualSum = StringLibrary.Add(x, y);

    // Assert
    Assert.AreEqual(expectedSum, actualSum);
    }

    [TestMethod]
    public void Test_Add_ZeroAndPositiveNumber_ReturnSum()
    {
    // Assign values
    decimal x = 0m;
    decimal y = 7.6m;
    decimal expectedSum = 7.6m;

    // Actual Sum
    decimal actualSum = StringLibrary.Add(x, y);

    // Assert
    Assert.AreEqual(expectedSum, actualSum);
    }

    [TestMethod]
    public void Test_Subtract_TwoPositiveNumbers_ReturnDifference()
    {
    // Assign values
    decimal x = 12.2m;
    decimal y = 3.8m;
    decimal expectedDifference = 8.4m;

    // Actual Difference
    decimal actualDifference = StringLibrary.Subtract(x, y);

    // Assert
    Assert.AreEqual(expectedDifference, actualDifference);
    }

    [TestMethod]
    public void Test_Subtract_PositiveAndNegativeNumber_ReturnDifference()
    {
    // Assign values
    decimal x = 4.8m;
    decimal y = -2.6m;
    decimal expectedDifference = 7.4m;

    // Actual Difference
    decimal actualDifference = StringLibrary.Subtract(x, y);

    // Assert
    Assert.AreEqual(expectedDifference, actualDifference);
    }

    [TestMethod]
    public void Test_Subtract_TwoNegativeNumbers_ReturnDifference()
    {
    // Assign values
    decimal x = -2.5m;
    decimal y = -8.2m;
    decimal expectedDifference = 5.7m;

    // Actual Difference
    decimal actualDifference = StringLibrary.Subtract(x, y);

    // Assert
    Assert.AreEqual(expectedDifference, actualDifference);
    }

    [TestMethod]
    public void Test_Subtract_PositiveAndZeroNumber_ReturnDifference()
    {
    // Assign values
    decimal x = 3.9m;
    decimal y = 0m;
    decimal expectedDifference = 3.9m;

    // Actual Difference
    decimal actualDifference = StringLibrary.Subtract(x, y);

    // Assert
    Assert.AreEqual(expectedDifference, actualDifference);
    }

    [TestMethod]
    public void Test_Subtract_LargeNumbers_ReturnDifference()
    {
    // Assign values
    decimal x = 0m;
    decimal y = 0m;
    decimal expectedDifference = 0m;

     // Actual Difference
    decimal actualDifference = StringLibrary.Subtract(x, y);

    // Assert
    Assert.AreEqual(expectedDifference, actualDifference);
    }

    [TestMethod]
    public void Test_Multiply_TwoPositiveNumbers_ReturnProduct()
    {
    // Assign values
    decimal x = 4.5m;
    decimal y = 5.2m;
    decimal expectedProduct = 23.4m;

    // Actual Product
    decimal actualProduct = StringLibrary.Multiply(x, y);

    // Assert
    Assert.AreEqual(expectedProduct, actualProduct);
    }

    [TestMethod]
    public void Test_Multiply_PositiveAndNegativeNumber_ReturnProduct()
    {
    // Assign values
    decimal x = 2.2m;
    decimal y = -4.5m;
    decimal expectedProduct = -9.9m;

    // Actual Product
    decimal actualProduct = StringLibrary.Multiply(x, y);

    // Assert
    Assert.AreEqual(expectedProduct, actualProduct);
    }

    [TestMethod]
    public void Test_Multiply_TwoNegativeNumbers_ReturnProduct()
    {
    // Assign values
    decimal x = -5.5m;
    decimal y = -1.2m;
    decimal expectedProduct = 6.6m;

    // Actual Product
    decimal actualProduct = StringLibrary.Multiply(x, y);

    // Assert
    Assert.AreEqual(expectedProduct, actualProduct);
    }

    [TestMethod]
    public void Test_Multiply_ZeroAndNonZeroNumber_ReturnProduct()
    {
    // Assign values
    decimal x = 0m;
    decimal y = 3.1m;
    decimal expectedProduct = 0m;

    // Actual Product
    decimal actualProduct = StringLibrary.Multiply(x, y);

    // Assert
    Assert.AreEqual(expectedProduct, actualProduct);
    }

    [TestMethod]
    public void Test_Multiply_TwoZeroNumbers_ReturnProduct()
    {
    // Assign values
    decimal x = 0m;
    decimal y = 0m;
    decimal expectedProduct = 0m;

    // Actual Product
    decimal actualProduct = StringLibrary.Multiply(x, y);

    // Assert
    Assert.AreEqual(expectedProduct, actualProduct);
    }

    [TestMethod]
    public void Test_Divide_TwoPositiveNumbers_ReturnQuotient()
    {
    // Assign values
    decimal dividend = 8.5m;
    decimal divisor = 2.5m;
    decimal expectedQuotient = 3.4m;

    // Actual Quotient
    decimal actualQuotient = StringLibrary.Divide(dividend, divisor);

    // Assert
    Assert.AreEqual(expectedQuotient, actualQuotient);
    }

    [TestMethod]
    public void Test_Divide_PositiveAndNegativeNumber_ReturnQuotientt()
    {
    // Assign values
    decimal dividend = 7.0m;
    decimal divisor = -2.5m;
    decimal expectedQuotient = -2.8m;

    // Actual Quotient
    decimal actualQuotient = StringLibrary.Divide(dividend, divisor);

    // Assert
    Assert.AreEqual(expectedQuotient, actualQuotient);
    }

    [TestMethod]
    public void Test_Divide_TwoNegativeNumbers_ReturnQuotient()
    {
    // Assign values
    decimal dividend = -20.0m;
    decimal divisor = -4.0m;
    decimal expectedQuotient = 5.0m;

    // Actual Quotient
    decimal actualQuotient = StringLibrary.Divide(dividend, divisor);

    // Assert
    Assert.AreEqual(expectedQuotient, actualQuotient);
    }

    [TestMethod]
    public void Test_Divide_ZeroDividend_ReturnQuotient()
    {
    // Assign values
    decimal dividend = 0m;
    decimal divisor = 8.2m;
    decimal expectedQuotient = 0m;

    // Actual Quotient
    decimal actualQuotient = StringLibrary.Divide(dividend, divisor);

    // Assert
    Assert.AreEqual(expectedQuotient, actualQuotient);
    }

    [TestMethod]
    [ExpectedException(typeof(DivideByZeroException))]
    public void Test_Divide_DivideByZero_ReturnQuotient()
    {
    // Assign values
    decimal dividend = 2.5m;
    decimal divisor = 0m;

    // Actual Quotient
    decimal actualQuotient = StringLibrary.Divide(dividend, divisor);

    // Assert
    // This test is expected to throw a Exception
    }
}