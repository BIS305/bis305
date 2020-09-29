// Purpose: Array Demo
// Author: Mark McFadden
// Date: Today

using System;

namespace vbArrays
{
    public partial class Form1
    {
        /// <summary>
        /// Initialize the form  
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            _btnStart.Name = "btnStart";
            _btnObjectArray.Name = "btnObjectArray";
            _mnuClear.Name = "mnuClear";
            _mnuExit.Name = "mnuExit";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Process();
        }

        /// <summary>
        /// 
        /// </summary>
        public void Process()
        {
            var numbers = GetNumbers();
            ShowNumbers(numbers);
            var words = GetWords();
            ShowWords(words);
            lstOutput.Items.Add("numbers array size is: " + numbers.Length);
            ReDimNumberArray(ref numbers, 6);
            lstOutput.Items.Add("After ReDim numbers array size is: " + numbers.Length);

            lstOutput.Items.Add(""); // Add a new line
            lstOutput.Items.Add("int Array");
            var intArray = new int[] { 2, 7, 10, 9, 4 };
            foreach (var intItem in intArray)
            {
                lstOutput.Items.Add(intItem);
            }

            lstOutput.Items.Add(""); // Add a new line
            lstOutput.Items.Add("Sort int Array");
            Array.Sort(intArray);
            foreach (var intItem in intArray)
            {
                lstOutput.Items.Add(intItem);
            }
                
        }
        // return an array
        private int[] GetNumbers()
        {
            var numbers = new[] { 10, 20, 30 }; // Inferred as integer
            return numbers;
        }

        private string[] GetWords()
        {
            var words = new[] { "you", "me", "them" };
            Array.Resize(ref words, 4);
            words[3] = "Us";
            return words;
        }
        // pass an array into a procedure as an input parameter
        private void ShowNumbers(int[] numbers)
        {
            for (int index = 0, loopTo = numbers.GetUpperBound(0); index <= loopTo; index++)
            {
                lstOutput.Items.Add(numbers[index] + " ");
            }
            lstOutput.Items.Add(""); // Add a new line
        }

        private void ShowWords(string[] words)
        {
            for (int index = 0, loopTo = words.Length - 1; index <= loopTo; index++)
            {
                lstOutput.Items.Add(words[index].ToString());
            }
            lstOutput.Items.Add(""); // Add a new line
        }

        private void ReDimNumberArray(ref int[] numbers, int size)
        {
            Array.Resize(ref numbers, size + 1);
        }

        private void btnObjectArray_Click(object sender, EventArgs e)
        {
            var employeeArr = new object[6];
            employeeArr[0] = "Alex Hankin";
            employeeArr[1] = 250.45m;
            employeeArr[2] = 48;
            employeeArr[3] = "James Dean";
            employeeArr[4] = 334.24m;
            employeeArr[5] = 22;
            foreach (var employeeData in employeeArr)
                lstOutput.Items.Add(employeeData.ToString() + " is a " + employeeData.GetType().ToString());
        }

        private void mnuClear_Click(object sender, EventArgs e)
        {
            lstOutput.Items.Clear();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}