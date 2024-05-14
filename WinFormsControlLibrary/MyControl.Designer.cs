namespace WinFormsControlLibrary
{
    partial class MyControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            led = new Panel();
            textBox = new TextBox();
            SuspendLayout();
            // 
            // led
            // 
            led.Dock = DockStyle.Left;
            led.Location = new Point(0, 0);
            led.Name = "led";
            led.Size = new Size(77, 76);
            led.TabIndex = 0;
            // 
            // textBox
            // 
            textBox.Location = new Point(126, 27);
            textBox.Name = "textBox";
            textBox.Size = new Size(168, 23);
            textBox.TabIndex = 1;
            textBox.TextChanged += textBox_TextChanged;
            // 
            // MyControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox);
            Controls.Add(led);
            Name = "MyControl";
            Size = new Size(337, 76);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel led;
        private TextBox textBox;
    }
}
