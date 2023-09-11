
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Drawing;
using System.Drawing.Imaging;


namespace MediaCapture
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection captureDevices;
        private VideoCaptureDevice videoSoruce;
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (videoSoruce.IsRunning)
            {
                videoSoruce.SignalToStop();
                videoSoruce.WaitForStop();
                pictureBox1.Image = null;
                pictureBox1.Invalidate();
            }
            videoSoruce = new VideoCaptureDevice(captureDevices[comboBoxWebCamList.SelectedIndex].MonikerString);
            videoSoruce.NewFrame += new NewFrameEventHandler(VideoSoruce_NewFrame);
            videoSoruce.Start();
        }

        private void VideoSoruce_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (videoSoruce.IsRunning)
            {
                videoSoruce.SignalToStop();
                videoSoruce.WaitForStop();
                pictureBox1.Image = null;
                pictureBox1.Invalidate();
                pictureBox2.Image = null;
                pictureBox2.Invalidate();
            }
            Application.Exit(null);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void buttonCapture_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = (Bitmap)pictureBox1.Image.Clone();

        }
        private void buttonSaveImage_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save Image As";
            saveFileDialog.Filter = "Image files (*.jpg, *.png) | *.jpg, *.png";
            ImageFormat imageFormat = ImageFormat.Png;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(saveFileDialog.FileName);
                switch (ext)
                {
                    case ".jpg":
                        imageFormat = ImageFormat.Jpeg;
                        break;
                    case ".png":
                        imageFormat = ImageFormat.Png;
                        break;
                }
                pictureBox2.Image.Save(saveFileDialog.FileName, imageFormat);
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            captureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo deviceList in captureDevices)
            {
                comboBoxWebCamList.Items.Add(deviceList.Name);
            };

            comboBoxWebCamList.SelectedIndex = 0;
            videoSoruce = new VideoCaptureDevice();

        }

    }
}