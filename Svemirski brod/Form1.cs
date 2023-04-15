namespace Svemirski_brod
{
    public partial class Form1 : Form
    {
        private Button[,] M = new Button[20, 20];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(660, 685);

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    M[i, j] = new Button();
                    M[i, j].Size = new Size(30, 30);
                    M[i, j].Location = new Point(5 + 32 * j, 5 + 32 * i);
                    M[i, j].BackColor = Color.Green;
                    M[i, j].Tag = i * 100 + j;
                    M[i, j].Click += Klikni;
                    this.Controls.Add(M[i, j]);
                }
            }
        }

        private void Klikni(object? sender, EventArgs e)
        {
            int tag = (int)(sender as Button).Tag;
            int i = tag / 100;
            int j = tag % 100;
            for (int k = 0; k < 20; k++)
            {
                //farbamo trazeni red
                if (M[i, k].BackColor == Color.Red)
                    M[i, k].BackColor = Color.Green;
                else
                    M[i, k].BackColor = Color.Red;

                //farbamo trazenu kolonu
                if (M[k, j].BackColor == Color.Red)
                    M[k, j].BackColor = Color.Green;
                else
                    M[k, j].BackColor = Color.Red;
            }
            // farbamo polje gde smo kliknuli
            if (M[i, j].BackColor == Color.Red)
                M[i, j].BackColor = Color.Green;
            else
                M[i, j].BackColor = Color.Red;
            MessageBox.Show("Tag: " + tag);
        }
    }
}