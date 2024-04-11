namespace Answer1;

using NUnit.Framework;

[TestFixture]
public class MyTestClass
{
  [Test]
  public void AddOnePlusOne_ShouldReturnTwo()
  {
    int num1 = 1;
    int num2 = 1;

    int result = num1 + num2;

    Assert.That(result, Is.EqualTo(2));
  }
}
