using NSpec;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringCalculator;

namespace StringCalculatorSpecs
{
    class describe_stringcalculator : nspec
    {
        void given_a_string_of_numbers()
        {
            it["Takes a list of numbers in string format"] = () =>
            {
                StringCalc sCalc = new StringCalc();
                sCalc.Add("1").should_be(1);
            };
        }
    }
}
