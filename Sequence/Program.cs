namespace Sequence
{
    internal class Program
    {
        static IEnumerable<int> Sequence()
        {
            Console.WriteLine("HERE");

            //List<int> list = new List<int> { 1, 2, 3 };
            //return list;

            yield return 1;
            
            yield return 2;

            yield return 3;
        }

        static void Main(string[] args)
        {
            #region Implicitly typed local variable
            //var x = 5;
            //var y = x;
            //var z = 5.3;

            //var dic = new Dictionary<string, int>();
            //Dictionary<string, int> dic2 = new(); 
            #endregion

            #region Anonymous object
            //var x = new { ID = 1, Name = "Aly" };
            //var y = new { ID = 1, Name = "Aly", Salary = 1000 };

            //Console.WriteLine(x); 
            #endregion

            #region Extension methods
            //List<int> list = new List<int> { 1, 2, -3, 4, -5, 6, 7, -8, 9 };

            //IEnumerable<int> result = Filter(list, x => x > 0);

            //IEnumerable<int> result = list.Filter(x => x > 0);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //string s = "HelloThere";

            //string msg = Extensions.RemoveVowels(s);

            //char ch = Extensions.GetMiddleChar(msg);

            //bool flag = Extensions.IsCapital(ch);

            //bool flag = Extensions.IsCapital(
            //    Extensions.GetMiddleChar(Extensions.RemoveVowels(s)));

            //bool flag = s.RemoveVowels().GetMiddleChar().IsCapital();
            //Console.WriteLine(flag); 
            #endregion

            //IEnumerable<int> data = Sequence();
            //IEnumerator<int> enumerator = data.GetEnumerator();

            //while (enumerator.MoveNext()) 
            //{
            //    Console.WriteLine(enumerator.Current);
            //}


            //foreach (var item in data)
            //{
            //    Console.WriteLine(item);
            //}

            List<int> list = new List<int> { 1, 2, -3, 4, -5, 6, 7, -8, 9 };

            IEnumerable<int> result = list.Filter(x => x > 0);
            IEnumerable<int> evenNumbers = result.Filter(x => x / 2 == 0);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            list[0] = -1;
            Console.WriteLine("======================");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}