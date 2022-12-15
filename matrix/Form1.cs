using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;

namespace matrix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int [,] firstM;
        int [,] secondM;
        private void generateBtn_Click(object sender, EventArgs e)
        {
            int size = Convert.ToInt32(matrixSize.Text);
            firstM = GeneratorHelper.generate(size);
            printMatrix(matrixBox, firstM);
            secondM = GeneratorHelper.generate(size);
            printMatrix(matrix2Box, secondM);
        }

        private void printMatrix(RichTextBox box, int[,] matrix)
        {
            box.Text = "";
            int size = matrix.GetLength(0);
            for (int row = 0; row < size; ++row)
            {
                for (int col = 0; col < size; ++col)
                {
                    box.Text += matrix[row, col] + " ";
                }

                box.Text += "\n";
            }
        }

        private void sortBtn_Click(object sender, EventArgs e)
        {
            if (firstM == null || secondM == null)
                return;

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            var res = SortMatrix.multiplyMatrix(firstM, secondM);
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            timeLbl.Text = ts.ToString();
            printMatrix(resBox, res);
        }
    }

    public class SortMatrix
    {
        public static int[,] multiplyMatrix(int[,] A, int[,] B)
        {
            Mutex mutex = new Mutex();

            int size = A.GetLength(0);
            var resultMatrix = new int[size, size];
            List<Thread> threads = new List<Thread>();

            int temp;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    temp = 0;
                    for (int k = 0; k < size; k++)
                    {
                        Thread thread = new Thread(() => {
                            mutex.WaitOne();
                            temp += A[i, k] * B[k, j]; 
                            mutex.ReleaseMutex();
                        });
                        thread.Start();
                        threads.Add(thread);

                    }
                    resultMatrix[i, j] = temp;
                }
            }

            foreach (Thread t in threads)
                t.Join();

            return resultMatrix;
        }
    }

    public class GeneratorHelper
    {
        public static int[,] generate(int size)
        {
            var list = new int[size, size];
            Random r = new Random();
            Thread.Sleep(10);
            for (int row = 0; row < size; ++row)
            {
                var rowList = new List<int>();
                for (int col = 0; col < size; ++col)
                {
                    list[row, col] = r.Next(0, 10);
                }
            }

            return list;
        }
    }
}
