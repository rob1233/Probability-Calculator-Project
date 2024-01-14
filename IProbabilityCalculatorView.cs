using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probability_Calculator
{
    public interface IProbabilityCalculatorView
    {

        event EventHandler CombinedClickEvent;

        event EventHandler EitherClickEvent;

        string result { get; set; }

        string A { get; set; }

        string B { get; set; }

        string errorMsg { get; set; }

    }
}
