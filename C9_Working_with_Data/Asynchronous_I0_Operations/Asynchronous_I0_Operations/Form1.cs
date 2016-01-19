using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asynchronous_I0_Operations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var path = @"C:\Users\luisdeolpy\Documents";
            this.Text = "Searching...";
            string outputFileName = @"C:\Users\luisdeolpy\Documents\fileName.txt";
            await SearchDirectory(path, "a", outputFileName);
            this.Text = "Finished";
            Process.Start(outputFileName);
        }

        private static async Task SearchDirectory (string searchPath, string searchString, string outputFileName)
        {
            using (StreamWriter streamWriter = File.CreateText(outputFileName))
            {
                string[] fileNames = Directory.GetFiles(searchPath);
                await FindTextInFilesAsync(fileNames, searchString, streamWriter);
                streamWriter.Close();
            }

        }

        private static async Task FindTextInFilesAsync(string[] fileNames, string searchString, StreamWriter outputFile)
        {
            foreach (string fileName in fileNames)
            {
                if (fileName.ToLower().EndsWith(".txt"))
                {
                    using (StreamReader streamReader = new StreamReader(fileName)) {
                        string textOfFile = await streamReader.ReadToEndAsync();
                        if (textOfFile.Contains(searchString))
                        {
                            await outputFile.WriteLineAsync(fileName);
                        }
                    }
                }
            }
        }
    }
}
