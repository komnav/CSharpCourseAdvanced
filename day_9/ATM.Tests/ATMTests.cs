namespace ATM.Tests
{
    public class ATMTests
    {
        private ATMService _atmService;

        [SetUp]
        public void Setup()
        {
            _atmService = new ATMService();
        }

        [Test]
        public void AtmServiceDepositTest()
        {
            _atmService.Deposit(50, 100);

            var atmCaches = _atmService.GetExistingCash();

            Assert.IsNotNull(atmCaches);
            Assert.That(atmCaches.Count, Is.EqualTo(1));
            Assert.That(atmCaches[50], Is.EqualTo(100));
        }

        [Test]
        public void AtmServiceDepositMultipleCashesTest()
        {
            _atmService.Deposit(50, 100);
            _atmService.Deposit(100, 2);

            var atmCaches = _atmService.GetExistingCash();

            Assert.IsNotNull(atmCaches);
            Assert.That(atmCaches.Count, Is.EqualTo(2));
            Assert.That(atmCaches[50], Is.EqualTo(100));
            Assert.That(atmCaches[100], Is.EqualTo(2));
        }

        [Test]
        public void AtmServiceWithdrawTest()
        {
            _atmService.Deposit(50, 2);
            _atmService.Deposit(100, 2);

            var result = _atmService.Withdraw(150);

            Assert.That(result.Count, Is.EqualTo(2));
            Assert.That(result[0], Is.EqualTo(100));
            Assert.That(result[1], Is.EqualTo(50));

            var existingCash = _atmService.GetExistingCash();
            Assert.That(existingCash[50], Is.EqualTo(1));
            Assert.That(existingCash[100], Is.EqualTo(1));
        }

        [Test]
        public void AtmServiceWithdrawComplexTest()
        {
            _atmService.Deposit(50, 2);//1
            _atmService.Deposit(100, 2);
            _atmService.Deposit(200, 50);//20
            _atmService.Deposit(1000, 1);//1

            var result = _atmService.Withdraw(5050);

            Assert.That(result.Count, Is.EqualTo(22));
            Assert.That(result[0], Is.EqualTo(1000));
            Assert.That(result[1], Is.EqualTo(200));
            Assert.That(result[21], Is.EqualTo(50));

            var existingCash = _atmService.GetExistingCash();
            Assert.That(existingCash[50], Is.EqualTo(1));
            Assert.That(existingCash[100], Is.EqualTo(2));
            Assert.That(existingCash[200], Is.EqualTo(30));
            Assert.That(existingCash[1000], Is.EqualTo(0));
        }

        [Test]
        public void AtmService_ShouldThrowException_WhenAmountIsLessThen50()
        {
            _atmService.Deposit(50, 2);

            var exception = Assert.Throws<InvalidOperationException>(() =>
            {
                _atmService.Withdraw(20);
            });

            Assert.That(exception.Message, Is.EqualTo("Amount should not be less then 50"));
        }

        [Test]
        public void AtmService_ShouldThrowException_WhenATMDoesNotHaveNassesaryCashType()
        {
            _atmService.Deposit(100, 1);

            var exception = Assert.Throws<InvalidOperationException>(() =>
            {
                _atmService.Withdraw(50);
            });

            Assert.That(exception.Message, Is.EqualTo("ATM does not have nassesary cash type"));
        }

        [Test]
        public void AtmService_ShouldThrowException_WhenAmountIsGreaterThenCash()
        {
            _atmService.Deposit(50, 2);
            _atmService.Deposit(100, 2);

            var exception = Assert.Throws<InvalidOperationException>(() =>
            {
                _atmService.Withdraw(1000);
            });

            Assert.That(exception.Message, Is.EqualTo("ATM does not have nassesary cash type"));
            var existingCash = _atmService.GetExistingCash();
            Assert.That(existingCash[50], Is.EqualTo(2));
            Assert.That(existingCash[100], Is.EqualTo(2));
        }
    }
}