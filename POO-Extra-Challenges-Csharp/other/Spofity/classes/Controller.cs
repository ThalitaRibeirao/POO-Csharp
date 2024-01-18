using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Drawing.Graphics;

public class Controller
{
    public Form SpofityForm = new Form();
    public PictureBox PbContainer = new PictureBox();
    public Label SongTitleContainer = new Label();
    public Label SongArtistContainer = new Label();
    public Label SongTimeContainer = new Label();
    public Button BackButtonContainer = new Button();
    public Button PauseButtonContainer = new Button();
    public Button NextButtonContainer = new Button();
    // public TimeBar TimeBarContainer = new TimeBar(SpofityForm);

    public void InitForm()
    {
        SpofityForm.FormBorderStyle = FormBorderStyle.FixedSingle;
        Size size = new Size(800, 300);
        Point point = new Point(0, 0);
        SpofityForm.Bounds = new Rectangle(point, size);

        SetFormTexts();
        SetFormImage();
        SetFormButtons();
        // SpofityForm.Paint += SetFormBar;
    }
    public void SetFormImage()
    {
        PbContainer.Dock = DockStyle.None;
        PbContainer.Anchor = AnchorStyles.Top | AnchorStyles.Left;
        PbContainer.Location = new Point(30, 30);
        PbContainer.SizeMode = PictureBoxSizeMode.StretchImage;
        PbContainer.Size = new Size(150, 150);
        SpofityForm.Controls.Add(PbContainer);
    }

    // obs: .TextAlign doesn't works with Autosize - autosize resizes the container, not allowing correct alignment
    public void SetFormTexts()
    {
        // Song Title
        SongTitleContainer.Text = "Stay With Me";
        SongTitleContainer.Font = new Font("Arial", 18, FontStyle.Bold);
        SongTitleContainer.ForeColor = Color.Black;
        SongTitleContainer.AutoSize = true;
        SongTitleContainer.Location = new Point(200, 30);
        SongTitleContainer.Controls.Add(SongTitleContainer);

        // Song Artist
        SongArtistContainer.Text = "Miki Matsubara";
        SongArtistContainer.Font = new Font("Arial", 12);
        SongArtistContainer.ForeColor = Color.Black;
        SongArtistContainer.AutoSize = true;
        SongArtistContainer.Location = new Point(202, 70);
        SpofityForm.Controls.Add(SongArtistContainer);

        // Time of Song
        SongTimeContainer.Text = "0:32 / 7:19";
        SongTimeContainer.Font = new Font("Arial", 10);
        SongTimeContainer.ForeColor = Color.Black;
        SongTimeContainer.AutoSize = true;
        SongTimeContainer.Location = new Point(650, 160);
        SpofityForm.Controls.Add(SongTimeContainer);
    }

    public void SetFormButtons()
    {
        // Preview button
        BackButtonContainer.BackColor = Color.Transparent;
        BackButtonContainer.ForeColor = Color.Black;
        BackButtonContainer.FlatAppearance.BorderSize = 0;
        BackButtonContainer.TextAlign = ContentAlignment.MiddleCenter;
        BackButtonContainer.AutoSize = true;
        BackButtonContainer.Text = "<";
        BackButtonContainer.Font = new Font("Arial", 12, FontStyle.Bold);
        BackButtonContainer.Location = new Point(320, 150);
        SpofityForm.Controls.Add(BackButtonContainer);

        // Stop Button
        PauseButtonContainer.BackColor = Color.Transparent;
        PauseButtonContainer.ForeColor = Color.Black;
        PauseButtonContainer.FlatStyle = FlatStyle.Flat;
        PauseButtonContainer.FlatAppearance.BorderSize = 0;
        PauseButtonContainer.AutoSize = true;
        PauseButtonContainer.TextAlign = ContentAlignment.MiddleCenter;
        PauseButtonContainer.Text = "| |";
        PauseButtonContainer.Font = new Font("Arial", 12, FontStyle.Bold);
        PauseButtonContainer.Location = new Point(370, 150);
        SpofityForm.Controls.Add(PauseButtonContainer);

        // Next button
        NextButtonContainer.BackColor = Color.Transparent;
        NextButtonContainer.ForeColor = Color.Black;
        NextButtonContainer.FlatStyle = FlatStyle.Flat;
        NextButtonContainer.FlatAppearance.BorderSize = 0;
        NextButtonContainer.TextAlign = ContentAlignment.MiddleCenter;
        NextButtonContainer.AutoSize = true;
        NextButtonContainer.Text = ">";
        NextButtonContainer.Font = new Font("Arial", 12, FontStyle.Bold);
        NextButtonContainer.Location = new Point(420, 150);
        SpofityForm.Controls.Add(NextButtonContainer);
    }
    public void SetFormBar(object sender, PaintEventArgs e)
    {
        Graphics g = e.Graphics;
        SolidBrush brushTotalTime = new SolidBrush(Color.LightGray);
        Rectangle totalTime = new Rectangle(30, 200, 700, 2);
        g.FillRectangle(brushTotalTime, totalTime);
        //TimeBar.State = e.Graphics.Save();
    }
}
