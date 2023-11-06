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
            myList.Add("I'm");
            myList.Add("Andrea");
            myList.Add("Calderon");

			//Assert
			
        }
	}
}

