namespace CustomList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomList<string> pies = new CustomList<string>();
            CustomList<string> iceCream = new CustomList<string>();

            
            pies.Add("Blueberry pie");
            pies.Add("Apple pie");
            pies.Add("Pumpkin pie");

            iceCream.Add("vanilla");
            iceCream.Add("cherry");

            pies.GetEnumerator();

            

        }
    }
}