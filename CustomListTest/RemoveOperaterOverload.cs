
using CustomList;
namespace CustomListTest
{
	[TestClass]
	public class RemoveOperaterOverload
	{
		[TestMethod]
		public void  RemoveOperaterOverload_CreateTwoLists_FirstListLongerThanSecondList()
		{
            //Arrange
            CustomList<string> pies = new CustomList<string>();
            CustomList<string> iceCream = new CustomList<string>();

            //Act
            pies.Add("Blueberry pie");
            pies.Add("Apple pie");
            pies.Add("Pumpkin pie");

            iceCream.Add("vanilla");
            iceCream.Add("cherry");

            var result = pies.Count > iceCream.Count;

            //Assert
            Assert.AreEqual(true, result);
        }
        [TestMethod]
		public void RemoveOperaterOverload_CreateTwoLists_SecondListLongerThanFirstList()
        {
            //Arrange
            CustomList<string> pies = new CustomList<string>();
            CustomList<string> iceCream = new CustomList<string>();

            //Act
            pies.Add("Blueberry pie");

            iceCream.Add("vanilla");
            iceCream.Add("cherry");

            var result = pies.Count > iceCream.Count;

            //Assert
            Assert.AreEqual(true, result);
        }

    }
}

