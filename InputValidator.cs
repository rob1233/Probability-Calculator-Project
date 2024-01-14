using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probability_Calculator
{
 public static class InputValidator
{
    public static bool IsValidDouble(string input, out double result)
    {

        if (double.TryParse(input, out result))
        {

            if (result >= -1 && result <= 1)
            {
                return true;
            }
        }

        return false;
    }
}
}
