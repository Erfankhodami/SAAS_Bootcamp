namespace BootcampUnitTest;
using Xunit;
using BootcampClassLibrary;
public class PersonMethodsTest
{
    [Fact]
    public void TestAddressGenerator()
    {
        Person person=new Person("","");
        string result=person.GenrateAdress();
        const string desiredResult = "this is the default address";
        Xunit.Assert.Equal(desiredResult, person.GenrateAdress());
    }
}