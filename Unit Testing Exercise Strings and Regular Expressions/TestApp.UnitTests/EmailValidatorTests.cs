using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailValidatorTests
{
    
    [TestCase("evelin_danailova@softuni.bg")]
    [TestCase("eva.dancheva@abv.bg")]
    [TestCase("eva+133@gmail.com")]
    public void Test_ValidEmails_ReturnsTrue(string email)
    {
        // Arrange

        // Act
        bool result = EmailValidator.IsValidEmail(email);

        // Assert
        Assert.That(result, Is.True);
    }

    
    [TestCase("invalid mail@valid.domaim")]
    [TestCase("valid%mail@in_valid.dmain")]
    [TestCase("invalid/mail@invalid.d")]
    public void Test_InvalidEmails_ReturnsFalse(string email)
    {
        // Arrange

        // Act
        bool result = EmailValidator.IsValidEmail(email);
        
        // Assert
        Assert.That(result, Is.False);
    }
}
