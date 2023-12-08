using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.LyaginVA.Sprint6.Task7.V15.Lib
{
    public class DataService : ISprint6Task7V15
    {
        public int[,] GetMatrix(string path)
        {
            string file = File.ReadAllText(path);
            file = file.Replace('\n', '\r');
            string[] lines = file.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;

            int[,] array = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line_mas = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = Convert.ToInt32(line_mas[j]);
                }
            }

            int rows_1 = array.GetUpperBound(0) + 1;
            int columns_1 = array.GetUpperBound(1) + 1;

            for (int r = 0; r < rows_1; r++)
            {
                for (int c = 7; c <= 7; c++)
                {
                    if ((array[r, c] < 10) && (array[r, c] % 3 == 0)&&(array[r, c] !=0))
                    {
                        array[r, c] = 3;
                    }
                }
            }
            return array;

        }
    }
}
