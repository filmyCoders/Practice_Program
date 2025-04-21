public class ArrayProgram
{
    public static void Main(string[] args)
    {
        //1D Array
        int[] a = { 0, 7, 4 };

        int[] b ={ 3,5,3,2,7,5};

        IArrayFuncation arrayFuncation = new ArrayFuncation();
        var max=  arrayFuncation.MaxElement(b);
        var min = arrayFuncation.MinElement(b);

        Console.WriteLine("Max Element is"+max);
        Console.WriteLine("Min Element is" + min);

        var sort = arrayFuncation.SortingAssendingOrder(b);

        Console.WriteLine("Sort Array by Assending");
        foreach( var x in sort ) Console.WriteLine(x);

        var des = arrayFuncation.SortingDecendingOrder(b);

        Console.WriteLine("Sort Array by Dessending");
        foreach (var x in des) Console.WriteLine(x);

        var arraySum = arrayFuncation.SumArray(b);

        Console.WriteLine("Sum of Array "+arraySum);

        var elements=arrayFuncation.FindDuplicateElemnt(b);
        Console.WriteLine("Duplicate Elment in  Array ");

        foreach ( var x in elements ) Console.WriteLine( x);
        //foreach (int i in a)
        //{
        //    Console.WriteLine(i);
        //}

    }

    public interface IArrayFuncation
    {
        int SumArray(int[] a);
        int[]SortingAssendingOrder(int[] a);
        int[]SortingDecendingOrder(int[] a);
        int MaxElement(int[] a);
        int MinElement(int[] a);
          
        int[] FindDuplicateElemnt(int[] a);
    }
    class ArrayFuncation : IArrayFuncation
    {
        public ArrayFuncation()
        {
        }

        public int[] FindDuplicateElemnt(int[] a)
        {
            List<int> duplicateElements= new List<int>();
            for(int i = 0; i < a.Length; i++)
            {
                for(int j=i+1; j < a.Length; j++)
                {
                    if(a[j] == a[i] && !duplicateElements.Contains(a[i])    ) {
                        duplicateElements.Add(a[i]);}

                }
            }
            return duplicateElements.ToArray();

        }

        public int MaxElement(int[] a)
        {

            int max = a[0];
            for(int i = 0; i < a.Length; i++)
            {
                    if(a[i]> max)
                    {
                    max = a[i];
                    }
                
            }

            
            return max;
        }

        public int MinElement(int[] a)
        {
            int min = a[0];
            for(int i=0; i<a.Length; i++)
            {

                //if (a[i] < min)   both are meaning is same
                    if (min > a[i])
                {
                    min = a[i];
                }
            }
            return min;
        }

        public int[] SortingAssendingOrder(int[] a)
        {


            for(int i=0; i < a.Length; i++)
            {
                for(int j=i+1; j<a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        int temp=a[j];
                        a[j]=a[i];
                        a[i]=temp;
                    }
                }

            }
            return a;
        }

        public int[] SortingDecendingOrder(int[] a)
        {
            for(int i = 0; i < a.Length; i++)
            {
                for(int j=i+1;j<a.Length; j++)
                {
                    if(a[i] < a[j])
                    {
                        int temp = a[j];
                        a[j]=a[i];
                        a[i]=temp;
                    }
                }
            }
            return a;
        }

        public int SumArray(int[] a)
        {
            int sum = 0;

            for(int i = 0; i < a.Length; i++)
            {
              sum+= a[i];  
            }
            return sum;
        }
    

    }
}