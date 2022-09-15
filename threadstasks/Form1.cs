using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Security.Cryptography;
using System.Threading;

namespace threadstasks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sortBtn_Click(object sender, EventArgs e)
        {
            bool isParallel = parallelyRdnBtn.Checked;
            
            var bubbleItems = SortingHelper.values(bubbleSort);
            var shellItems = SortingHelper.values(shellSort);
            var quickItems = SortingHelper.values(quickSort);
            var ret = SortingHelper.sortAll(bubbleItems, shellItems, quickItems, isParallel);
            displayData(ret[(int)SorterType.BubbleSorter], SorterType.BubbleSorter);
            displayData(ret[(int)SorterType.ShellSorter], SorterType.ShellSorter);
            displayData(ret[(int)SorterType.QuickSorter], SorterType.QuickSorter);
        }

        private void displayData(Dictionary<string, dynamic> data, SorterType type)
        {
            switch(type)
            {
            case SorterType.BubbleSorter:
            {
                displayBubbleSortData(data);
                break;
            }
            case SorterType.ShellSorter:
            {
                displayShellSortData(data);
                break;
            }
            case SorterType.QuickSorter:
            {
                displayQuickSortData(data);
                break;
            }
            }
        }
        
        private void displayBubbleSortData(Dictionary<string, dynamic> data)
        {
            var values = data["values"];
            var compareCount = data["compare"];
            var swapCount = data["swap"];
            var time = data["time"];
            bubbleCompare.Text = Convert.ToString(compareCount);
            bubbleSwap.Text = Convert.ToString(swapCount);
            bubbleTime.Text = Convert.ToString(time);
            bubbleSort.Items.Clear();
            foreach (int el in values)
                bubbleSort.Items.Add(el);
        }

        private void displayShellSortData(Dictionary<string, dynamic> data)
        {
            var values = data["values"];
            var compareCount = data["compare"];
            var swapCount = data["swap"];
            var time = data["time"];
            shellCompare.Text = Convert.ToString(compareCount);
            shellSwap.Text = Convert.ToString(swapCount);
            shellTime.Text = Convert.ToString(time);
            shellSort.Items.Clear();
            foreach (int el in values)
                shellSort.Items.Add(el);
        }

        private void displayQuickSortData(Dictionary<string, dynamic> data)
        {
            var values = data["values"];
            var compareCount = data["compare"];
            var swapCount = data["swap"];
            var time = data["time"];
            quickCompare.Text = Convert.ToString(compareCount);
            quickSwap.Text = Convert.ToString(swapCount);
            quickTime.Text = Convert.ToString(time);
            quickSort.Items.Clear();
            foreach (int el in values)
                quickSort.Items.Add(el);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void generate_Click(object sender, EventArgs e)
        {
            int arraySize;
            bool isValid = int.TryParse(arraySizeTextBox.Text, out arraySize); // the out keyword allows the method to essentially "return" a second value
            if (!isValid)
                MessageBox.Show("Input a number");

            bubbleSort.Items.Clear();
            shellSort.Items.Clear();
            quickSort.Items.Clear();
            int min = Convert.ToInt32(minValue.Value);
            int max = Convert.ToInt32(maxValue.Value);
            var values = SortingHelper.generateValues(arraySize, min, max);
            for (int i = 0; i < values.Count; i++)
                bubbleSort.Items.Add(values[i]);

            values = SortingHelper.generateValues(arraySize, min, max);
            for (int i = 0; i < values.Count; i++)
                shellSort.Items.Add(values[i]);

            values = SortingHelper.generateValues(arraySize, min, max);
            for (int i = 0; i < values.Count; i++)
                quickSort.Items.Add(values[i]);
        }
    }

    enum SorterType
    {
        BubbleSorter = 0,
        ShellSorter = 1,
        QuickSorter = 2,
    }

    class SortFabric
    {
        public static Sorter? createSorter(SorterType type)
        {
            switch (type)
            {
                case SorterType.BubbleSorter:
                    return new BubbleSorter();
                case SorterType.ShellSorter:
                    return new ShellSorter();
                case SorterType.QuickSorter:
                    return new QuickSorter();
                default:
                    return null;
            }
        }
    }

    abstract class Sorter
    {
        public abstract Dictionary<string, dynamic> sort(List<int> values);
    }

    class ShellSorter : Sorter
    {
        public override Dictionary<string, dynamic> sort(List<int> values)
        {
            Dictionary<string, dynamic> res = new Dictionary<string, dynamic>();
            res["compare"] = 0;
            res["swap"] = 0;
            int size = values.Count;
            for (int interval = size / 2; interval > 0; interval /= 2)
            {
                for (int i = interval; i < size; i++)
                {
                    var currentKey = values[i];
                    var k = i;
                    var localCompareCounter = i;
                    while (k >= interval && values[k - interval] > currentKey)
                    {
                        res["swap"] += 1;
                        values[k] = values[k - interval];
                        k -= interval;
                    }

                    localCompareCounter -= k;
                    res["compare"] += localCompareCounter;

                    values[k] = currentKey;
                }
            }
            res["values"] = values;

            return res;
        }
    }

    class BubbleSorter : Sorter
    {
        public override Dictionary<string, dynamic> sort(List<int> values)
        {
            Dictionary<string, dynamic> res = new Dictionary<string, dynamic>();
            int temp = 0;
            res["compare"] = 0;
            res["swap"] = 0;
            for (int write = 0; write < values.Count; write++)
            {
                for (int sort = 0; sort < values.Count - 1; sort++)
                {
                    res["compare"] += 1;
                    if (values[sort] > values[sort + 1])
                    {
                        temp = values[sort + 1];
                        values[sort + 1] = values[sort];
                        values[sort] = temp;
                        res["swap"] += 1;
                    }
                }
            }

            res["values"] = values;
            return res;
        }
    }

    class QuickSorter : Sorter
    {
        public override Dictionary<string, dynamic> sort(List<int> values)
        {
            Dictionary<string, dynamic> res = new Dictionary<string, dynamic>();
            res["compare"] = 0;
            res["swap"] = 0;
            realisation(values, 0, values.Count - 1, res);
            return res;
        }
        private List<int> realisation(List<int> values, int leftIndex, int rightIndex, Dictionary<string, dynamic> res)
        {
            var i = leftIndex;
            var j = rightIndex;
            var pivot = values[leftIndex];
            int c1;
            int c2;
            while (i <= j)
            {
                c1 = i; 
                while (values[i] < pivot)
                {
                    i++;
                }

                c1 = i - c1;
                c2 = j;
                while (values[j] > pivot)
                {
                    j--;
                }

                c2 = j - c2;

                if (i <= j)
                {
                    res["swap"] += 1;
                    int temp = values[i];
                    values[i] = values[j];
                    values[j] = temp;
                    i++;
                    j--;
                }
            }

            res["compare"] += i + j;
            if (leftIndex < j)
                realisation(values, leftIndex, j, res);

            if (i < rightIndex)
                realisation(values, i, rightIndex, res);

            res["values"] = values;
            return values;
        }
    }
    public class SortingHelper
    {

        public static List<int> values(ListBox box)
        {
            List<int> values = new List<int>();
            foreach (var item in box.Items)
                values.Add(Convert.ToInt32(item));

            return values;
        }

        public static List<int> generateValues(int size, int minValue, int maxValue)
        {
            List<int> values = new List<int>();
            Random r = new Random();
            for (int i = 0; i < size; i++)
                values.Add(r.Next(minValue, maxValue));

            return values;
        }

        public static List<dynamic> sortAll(List<int> bubble, List<int> shell, List<int> quick, bool isParallely)
        {
            Dictionary<string, dynamic> bubbleData = new Dictionary<string, dynamic>();
            Dictionary<string, dynamic> shellData = new Dictionary<string, dynamic>();
            Dictionary<string, dynamic> quickData = new Dictionary<string, dynamic>();
            if (isParallely)
            {
                Thread bubbleThread = new Thread(() => { bubbleData = sortValues(Tuple.Create(bubble, SorterType.BubbleSorter)); });
                Thread shellThread = new Thread(() => { shellData = sortValues(Tuple.Create(shell, SorterType.ShellSorter)); });
                Thread quickThread = new Thread(() => { quickData = sortValues(Tuple.Create(quick, SorterType.QuickSorter)); }) ;
                bubbleThread.Start();
                if (bubbleThread.ThreadState == System.Threading.ThreadState.Stopped)
                {
                    MessageBox.Show(
                    "Сортировка пузырьком завершилась",
                    "Уведомление",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                }
                shellThread.Start();
                if (shellThread.ThreadState == System.Threading.ThreadState.Stopped)
                {
                    MessageBox.Show(
                    "Сортировка shell завершилась",
                    "Уведомление",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                }
                quickThread.Start();
                if (quickThread.ThreadState == System.Threading.ThreadState.Stopped)
                {
                    MessageBox.Show(
                    "Быстрая сортировка завершилась",
                    "Уведомление",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                }
            }
            else
            {
                bubbleData = sortValues(Tuple.Create(bubble, SorterType.BubbleSorter));
                shellData = sortValues(Tuple.Create(shell, SorterType.ShellSorter));
                quickData = sortValues(Tuple.Create(quick, SorterType.QuickSorter));
            }

            var retList = new List<dynamic>();
            retList.Add(bubbleData);
            retList.Add(shellData);
            retList.Add(quickData);

            return retList;
        }

        private static Dictionary<string, dynamic> sortValues(Tuple<List<int>, SorterType> data)
        {
            var type = data.Item2;
            var values = data.Item1;
            var sorter = SortFabric.createSorter(type);
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            var ret = sorter.sort(values);
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            ret["time"] = ts;
            return ret;
        }

        private static Dictionary<string, dynamic> sortParallely(List<int> values)
        {
            Dictionary<string, dynamic> res = new Dictionary<string, dynamic>();
            res["compare"] = 0;
            res["swap"] = 0;
            res["values"] = values;
            return res;
        }

        private static Dictionary<string, dynamic> sortSuccessively(List<int> values)
        {
            Dictionary<string, dynamic> res = new Dictionary<string, dynamic>();
            res["compare"] = 0;
            res["swap"] = 0;
            res["values"] = bubbleSort(values);
            return res;
        }
        private static List<int> bubbleSort(List<int> values)
        {
            int temp = 0;
            for (int write = 0; write < values.Count; write++)
            {
                for (int sort = 0; sort < values.Count - 1; sort++)
                {
                    if (values[sort] > values[sort + 1])
                    {
                        temp = values[sort + 1];
                        values[sort + 1] = values[sort];
                        values[sort] = temp;
                    }
                }
            }

            return values;
        }
    }
}