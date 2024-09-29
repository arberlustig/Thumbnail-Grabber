using System.Net;
using System.Text.RegularExpressions;

namespace Thumbnail_Grabber
{
    public partial class Form1 : Form
    {
        string videoID;
        string imageURL;
        Image _downloadedImage;

        public Form1()
        {
            InitializeComponent();
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            try
            {
                 videoID = ExtractVideoId(urlBox.Text);
                 imageURL = AufBauRichtigerURL(videoID);

                using (WebClient client = new WebClient())
                {
                    string downloadFolder = Environment
                        .GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads";

                    if (!Directory.Exists(downloadFolder))
                    {
                        Directory.CreateDirectory(downloadFolder);
                    }

                    string savePath = Path.Combine(downloadFolder, "image.jpeg");
                    client.DownloadFile(imageURL,savePath);
                    
                    


                }
            }
            catch (Exception ex)
            {
                fehler.Text = ex.Message;
            }
        }

        private void vorschaubildButton_Click(object sender, EventArgs e)
        {
            videoID = ExtractVideoId(urlBox.Text);
            imageURL = AufBauRichtigerURL(videoID);

            try
            {
                using (WebClient client = new WebClient())
                {
                    try
                    {
                        // Bild herunterladen
                        byte[] imageData = client.DownloadData(imageURL);

                        // In einen MemoryStream umwandeln und das Bild laden
                        using (var ms = new System.IO.MemoryStream(imageData))
                        {
                            _downloadedImage = Image.FromStream(ms);
                        }

                        vorschauBild.Image = _downloadedImage;

                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Fehler beim Herunterladen: " + ex.Message);
                    }

                }
            }
            catch (Exception ex)
            {
                fehler.Text = ex.Message;
            }
        }

        private static string ExtractVideoId(string youtubeUrl)
        {
            // Regex für die Extraktion der Video-ID
            var regex = new Regex("[\\w-]{11}");
            var match = regex.Match(youtubeUrl);

            return match.Success ? match.Groups[0].Value : string.Empty;
        }

        private string AufBauRichtigerURL(string url)
        { 
            return $"https://img.youtube.com/vi/{url}/maxresdefault.jpg";
        }
    }
}
