using Moq;
using Probability_Calculator;

namespace TestProbCalculator
{
    [TestClass]
    public class TestClass
    {


        [TestMethod]
        public void OnEitherClick_ValidInput_WritesToFile()
        {

            var viewMock = new Mock<IProbabilityCalculatorView>();
            viewMock.SetupAllProperties();

            var presenter = new ProbabilityCalculatorPresenter(viewMock.Object);
            viewMock.Object.A = "0.5";
            viewMock.Object.B = "0.5";


            presenter.OnEitherClick(null, EventArgs.Empty);


            Assert.IsTrue(viewMock.Object.result.Length > 0);
            Assert.AreEqual(0, viewMock.Object.errorMsg.Length);
        }

        [TestMethod]
        public void OnEitherClick_InvalidInput_SetsErrorMessage()
        {

            var viewMock = new Mock<IProbabilityCalculatorView>();
            viewMock.SetupAllProperties();

            var presenter = new ProbabilityCalculatorPresenter(viewMock.Object);
            viewMock.Object.A = "invalid";
            viewMock.Object.B = "0.5";

            presenter.OnEitherClick(null, EventArgs.Empty);


            Assert.AreEqual("Please enter values between 0 and 1", viewMock.Object.errorMsg);
            Assert.AreEqual(0, viewMock.Object.result.Length);
        }

        [TestMethod]
        public void OnCombinedClick_ValidInput_WritesToFile()
        {

            var viewMock = new Mock<IProbabilityCalculatorView>();
            viewMock.SetupAllProperties();

            var presenter = new ProbabilityCalculatorPresenter(viewMock.Object);
            viewMock.Object.A = "0.5";
            viewMock.Object.B = "0.5";


            presenter.OnCombinedClick(null, EventArgs.Empty);


            Assert.IsTrue(viewMock.Object.result.Length > 0);
            Assert.AreEqual(0, viewMock.Object.errorMsg.Length);
        }

        [TestMethod]
        public void OnCombinedClick_InvalidInput_SetsErrorMessage()
        {

            var viewMock = new Mock<IProbabilityCalculatorView>();
            viewMock.SetupAllProperties();

            var presenter = new ProbabilityCalculatorPresenter(viewMock.Object);
            viewMock.Object.A = "invalid";
            viewMock.Object.B = "0.5";


            presenter.OnCombinedClick(null, EventArgs.Empty);


            Assert.AreEqual("Please enter values between 0 and 1", viewMock.Object.errorMsg);
            Assert.AreEqual(0, viewMock.Object.result.Length);
        }

    }

}
