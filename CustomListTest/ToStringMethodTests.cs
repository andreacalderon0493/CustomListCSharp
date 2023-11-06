using CustomList;
namespace CustomListTest
{
	[TestClass]
	public class ToStringMethodTests
	{
		[TestMethod]
		public void StringMethod_ListOfStrings_ReturnsStrings()
		{
			//Arrange
			CustomList<string> myList = new CustomList<string>();

            //Act
            myList.Add("Hello");
            myList.Add("World");

            //Assert
            var result = myList.ToString();

            Assert.AreEqual("Hello, World",result);
        }
        [TestMethod]
        public void StringMethod_ListOfInt_ReturnsInt()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();

            //Act
            myList.Add(10);
            myList.Add(20);
            myList.Add(30);
           

            var result = myList.ToString();

            //Assert

            Assert.AreEqual(10, 20, 30,result);
        }
        [TestMethod]
        public void StringMethod_EmptyList_ReturnsEmptyString()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();

            //Act

            var result = myList.ToString();
            //Assert
            
            Assert.AreEqual( "", result);
            
        }

    }
    

}

