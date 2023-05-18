namespace Lab11_LINQ_2
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

        private void ArtistsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AlbumsListBox.DataSource = Album.GetAlbums()
                .Where(album => album.Artist == ArtistsListBox.SelectedItem.ToString())
                .ToList();
        }
    }
}