using LibraryLogic;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLogicTests
{
    public class ClientServiceTests
    {
        [Fact]
        public void SuccesfullyLoginTest()
        {
            //Arrange
            TestClientServiceUI testClientServiceUi = new TestClientServiceUI();
            Library lib = new Library(new List<Book>());
            lib.AddClient(new Client("Иван", "Иванов"));
            ClientService sut = new ClientService(testClientServiceUi, lib);

            //Act
            sut.EnterService();

            //Assert
            Assert.True(testClientServiceUi.IsInformationShown);
            Assert.Equal("Иван", testClientServiceUi.CurrentClient.Name);
            Assert.Equal("Иванов", testClientServiceUi.CurrentClient.SurName);

        }

        [Fact]
        public void SuccesfullyLoginMoqTest()
        {
            //Arrange
            Mock<IClientServiceUI> uiMock = new Mock<IClientServiceUI>();
            uiMock.SetupGet(x => x.Name).Returns("Иван");
            uiMock.SetupGet(x => x.Surname).Returns("Иванов");
            uiMock.Setup(x => x.GetCommand()).Returns(1);

            Mock<Library> libMock = new Mock<Library>(new List<Book>());
            libMock.SetupGet(x => x.Clients).Returns(new List<Client>() { new Client("Иван", "Иванов") });
            Library lib = libMock.Object;
            //Library lib = new Library(new List<Book>());
            //lib.AddClient(new Client("Иван", "Иванов"));

            ClientService sut = new ClientService(uiMock.Object,lib);

            //Act
            sut.EnterService();

            //Assert
            uiMock.Verify(x => x.ShowInterfaceInformation(), Times.Once);
            uiMock.Verify(x => x.ShowCurrentClient(It.Is<Client>(x => x.Name == "Иван" && x.SurName == "Иванов")), Times.Once);
        }
    }
}
