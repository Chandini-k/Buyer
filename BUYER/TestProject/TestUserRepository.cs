using Moq;
using NUnit.Framework;
using UserService.Models;
using UserService.Repositories;

namespace TestProject
{

    public class TestUserRepository
    {
        IUserRepository userRepository;
        [SetUp]
        public void SetUp()
        {
            userRepository = new UserRepository(new BuyerContext());
        }
        /// <summary>
        /// Testing register buyer
        /// </summary>
        [Test]
        [TestCase()]
        [Description("Test Register()")]
        public void TestRegister(int bid,string username,string password,string email,string mobileno)
        {
            var Bid = 4526;
            var Username = "Bhagya";
            var Password = "chanduk@";
            var Email = "vips@gmail.com";
            var Mobileno = "9536783245";
            var Datetime = System.DateTime.Now;
            var buyer = new Buyer { Bid = Bid, Username = Username,Password=Password,Email=Email,Mobileno=Mobileno,Datetime=Datetime };
            var mock = new Mock<IUserRepository>();
            mock.Setup(x => x.BuyerRegister(buyer));
            var result = userRepository.ValidateBuyer(Username, Password);
            Assert.NotNull(result);
        }
        [Test]
        [Description("Test BuyerLogin()")]
        public void TestBuyerLogin()
        {
            var result = userRepository.ValidateBuyer("chandus", "abcdefg@");
            Assert.NotNull(result);
        }
    }
}
