using CustomList;
namespace CustomListTest;

[TestClass]
public class AddMethodTests
{
    [TestMethod]
    public void AddMethod_AddTwoItems_SecondItemAtIndexOne()
    {
        //Arrange
        CustomList<string> myList = new CustomList<string>();

        //Act
        myList.Add("Hello");
        Assert.AreEqual(1, myList.Count);
        myList.Add("World");
        Assert.AreEqual(2, myList.Count);
        //Assert
        Assert.AreEqual("World", myList[1]);

    }

    [TestMethod]
    public void AddMethod_AddTwoItems_FirstItemAtIndexZero()
    {
        //Arrange
        CustomList<string> myList = new CustomList<string>();

        //Act
        myList.Add("Hello");

        //Assert
        Assert.AreEqual("Hello", myList[0]);

    }

    [TestMethod]
    public void AddMethod_WhenCountReachesCapacity_DoublingCapacityWhenFull()
    {
        //Arrange
        CustomList<string> myList = new CustomList<string>();

        //Act

        myList.Add("Hello");
        myList.Add("World");
        myList.Add("I'm");
        myList.Add("Andrea");
        myList.Add("Calderon");
        myList.Add("I");
        myList.Add("love");
        myList.Add("cats");
        Assert.AreEqual("cats", myList[7]);

        //Assert
        Assert.AreEqual(8, myList.Capacity);
    }

    [TestMethod]
    public void AddMethod_TransferItemsToNewArray_OneOriginalItemPersistsIntheSameIndex()
    {
        //Arrange
        CustomList<string> myList = new CustomList<string>();

        //Act


        //Assert 

    }

    [TestMethod]
    public void AddMethod_WhenCountReachesCapacity_IndexOneSayingHello()
    {
        //Arrange
        CustomList<string> myList = new CustomList<string>();

        //Act

        myList.Add("Hello");
        myList.Add("World");
        myList.Add("I'm");
        myList.Add("Andrea");
        myList.Add("Calderon");
        myList.Add("I");
        myList.Add("love");
        myList.Add("cats");

        Assert.AreEqual("Hello", myList[0]);

    }
}