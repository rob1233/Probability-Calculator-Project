using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probability_Calculator
{
    public class ProbabilityCalculatorPresenter
    {

        private readonly IProbabilityCalculatorView _view;

        public ProbabilityCalculatorPresenter(IProbabilityCalculatorView view)
        {
            _view = view ?? throw new ArgumentNullException(nameof(view));
            AssignEventHandlers();
        }

        private void AssignEventHandlers()
        {
         
            {
                _view.EitherClickEvent += OnEitherClick;
                _view.CombinedClickEvent += OnCombinedClick;
            }
        }

        private double EitherCalculation(double a, double b) 
        {
            return (a + b - (a * b));
        }

        private double CombinedCalculation(double a, double b)
        {
            return (a * b);
        }

        public void OnEitherClick(object? sender, EventArgs e)
        {
            _view.result = "";
            _view.errorMsg = "";

            if (InputValidator.IsValidDouble(_view.A, out double a) && InputValidator.IsValidDouble(_view.B, out double b))
            {
               string result = EitherCalculation(a, b).ToString();

                _view.result = result;

                string filePath = "calculations.txt";

                if (!System.IO.File.Exists(filePath))
                {
                    System.IO.File.Create(filePath).Close();
                }
          
                string line = $"{a},{b},{result}, Either Operation";
                System.IO.File.AppendAllText(filePath, line + Environment.NewLine);

            }

            else 
            {
                _view.errorMsg = "Please enter values between 0 and 1";
            }
        }


    public void OnCombinedClick(object? sender, EventArgs e)
        {
            _view.result = "";
            _view.errorMsg = "";

            if (InputValidator.IsValidDouble(_view.A, out double a) && InputValidator.IsValidDouble(_view.B, out double b))
            {
                string result = CombinedCalculation(a, b).ToString();

                _view.result = result;


                string filePath = "calculations.txt";

                if (!System.IO.File.Exists(filePath))
                {
                    System.IO.File.Create(filePath).Close();
                }


                string line = $"{a},{b},{result}, Combined Operation";
                System.IO.File.AppendAllText(filePath, line + Environment.NewLine);

            }

            else
            {
                _view.errorMsg = "Please enter values between 0 and 1";
            }

        }


    }
}

