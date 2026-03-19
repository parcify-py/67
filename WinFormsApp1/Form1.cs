using System.Media;
using System.Windows.Media;

namespace WinFormsApp1;

public partial class Form1 : Form
{
    MediaPlayer soundPlay = new MediaPlayer();
    public Form1()
    {
        InitializeComponent();
        trackBar1.Minimum = 0;
        trackBar1.Maximum = 100;
        trackBar1.Value = 50;
        
    }
    
    private void button1_Click(object sender, EventArgs e)
    {
        soundPlay.Open(new Uri("metalpipe.mp3",UriKind.Relative));
        soundPlay.Play();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        
        soundPlay.Open(new Uri("bruh.mp3",UriKind.Relative));
        soundPlay.Play();
    }

    private void button3_Click(object sender, EventArgs e)
    {
        soundPlay.Open(new Uri("apay.mp3",UriKind.Relative));
        soundPlay.Play();
    }

    private void button4_Click(object sender, EventArgs e)
    {
        soundPlay.Open(new Uri("67.mp3",UriKind.Relative));
        soundPlay.Play();
    }

    private void trackBar1_Scroll(object sender, EventArgs e)
    {
        soundPlay.Volume = trackBar1.Value / 100.0;
    }

    private void label2_Click(object sender, EventArgs e)
    {
        
    }
}