
public class MatrixPrograms
{
    public static void Main(string[] args)
    {

        int row, col;
        Console.WriteLine("Enter Row and Colom Size");

        row = Convert.ToInt32(Console.ReadLine());
        col = Convert.ToInt32(Console.ReadLine());
        Matrix matrix = new Matrix(row, col);
       var mat1= matrix.GetData();
        var mat2 = matrix.GetData();

        Console.WriteLine("First Matrix ");
        matrix.Print(mat1);
        Console.WriteLine("Second Matrix ");

        matrix.Print(mat2);

       var matAdd= matrix.MatrixAdditon(mat1, mat2);
        Console.WriteLine("Addtion of  Matrix ");

        matrix.Print(matAdd);
    }
    class Matrix
    {

        public int row, col;
        public Matrix(int row,int colomn)
        {
            this.row = row;
            this.col = colomn;
        }

        public int [,]  GetData()
        {
            int[,] mat = new int[row,col] ;

            for(int i = 0; i < row; i++)
            {
                Console.WriteLine($"Enter Yout Matrix  ( {row } X {col})  ", i + 1);
                for(int j = 0; j < col; j++)
                {
                    Console.Write($"Enter element at position ({i + 1}, {j + 1}): ");


                    mat[i,j]=Convert.ToInt32(Console.ReadLine());
                }
            }
            return mat;
        }


        public int[,] MatrixAdditon(int[,] mat1, int[,] mat2)
        {


            int[,] matAdd = new int[row, col];

            for (int i = 0; i < row; i++)
            {

                for (int j = 0; j < col; j++)
                {

                    matAdd[i,j] = mat1[i,j] + mat2[i,j];

                }
            }
            return matAdd;
        }

        public int[,] MatrixSubstraction(int[,] mat1, int[,] mat2)
        {


            int[,] matAdd = new int[row, col];

            for (int i = 0; i < row; i++)
            {

                for (int j = 0; j < col; j++)
                {

                    matAdd[i, j] = mat1[i, j] - mat2[i, j];

                }
            }
            return matAdd;
        }


        public void Print(int[,] matget )
        {
            int[,] mat;

            mat = matget;

            for(int i=0; i < row; i++)
            {
                for(int j=0; j < col; j++)
                {
                    Console.Write(mat[i,j]+"\t");
                }

                Console.WriteLine();

            }


        }
    }
}
