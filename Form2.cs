using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;

namespace DataVisualizer
{
    public partial class Form2 : Form
    {
        private String filePath;

        public Form2()
        {
            InitializeLabel();
            InitializeButton();

            this.Size = new System.Drawing.Size(1050, 900);
            this.BackColor = Color.LightSkyBlue;
        }

        private void InitializeLabel()
        {
            Label label = new Label();

            label.Text = "Please upload a .xlsx file.";
            label.ForeColor = Color.White;
            label.Font = new System.Drawing.Font("Arial", 20, System.Drawing.FontStyle.Bold);
            label.Size = new System.Drawing.Size(800, 150);
            label.Location = new System.Drawing.Point(175, 125);

            this.Controls.Add(label);
        }

        private void InitializeOpenFileDialog()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Excel Files|*.xlsx";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    MessageBox.Show("File Uploaded: " + filePath);
                }
            }
        }

        private void InitializeButton()
        {
            Button buttonOne = new Button();
            Button buttonTwo = new Button();

            buttonOne.Text = "Upload a file from your computer";
            buttonOne.BackColor = Color.Gray;
            buttonOne.ForeColor = Color.White;
            buttonOne.Size = new System.Drawing.Size(400, 100);
            buttonOne.Location = new System.Drawing.Point(325, 250);

            buttonTwo.Text = "Select presets";
            buttonTwo.BackColor = Color.Gray;
            buttonTwo.ForeColor = Color.White;
            buttonTwo.Size = new System.Drawing.Size(150, 150);
            buttonTwo.Location = new System.Drawing.Point(450, 585);

            buttonOne.Click += buttonOne_Click;
            buttonTwo.Click += buttonTwo_Click;

            this.Controls.Add(buttonOne);
            this.Controls.Add(buttonTwo);
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            InitializeOpenFileDialog();
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            Form4 select = new Form4();
            select.Show();
            this.Hide();
        }
    }
}
