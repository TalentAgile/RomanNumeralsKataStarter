using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NFluent;
using NUnit.Framework;

namespace RomanNumerals.Tests
{
    public class RomanConverterShould
    {

        [Test]
        public void Return_I_When_Arabic_Is_1()
        {
            var romanConverter = new RomanConverter();
            String romanSymbol = romanConverter.ArabicToRoman(1);
            Check.That(romanSymbol).IsEqualTo("I");
        }
    }

}
