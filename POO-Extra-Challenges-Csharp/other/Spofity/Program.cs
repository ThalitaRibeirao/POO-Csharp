using System;
using System.CodeDom;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using static System.Drawing.Graphics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Spofity
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            Controller controller = new Controller();

            controller.InitForm();

            //SpofityForm.Show();

            // Run form
            //Display display = new Display(spofityForm, pb, songTitle, songArtist, songTime, back, pause, next, timeBar);
            //display.ShowInfo("Stay With Me", "Miki Matsubara", "ab67616d0000b27381052badd62d5e14c3377786", 20, 80);

            //Application.Run(spofityForm);
        }
    }
}