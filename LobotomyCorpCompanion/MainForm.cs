using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace LobotomyCorpCompanion
{
    public partial class MainForm : Form
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs (UnmanagedType.Bool)]
        static extern bool AllocConsole();

        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AllocConsole();
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Enter 'mock', 'full', 'set' or 'random' for the respective test");
            while (true)
            {
                string input = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Enter 'mock', 'full', 'set' or 'random' for the respective test");
                switch (input)
                {
                    case "mock":
                        Console.WriteLine(Tests.MockEmployee());
                        break;
                    case "full":
                        Console.WriteLine(Tests.FullyGiftedEmployee());
                        break;
                    case "set":
                        Console.WriteLine(Tests.SetTest());
                        break;
                    case "random":
                        Console.WriteLine(Tests.RandomTest());
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please enter 'mock', 'full', 'set'");
                        break;
                }
            }

        }
    }
}
