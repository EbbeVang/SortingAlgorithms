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
        private static Label headerRef;
        private static int intRef = 1;
        private static Timer myTimer;

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

        public static void quickSort(int[] integerArray, Panel panelSortingGraphics, Label header)
        {
            // i need a reference to the label i want to update (you ca just use the panel)
            headerRef = header;

            //create a timer
            myTimer = new Timer();

            //set timer event
            myTimer.Tick += new EventHandler(TimerEventProcessor);

            // Sets the timer interval to 5 seconds.
            myTimer.Interval = 500;
            
            // start the timer
            myTimer.Start();

            
        }

        // the method that is executed every half second
        private static void TimerEventProcessor(object sender, EventArgs e)
        {
            intRef++;
            headerRef.Text = intRef.ToString();
            myTimer.Enabled = true;
   
        }
    }
}
