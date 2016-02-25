using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackGroundWork_WindowsForms
{
    public partial class Form1 : Form
    {
        private BackgroundWorker worker;

        public Form1()
        {
            InitializeComponent();

            worker = new BackgroundWorker();
            /*Triggers when RunWorkerAsync is invoked. This is where you call your long-running method.*/
            worker.DoWork += worker_DoWork;
            /*Triggers when the background operation is done. It can be done either because the operation completed 
            successfully, as a response to a cancellation request, or because of an unhandled exception.*/
            worker.RunWorkerCompleted += worker_RunWorkerCompleted;
        }
    
        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = DoIntensiveCalculations();
        }

        /
        void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblResult.Text = e.Result.ToString();
        }

        static double ReadDataFromIO()
        {
            // We are simulating an I/O by putting the current thread to sleep.
            Thread.Sleep(5000);
            return 10d;
        }
        static double DoIntensiveCalculations()
        {
            // We are simulating intensive calculations
            // by doing nonsense divisions
            double result = 100000000d;
            var maxValue = Int32.MaxValue;
            for (int i = 1; i < maxValue; i++)
            {
                result /= i;
            }
            return result + 10d;
        }
        static void RunSequencial()
        {
            double result = 0d;
            // Call the function to read data from I/O
            result += ReadDataFromIO();
            // Add the result of the second calculation
            result += DoIntensiveCalculations();
            // Print the result
            Console.WriteLine("The result is {0}", result);
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (!worker.IsBusy)
            {
                worker.RunWorkerAsync();
            }
        }
    }
}
