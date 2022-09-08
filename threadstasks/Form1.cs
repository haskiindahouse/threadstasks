using System;

namespace threadstasks
{
    public class SortingHelper
    {
        public static List<int> generateValues(int size, int minValue, int maxValue)
        {
            List<int> values = new List<int>();
            Random r = new Random();
            for (int i = 0; i < size; i++)
                values.Add(r.Next(minValue, maxValue));

            return values;
        }
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sortBtn_Click(object sender, EventArgs e)
        {
            int arraySize;
            bool isValid = int.TryParse(arraySizeTextBox.Text, out arraySize); // the out keyword allows the method to essentially "return" a second value
            if (!isValid)
                MessageBox.Show("Input a number");

            int min = Convert.ToInt32(minValue.Value);
            int max = Convert.ToInt32(maxValue.Value);
            var values = SortingHelper.generateValues(arraySize, min, max);
            for (int i = 0; i < values.Count; i++)
                unsortedListBox.Items.Add(values[i]);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}