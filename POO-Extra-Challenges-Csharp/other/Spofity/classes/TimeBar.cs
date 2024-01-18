using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class TimeBar
{
    private Form SpofityForm;
    public GraphicsState State;
    private int totalSize = 700;
    private int newBarSize;

    public TimeBar(Form spofityForm)
    {
        SpofityForm = spofityForm;
    }

    public void NewFormBar(object sender, PaintEventArgs e){
        Graphics g = e.Graphics;

        e.Graphics.Restore(State);
        SolidBrush brushCurrentBar = new SolidBrush(Color.Black);
        Rectangle currentBar = new Rectangle(30, 200, newBarSize, 2);
        g.FillRectangle(brushCurrentBar, currentBar);
    }

    public void Show(int currentSecond, int totalSeconds)
    {
        int nerwBarSize = (currentSecond * totalSize) / totalSeconds;
        SpofityForm.Paint += NewFormBar;
    }
}

