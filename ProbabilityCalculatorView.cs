using System.Windows.Forms;

namespace Probability_Calculator
{
    public partial class ProbabilityCalculatorView : Form, IProbabilityCalculatorView
    {

        public event EventHandler? CombinedClickEvent;

        public event EventHandler? EitherClickEvent;
        public ProbabilityCalculatorView()
        {


            InitializeComponent();

            btnCombined.Click += (sender, e) => CombinedClickEvent?.Invoke(this, EventArgs.Empty);

            btnEither.Click += (sender, e) => EitherClickEvent?.Invoke(this, EventArgs.Empty);


            ProbabilityCalculatorPresenter presenter = new ProbabilityCalculatorPresenter(this);


        }

        public string A
        {
            get { return txtA.Text; }
            set { txtA.Text = value; }
        }

        public string B
        {
            get { return txtB.Text; }
            set { txtB.Text = value; }
        }

        public string result
        {
            get { return txtResult.Text; }
            set { txtResult.Text = value; }
        }

        public string errorMsg
        {
            get { return lblError.Text; }
            set { lblError.Text = value; }
        }


    }
}