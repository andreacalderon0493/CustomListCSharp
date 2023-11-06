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
            myList.Add("Calderon");
            myList.Add("I love cats!");
            myList.Remove("Calderon");
            myList.ToString();

            Console.WriteLine($"{myList}");


            CustomList<int> secondList = new CustomList<int>();
            

            secondList.ToString();
            Console.WriteLine($"{secondList}");

        }
    }
}