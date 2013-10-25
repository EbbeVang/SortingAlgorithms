using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace drawingSortingAlgorithms
{
    class Sorting
    {
        private static Random random = new Random();

        public static void randomizeArray(int[] array, Panel panel)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(10, 100);
            }
            panel.Invalidate();
        }

        public static void SelectionSort(int[] array, Panel panel)
        {
            // cheating..... should implement algorithm...
            Array.Sort(array);
            panel.Invalidate();
        }

        public static void InsertionSort(int[] integerArray, Panel panelSortingGraphics)
        {
            MessageBox.Show("Not implemented!");
        }

        public static void bubbleSort(int[] integerArray, Panel panelSortingGraphics)
        {
            MessageBox.Show("Not implemented!");
        }

        public static void mergeSort(int[] intgerArray, Panel panelSortingGraphics)
        {
            MessageBox.Show("Not implemented!");
        }

        public static void quickSort(int[] integerArray, Panel panelSortingGraphics)
        {
            MessageBox.Show("Not implemented!");
        }
    }
}
