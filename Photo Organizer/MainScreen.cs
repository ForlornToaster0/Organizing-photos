using Core;

namespace Photo_Organizer
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void FindPhotoFolderButton_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog diag = new();
            if (diag.ShowDialog() == DialogResult.OK)
            {
                FindPhotoFolder.Text = diag.SelectedPath;  //selected folder path

            }
            else
            {
                FindPhotoFolder.Text = null;
            }

        }

        private void FindNewLocationButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog diag = new();
            if (diag.ShowDialog() == DialogResult.OK)
            {
                FindNewLocation.Text = diag.SelectedPath;  //selected folder path

            }
            else
            {
                FindNewLocation.Text = null;
            }

        }

        private  void StartButton_Click(object sender, EventArgs e)
        {

            CoreFunction.Task(FindPhotoFolder.Text, FindNewLocation.Text);
        }
    }
}