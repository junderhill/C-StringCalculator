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
            StringCalc sCalc = new StringCalc();

            it["Takes a list of numbers in string format"] = () =>
                {
                    sCalc.Add("1").should_be(1);
                };

            it["returns 0 if empty string"] = () =>
                {
                    sCalc.Add("").should_be(0);
                };

            it["returns sum of 2 numbers seperated by commas"] = () =>
                {
                    sCalc.Add("1,1").should_be(2);
                };
            it["returns sum of multiple numbers seperated by commas"] = () =>
                {
                    sCalc.Add("1,2,3,10,1").should_be(17);
                };
            it["returns sum if number seperated by new lines"] = () =>
                {
                    sCalc.Add("1\n2\n3\n").should_be(6);
                };
            it["allows a combination of delimiters"] = () =>
                {
                    sCalc.Add("1\n3,2").should_be(6);
                };
            it["supports customer delimiters"] = () =>
                {
                    sCalc.Add("//;\n1;2;3").should_be(6);
                };
            it["should throw an exception for negative numbers"] = () =>
                {

                };
        }
    }
}
