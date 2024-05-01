using System;
using PracticeFinal;
using Microsoft;
using static PracticeFinal.Customer;

namespace CustomerTests;


[TestClass]
public class CustomerTests
{
    [TestMethod]
    public void Customer_Constructor_ValidValues_Success()
    {
        // Arrange
        int customerId = 1;
        string customerName = "John Doe";
        double balance = 1000.0;

        // Act
        var customer = new Customer(customerId, customerName, balance);

        // Assert
        Assert.AreEqual(customerId, customer.CustomerId);
        Assert.AreEqual(customerName, customer.CustomerName);
        Assert.AreEqual(balance, customer.Balance);
    }

    [TestMethod]
    [ExpectedException(typeof(InvalidPropertyValueException))]
    public void Customer_Constructor_InvalidCustomerId_Exception()
    {
        // Arrange
        int invalidCustomerId = -1;
        string customerName = "Alice";
        double balance = 500.0;

        // Act
        var customer = new Customer(invalidCustomerId, customerName, balance);
    }
    [TestMethod]
    [ExpectedException(typeof(InvalidPropertyValueException))]
    public void Customer_Constructor_InvalidCustomerName_Exception()
    {
        // Arrange
        int invalidCustomerId = -1;
        string customerName = null;
        double balance = 500.0;

        // Act
        var customer = new Customer(invalidCustomerId, customerName, balance);
    }
    // Add similar tests for CustomerName and Balance properties

    [TestMethod]
    public void Customer_Display_ValidData_Success()
    {
        // Arrange
        var customer = new Customer(2, "Jane Smith", 1500.0);

        // Act (redirect console output for testing)
        using (StringWriter sw = new StringWriter())
        {
            Console.SetOut(sw);
            customer.Display();
            string expectedOutput = "2, Jane Smith, 1500.0" + Environment.NewLine;
            Assert.AreEqual(expectedOutput, sw.ToString());
        }
    }
    [TestMethod]
    [ExpectedException(typeof(InvalidPropertyValueException))]
    public void Customer_Constructor_EmptyOrNullCustomerName_Exception()
    {
        // Arrange
        int customerId = 2;
        string emptyCustomerName = ""; // Empty string
        double balance = 1500.0;

        // Act
        var customer = new Customer(customerId, emptyCustomerName, balance);
    }
    [TestMethod]
    [ExpectedException(typeof(InvalidPropertyValueException))]
    public void Customer_Constructor_NegativeBalance_Exception()
    {
        // Arrange
        int customerId = 1;
        string customerName = "John Doe";
        double negativeBalance = -100.0;

        // Act
        var customer = new Customer(customerId, customerName, negativeBalance);
    }
}
