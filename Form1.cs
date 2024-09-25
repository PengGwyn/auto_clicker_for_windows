using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwoAutoClicker
{
    public partial class Form1 : Form
    {
        // Constants for mouse events
        const int MOUSEEVENTF_LEFTDOWN = 0x02;
        const int MOUSEEVENTF_LEFTUP = 0x04;

        // Import the necessary Windows API functions
        [DllImport("user32.dll", SetLastError = true)]
        static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, int dwExtraInfo);

        [DllImport("user32.dll")]
        static extern bool SetCursorPos(int X, int Y);

        private bool isReadingSecondClick = false;
        private bool isClickingSecondPos = false;

        private int firstClickPosX;
        private int firstClickPosY;

        private int secondClickPosX;
        private int secondClickPosY;

        private int repeatitionCount;

        // This method simulates a mouse click at the given position
        private void SimulateMouseClick(int x, int y)
        {
            // Set the cursor position (optional, can be skipped if you don't want to move the cursor)
            // SetCursorPos(x, y);

            // Perform the mouse down and up to simulate a left click
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, (uint)x, (uint)y, 0, 0);
        }

        public Form1()
        {
            InitializeComponent();
            clickPhaseTxt.Text = "1st Pos";
        }

        private void timesOfClicksPerLocationInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the key is a control key (backspace, delete, etc.)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // If the key is not a control key or a digit, block the input
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (timesOfClicksPerLocationInput.Text == "")
                return;

            int clicks = Convert.ToInt32(timesOfClicksPerLocationInput.Text);
            Console.WriteLine(clicks);
            while (clicks >= 0)
            {
                clickCountLbl.Text = clicks.ToString();
                if (!isClickingSecondPos)
                {
                    SimulateMouseClick(firstClickPosX, firstClickPosY);
                    Cursor.Position = new Point(firstClickPosX, firstClickPosY);
                    isClickingSecondPos = true;
                }
                else
                {
                    SimulateMouseClick(secondClickPosX, secondClickPosY);
                    Cursor.Position = new Point(secondClickPosX, secondClickPosY);
                    isClickingSecondPos = false;
                }

                // Sleep for 1 seconds (1000 milliseconds)

                Thread.Sleep(1000);
                clicks--;
            }
            clickPhaseTxt.Text = "1st Pos";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!isReadingSecondClick)
            {
                firstClickPosX = Cursor.Position.X;
                firstClickPosY = Cursor.Position.Y;
                isReadingSecondClick = true;
                clickPhaseTxt.Text = "2nd Pos";
                firstPosLbl.Text = "X: " + firstClickPosX.ToString() + " | Y: " + firstClickPosY.ToString();
            }
            else
            {
                secondClickPosX = Cursor.Position.X;
                secondClickPosY = Cursor.Position.Y;
                isReadingSecondClick = false;
                clickPhaseTxt.Text = "Start Click";
                secondPosLbl.Text = "X: " + secondClickPosX.ToString() + " | Y: " + secondClickPosY.ToString();
            }
        }
    }
}
