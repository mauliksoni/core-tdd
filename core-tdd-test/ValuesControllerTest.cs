using System;
using Xunit;
using core_tdd.Controllers;
using System.Linq;
using Moq;

public class ValuesControllerTest
{
    [Fact]
    public void ValuesController_returnstwovalues_onget()
    {
        //Arrange
        var controller = new ValuesController();

        //Act
        var result = controller.Get();

        //Assert
        Assert.Equal("value1", result.First());
        Assert.Equal("value2", result.Skip(1).First());
    }

    [Fact]
    public void URLService_TestPublicURL()
    {
        //Arrange
        var url_svc_mock =new Mock<IURLService>();
        url_svc_mock.Setup(x => x.getPublicURL()).Returns("https://download.me/1.pdf");

        //Act
        var result = url_svc_mock.Object.getPublicURL();
        //Assert
        Assert.Equal("https://download.me/1.pdf", result);
    }

    public interface IURLService
    {
        string getPublicURL();
    }

}

