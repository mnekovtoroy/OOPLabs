namespace Lab11_LINQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArtistsListBox.DataSource = Album.GetAlbums()
                .Select(album => album.Artist)
                .Distinct()
                .ToList();
        }
    }
}