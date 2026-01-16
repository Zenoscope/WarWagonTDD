using NUnit.Framework;

namespace StringCalculatorKata.Test {
   public class StringCalculatorTest {

      [Test]
      public void Add_EmptyStringAsParam_ReturnsZero() {
        // ClassicAssert.AreEqual(0, StringCalculator.Add(""));
        Assert.That(StringCalculator.Add(5,2), Is.EqualTo(7));
        }

      }
    }
