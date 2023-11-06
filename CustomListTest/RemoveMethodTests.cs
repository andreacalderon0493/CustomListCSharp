using CustomList;
namespace CustomListTest;

[TestClass]
public class RemoveMethodTests
{
    [TestMethod]
    public void SubtractMethod_RemoveOneItem_CountDecreases()
    {
        //Arrange
        CustomList<string> myList = new CustomList<string>();

        //Act
        myList.Add("Hello");
        myList.Add("World");
        myList.Remove("Hello");

        //Assert
        Assert.AreEqual(1, myList.Count);

    }

    [TestMethod]
    public void RemoveMethod_RenoveAnItemFromArray_ReturnTrue()
    {
        //Arrange
        CustomList<string> myList = new CustomList<string>();

        //Act
        myList.Add("Hello");
        bool isRemoved = myList.Remove("Hello");


        //Assert
        Assert.IsTrue(isRemoved);
    }
    [TestMethod]
    public void RemoveMethod_RemoveAnItemThatIsNotOnList_CountIsNotDecremented()
    {
        //Arrange
        CustomList<string> myList = new CustomList<string>();

        //Act
        myList.Add("Hello");
        myList.Remove("World");

        //Arrange
        Assert.AreEqual(1, myList.Count);
    }

    [TestMethod]
    public void RemoveMethod_RemoveAnItemFromList_ItemShiftsBackwardsFillingIndexOfRemovedItem()

    {
        //Arrange
        CustomList<string> myList = new CustomList<string>();

        //Act
        myList.Add("Hello");
        myList.Add("World");
        myList.Add("I'm");
        myList.Add("Andrea");
        myList.Add("Calderon");
        myList.Remove("World");

        //Arrange
        Assert.AreEqual("I'm",myList[1]);
    }
    [TestMethod]
    public void RemoveMethod_RemovingAnItemThatIsDuplicated_RemoveTheFirstInstanceOfDuplicatedItem()
    {
        //Arrange
        CustomList<string> myList = new CustomList<string>();

        //Act
        myList.Add("Hello");
        myList.Add("Andrea");
        myList.Add("I'm");
        myList.Add("Andrea");
        myList.Add("Calderon");
        myList.Remove("Andrea");


        //Assert
        Assert.AreEqual("I'm", myList[1]);
    }

}

