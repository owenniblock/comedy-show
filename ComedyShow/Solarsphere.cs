using System;
using System.Collections.Generic;
using System.Text;
using Universe;

namespace ComedyShow
{
    public class Solarsphere
    {
        public void AboutTheShow()
        {
            var show = new Show();
            show.DateAndTime = DateTime.Parse("Friday 10th August, 23:59");
            show.Title = "Spectral Analysis";
            show.Performer = new OwenNiblock();
            show.IsFunny = true; //I hope so!
            show.IsGeeky = true; //I know so!
            show.Performer.HopesToSeeYouThere();
            var photoCredit = "Photo © Ed Moore Photography @edshots";
        }
    }
}
