namespace meet_5
{
    public partial class PictureViewer : Form
    {
        public PictureViewer()
        {
            InitializeComponent();
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            if (folderBrowserDialog1.SelectedPath != "")
            {
                // Remove any files that were selected previously.
                cboPictures.Items.Clear();
                string[] files = Directory.GetFiles(folderBrowserDialog1.SelectedPath, "*", SearchOption.AllDirectories);
                // Add each file to the combo box.
                foreach (string s in files)
                {
                    // Convert s to upper case for ease of comparing
                    string upper = s.ToUpper();
                    // Only add to combo box if a picture.
                    if (upper.Contains(".JPG") || upper.Contains(".PNG") || upper.Contains(".BMP") || upper.Contains(".GIF"))
                    {
                        cboPictures.Items.Add(s);
                    }
                }
                // If no pictures were found in the selected folder don't display the combo box.
                if (cboPictures.Items.Count > 0)
                {
                    // Select the first item in the combo box.
                    cboPictures.SelectedIndex = 0;
                    cboPictures.Visible = true;
                }
                else
                {
                    cboPictures.Visible = false;
                }
            }
        }

        private void PictureViewer_Load(object sender, EventArgs e)
        {

        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            // Set the filter so that only pictures can be selected.
            openFileDialog1.Filter = "All Pictures|*.bmp;*.gif;*.png;*.jpg|JPG|*.jpg|Bitmaps|*.bmp|GIFS|*.gif|PNG|*.png";
            // Get rid of any previous filename
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            // If the user clicks CANCEL the filenamebis blank
            if (openFileDialog1.FileName != "")
            {
                // Load the selected picture into the picture box
                picShow.Load(openFileDialog1.FileName);
                // Display the name of the file
                Text = openFileDialog1.FileName;
            }
            
           
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            //  End the program by clsing the form.
            this.Close();
        }

        private void cboPictures_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Display the picture selected in the combo box.
            string filename = cboPictures.Text;
            Text = filename;
            picShow.Load(filename);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // If there are items in the combo box change the index.
            // Changing the index causes the selected picture to show.
            if (cboPictures.Items.Count > 0)
            {
                if (cboPictures.SelectedIndex < cboPictures.Items.Count - 1)
                {
                    // Go to next item.
                    cboPictures.SelectedIndex += 1;
                }
                else
                {
                    // Go back to first item.
                    cboPictures.SelectedIndex = 0;
                }
            }
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
