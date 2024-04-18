namespace CollectionsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var intList = new List<int>();
            var linkedList = new LinkedList<string>();  

            // List

            intList.AddRange(new[] {1, 2, 3});
            intList.Add(4);
            intList.Add(10);
            intList.Insert(0, 5);
            intList.Remove(10);
            intList.RemoveAt(0);

            intList.Sort();
            intList.Reverse();

            foreach (int item in intList) 
            {
                Console.WriteLine(item);
            }

            //Linked List
            var item = linkedList.AddFirst("Coding");
            var item2 = linkedList.AddAfter(item,"Factory");
            var item3 = linkedList.AddLast("AUEB");

            linkedList.First!.Next!.Next!.Value = "Athens Uni Of Econ and Bus";

            foreach (var item in collection)
            {

            }
        }
    }
}
