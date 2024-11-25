using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests;

[TestClass]
public class Services_UserTests
{
    [TestMethod]
    public async Task GetCurrentUser()
    {
        var user = await lib.shared.google.User.GetCurrentUser();
        
        Assert.IsTrue(user != null);
    }
}