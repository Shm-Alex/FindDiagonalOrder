using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace NFindDiagonalOrder
{
    internal class Program
    {
        public static int[] FindDiagonalOrder(int[][] mat)
        {
            int sizeY = mat.Length;
            int sizeX = mat[0].Length;
            int retSize = (sizeX) * (sizeY);
            var ret = new int[retSize];
            
            int x = 0, y = 0;
            int vX = 1, vY = -1;
            for (int i = 0; i < retSize; i++)
            {
                ret[i] = mat[y][x];
                int newX = x + vX;
                int newY = y + vY;
                if ((newX >= 0) && (newY >= 0) && (newX < sizeX) && (newY < sizeY))
                {
                    x = newX; y = newY;
                }
                else 
                {
                    vX = -vX;
                    vY=-vY;


                    if((y==0)&&(x+1<sizeX)) { x++;continue; }
                    if ((x == 0) && (y + 1 < sizeY)) { y++; continue; }
                    if ((y +1==sizeY) && (x + 1 < sizeX)) { x++; continue; }
                    if ((x + 1 == sizeX) && (y + 1 < sizeY)) { y++; continue; }

                }
            }
            return ret;
        }


        static void Main(string[] args)
        {
            
            Console.WriteLine("{"+string.Join(" ,", FindDiagonalOrder( new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } })) +"}");
            Console.WriteLine("{" + string.Join(" ,", FindDiagonalOrder(new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 } })) + "}");
            Console.WriteLine("{" + string.Join(" ,", FindDiagonalOrder(new int[][] { new int[] { 1, 2  }, new int[] { 3, 4 }, new int[] { 5, 6 } })) + "}");
            Console.WriteLine("{" + string.Join(" ,", FindDiagonalOrder(new int[][] { new int[] { 1, 2 }, new int[] { 3, 4 } })) + "}");
            Console.ReadLine();
        }
    }
}
