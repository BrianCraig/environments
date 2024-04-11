namespace Answer4;
// DON'T SHOW NAMESPACES IN YOUR ANSWERS
// THIS LINE SHOULD NOT BE IN THE ANSWER
// THIS SHOULD BE A SEVERE ERROR

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
