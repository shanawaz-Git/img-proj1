namespace img_proj1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnopen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofile = new OpenFileDialog();
            ofile.Filter = "All files (*.*)|*.*";
            if (DialogResult.OK == ofile.ShowDialog())
            {
                this.picorg.Image = new Bitmap(ofile.FileName);

            }
        }

        private void btngrey_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap((Bitmap)this.picorg.Image);
            process.ConvertToGray(copy);
            this.picgrey.Image = copy;
        }
    }
}