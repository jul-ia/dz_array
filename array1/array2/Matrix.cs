using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array2
{
    abstract class Matrix
    {
        protected int row, col;
        protected int[,] matrix;


        public abstract void changeSize(int row, int col);
        public abstract void ShowMatrix();
    }
}
