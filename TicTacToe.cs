using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class TicTacToe
    {
        public void CreatingBoard()
        {
            char[] array = new char[10];
            int i;
            for (i = 1; i == array.Length; i++)
            {
                array[i] = ' ';
            }
            Console.WriteLine("Array is", +array[i]);
        }
    }
}
