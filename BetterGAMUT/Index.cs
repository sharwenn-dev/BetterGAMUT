namespace BetterGAMUT
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }
        private void Exercises_Click_1(object sender, EventArgs e)
        {
            Exercises frm = new Exercises(this);
            frm.Show();
            this.Hide();
        }

        private void Lessons_Click_1(object sender, EventArgs e)
        {
            Lessons frm = new Lessons(this);
            frm.Show();
            this.Hide();
        }

        private void closebutton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}