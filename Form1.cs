namespace DataVisualizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeLabels();
            InitializeButtons();

            this.Size = new System.Drawing.Size(1050, 900);
            this.BackColor = Color.LightSkyBlue;
        }

        private void InitializeLabels()
        {
            Label labelOne = new Label();
            Label labelTwo = new Label();

            labelOne.Text = "Welcome to Data Visualizer!";
            labelOne.ForeColor = Color.White;
            labelOne.Font = new System.Drawing.Font("Arial", 20, System.Drawing.FontStyle.Bold);
            labelOne.Size = new System.Drawing.Size(800, 150);
            labelOne.Location = new System.Drawing.Point(150, 125);

            labelTwo.Text = "Please choose a button to proceed...";
            labelTwo.ForeColor = Color.White;
            labelTwo.Font = new System.Drawing.Font("Arial", 10);
            labelTwo.Size = new System.Drawing.Size(800, 150);
            labelTwo.Location = new System.Drawing.Point(275, 625);

            this.Controls.Add(labelOne);
            this.Controls.Add(labelTwo);
        }
        private void InitializeButtons()
        {
            Button buttonOne = new Button();
            Button buttonTwo = new Button();
            Button exit = new Button();

            buttonOne.Text = "New Project";
            buttonOne.BackColor = Color.LimeGreen;
            buttonOne.ForeColor = Color.White;
            buttonOne.Size = new System.Drawing.Size(150, 150);
            buttonOne.Location = new System.Drawing.Point(225, 385);

            buttonTwo.Text = "Create a custom preset";
            buttonTwo.BackColor = Color.Green;
            buttonTwo.ForeColor = Color.White;
            buttonTwo.Size = new System.Drawing.Size(150, 150);
            buttonTwo.Location = new System.Drawing.Point(635, 385);

            exit.Text = "Exit";
            exit.BackColor = Color.Red;
            exit.ForeColor = Color.White;
            exit.Size = new System.Drawing.Size(100, 100);
            exit.Location = new System.Drawing.Point(20, 20);

            buttonOne.Click += buttonOne_Click;
            buttonTwo.Click += buttonTwo_Click;
            exit.Click += exit_Click;

            this.Controls.Add(buttonOne);
            this.Controls.Add(buttonTwo);
            this.Controls.Add(exit);
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            Form2 upload = new Form2();
            upload.Show();
            this.Hide();
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            Form3 preset = new Form3();
            preset.Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
