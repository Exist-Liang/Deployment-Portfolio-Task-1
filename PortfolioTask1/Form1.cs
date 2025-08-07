using myLibrary1; 
using System;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace PortfolioTask1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var button = new Button()
            {
                Text = "Click Me",
                Dock = DockStyle.Top
            };

            var label = new Label()
            {
                Text = "Waiting for result...",
                Dock = DockStyle.Fill,
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            };

            
            button.Click += (s, e) =>
            {
                int result = MathHelper1.Add(6, 9);  
                label.Text = $"Sum = {result}";
            };



            Controls.Add(label);
            Controls.Add(button);
        }

        private void Josn_Click(object sender, EventArgs e)
        {
            var obj = new { Name = "test", Score = 100 };
            string json = JsonConvert.SerializeObject(obj, Formatting.Indented);
            JosnOutput.Text = json;
        }
    }
}
