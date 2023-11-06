namespace CustomList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomList<string> myList = new CustomList<string>();
            myList.Add("HELLO");
            Console.WriteLine($"{myList[0]}");
            myList.Add("World");
            Console.WriteLine($"{myList[1]}");
            myList.Add("I'm");
            myList.Add("Andrea");
            Console.WriteLine($"{myList[2]},{myList[3]}");
            myList.Add("Calderon");
        }
    }
}