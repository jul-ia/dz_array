using System;
using System.Threading;

namespace array2
{
    class MyMatrix : Matrix
    {
        public MyMatrix()
        {
            row = col = 3;
            matrix = new int[row, col];
            RandomFill();
        }

        public MyMatrix(int a, int b)
        {
            row = a;
            col = b;
            matrix = new int[row, col];
            RandomFill();
        }

        private void RandomFill()
        {
            Thread.Sleep(100);
            Random rand = new Random();
            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                    matrix[i, j] = rand.Next(0, 20);
        }
        public int Row
        {
            get { return row; }
        }
        public int Col
        {
            get { return col; }
        }

        public override void changeSize(int row, int col)
        {
            this.row = row;
            this.col = col;
            matrix = new int[row, col];
            RandomFill();
        }

        public override void ShowMatrix()
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                    Console.Write("{0}  ", matrix[i, j]);
                Console.WriteLine();
            }
        }
    }
}
