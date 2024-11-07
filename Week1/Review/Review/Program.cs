namespace Review
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 24, 35, 66, 78, 98, 54, 37 };
            var findEven = arr.Where(n => n % 2 == 0);

            foreach(int n in findEven)
            {
                Console.WriteLine(n*10);
            }

            List<int> list = new List<int>() { 20, 34, 56, 78, 12, 34, 45, 67 };

            var skipped = list.Skip(3);
            var taked = list.FirstOrDefault();
            Console.WriteLine(taked);

            
            foreach(int n in skipped)
            {
                Console.WriteLine("skipped-------------------");
                Console.WriteLine(n);
            }
        }
    }
}
