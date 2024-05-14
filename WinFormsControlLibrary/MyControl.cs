using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsControlLibrary
{
    [ToolboxBitmap(@"D:\HAI project\.Net\NetLab1\WinFormsControlLibrary\Icon1.ico")]
    public partial class MyControl : UserControl
    {
        public MyControl()
        {
            InitializeComponent();
            led.BackColor = Color.LightGray;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                led.BackColor = Color.LightGray;
            }
            else
            {
                if (int.TryParse(textBox.Text, out int number))
                {
                    if (number > 0)
                        led.BackColor = Color.Green;
                    if (number < 0)
                        led.BackColor = Color.Red;
                }
                else
                {
                    led.BackColor = Color.LightGray;
                }
            }
        }
    }
}
