namespace Demo
{
    public partial class Form1 : Form
    {
        string preFocusPic;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_CreateCons_Click(object sender, EventArgs e)
        {
            int picCount = 3;
            int interval = 10;
            for (int i = 0; i < picCount; i++)
            {
                PictureBox newPic = new();
                newPic.Name = "pic_" + i;
                newPic.Location = new Point(0, (newPic.Size.Height + interval) * i);
                newPic.BackColor = Color.Black;
                newPic.Parent = this;
                newPic.Click += new EventHandler(picClickMark);
            }
            btn_CreateCons.Enabled = false;
        }

        void picClickMark(object sender, EventArgs e)
        {
            preFocusPic = (sender as Control).Name;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && !string.IsNullOrEmpty(preFocusPic))
            {
                try { (this.Controls.Find(preFocusPic, false)[0]).Dispose(); }
                catch { }
            }
        }
    }
}