
public class Program
{
    public static void Main(string[] args)
    {

        //For Loop
        for(int i = 0; i < 50; i++)
        {
            Console.WriteLine(i);
        }

        int a = 1;
        //Nesed For Loop 
        for(int i = 1; i <= 10; i++)
        {
            for(int j = a; j <=a; j++)
            {

                Console.Write(j+" ");

            }
            a++;
            a = a * 10;
            Console.WriteLine();
        }



        //Nested For Loop 
        for (int i = 1; i <= 100; i++)
        {

            if (i % 10 == 0)
            {
                Console.WriteLine(i);

            }
            else
            {
                Console.Write("  ");

                Console.Write(i);
            }
        }

        List<int> list = new List<int>();
        list.Add(1);
        list.Add(2);
            list.Add(3);
        list.Add(4);
        foreach(var i in list)
        {

            Console.Write(i+" ");
        }
        Console.WriteLine();

         
        list.ForEach(x=>Console.WriteLine(x*2));


        Console.WriteLine();


        foreach (var i in list)
        {

            Console.WriteLine(i + " ");
        }
    }

}