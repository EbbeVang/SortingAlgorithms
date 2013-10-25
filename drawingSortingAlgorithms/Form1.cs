using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace drawingSortingAlgorithms
{
    public partial class Form1 : Form
    {

        private int[] integerArray = new int[20];

        public Form1()
        {
            InitializeComponent();

            panelSortingGraphics.Paint += new PaintEventHandler(updateArrayGraphics);

            Sorting.randomizeArray(integerArray, panelSortingGraphics);

        }

        private void updateArrayGraphics(object sender, PaintEventArgs e)
        {
            int height = panelSortingGraphics.Height;
            int width = panelSortingGraphics.Width;
            for (int i = 0; i < integerArray.Length; i++)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.Blue), i*width/integerArray.Length, height-integerArray[i]*height/100, width/integerArray.Length-4, integerArray[i]*height/100);

            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            switch (comboBoxSortingAlgorithm.SelectedIndex)
            {
                case -1:
                    MessageBox.Show("Please select a sorting algorithm");
                    break;
                case 0:
                    labelSortHeader.Text = "SelectionSort";
                    Sorting.SelectionSort(integerArray, panelSortingGraphics);
                    break;
                case 1:
                    labelSortHeader.Text = "Insertion sort";
                    Sorting.InsertionSort(integerArray, panelSortingGraphics);
                    break;
                case 2:
                    labelSortHeader.Text = "Bubble sort";
                    Sorting.bubbleSort(integerArray, panelSortingGraphics);
                    break;
                case 3:
                    labelSortHeader.Text = "Merge sort";
                    Sorting.bubbleSort(integerArray, panelSortingGraphics);
                    break;
                case 4:
                    labelSortHeader.Text = "Quick sort";
                    Sorting.quickSort(integerArray, panelSortingGraphics, labelSortHeader);
                    break;

            }
        }

        private void buttonRandom_Click(object sender, EventArgs e)
        {
            Sorting.randomizeArray(integerArray, panelSortingGraphics);
        }

       
    }
}
