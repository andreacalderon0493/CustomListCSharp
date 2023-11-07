using CustomList;
namespace CustomListTest
{
	[TestClass]
	public class PlusOpertorOverload
	{
		[TestMethod]
		public void PlusOpertorOverload_CreateTwoLists_FirstListLongerThanSecondList()
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
        public void PlusOpertorOverload_CreateTwoLists_SecondListLongerThanFirstList()
        {
            //Arrange
            CustomList<string> pies = new CustomList<string>();
            CustomList<string> iceCream = new CustomList<string>();

            //Act
            pies.Add("Blueberry pie");
            pies.Add("Apple pie");
            

            iceCream.Add("vanilla");
            iceCream.Add("cherry");
            iceCream.Add("chocolate");

            var result = pies.Count < iceCream.Count;

            //Assert
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void PlusOpertorOverload_CreateTwoLists_OneListIsEmptyResultUnchanged()
        {
            //Arrange
            CustomList<string> pies = new CustomList<string>();
            CustomList<string> iceCream = new CustomList<string>();

            //Act
            
            iceCream.Add("vanilla");
            iceCream.Add("cherry");
            iceCream.Add("chocolate");


            //Assert
            Assert.AreEqual(3, iceCream.Count);
        }
    }
}

