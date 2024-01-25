using ConsoleApp1;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCreateNewPerson()
        {
            // Arrange
            Person person = new Person();

            // Act
            person.CreateNewPerson("Max", 25);

            // Assert
            Assert.AreEqual(1, person.PersonList.Count);
            Assert.AreEqual("Max", person.PersonList[0].Name);
            Assert.AreEqual(25, person.PersonList[0].Age);
        }

        [TestMethod]
        public void TestIsListEmpty()
        {
            // Arrange
            Person person = new Person();

            // Act
            bool isEmptyBefore = person.IsListEmpty();
            person.CreateNewPerson("Max", 25);
            bool isEmptyAfter = person.IsListEmpty();

            // Assert
            Assert.IsTrue(isEmptyBefore);
            Assert.IsFalse(isEmptyAfter);
        }
    }
}