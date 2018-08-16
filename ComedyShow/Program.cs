using Comedy;
using System;
using System.Collections.Generic;
using System.Linq;
using Universe;

namespace ComedyShow
{
    class Program
    {
        private static string Dyed;

        public static Audience Audience { get; set; }
        public static MCBot YourMC { get; set; }
        public static int MusicVolume { get; private set; }

        static void Main(string[] args)
        {
            #region Before The Show
            var i = new OwenNiblock();
            i.Wonder("How it got so cold!");
            // Thank you to Dan!!

            i.Think("The show will start in about 20 min?");
            i.DoNotKnow();

            i.LoveCoding = true;

            //This is a show written specifically for Dave!
            // You can see the code at: https://github.com/owenniblock/comedyshow :)

            i.Think("I need another drink shelf!");

            i.Wonder("If my wife would like this????"); // Probably not!
            i.AmGoingForAWee = true;

            // This isn't the show by the way. Although it's similar to the show.
            // I'm just killing time :)
            // I got water on my sleeve. Looks like I weed on myself.
            // It's just water. Honest.

            i.Wonder("Who burped");
            i.Think("Yes");

            // Solarsphere is amazing :) Love it!!!!!
            // You can read!
            i.Think("I'm a bit worried now!");

            #endregion

            #region Audience Warm Up
            i.Wonder("How old is your 'baby boy'?");
            i.Think("I can say Fuck if I want");

            i.DoNotDoJokes();

            i.Say("Hello");
            i.Say("Are you well?");
            // I knew that and I still asked
            // it's like I don't care!

            i.Say("Give me a cheer for the start of the show");
            // That was pretty good

            i.Say("All the men - give me a cheer like a lady");
            // Not so good

            i.Say("All the women - give me a cheer like a man");
            //Much better!

            // Always be nice to the ladies.
            // THEY WILL HURT YOU!

            // DO YOU WANT A JOKE?
            // You'll have to wait until after the code.

            // Which is in about an hour
            // after I go to bed.

            i.Think("We have a heckler!");
            // Too drunk to read...
            i.Think("Not much - there's space");
            //Except up in the air!
            i.LikeBrandy = true;
            i.Think("You're an asshole");
            i.WouldLoveToSeeThat = true;

            i.FeelCold();
            // I can type very fast!
            // The quick brown fox jumped over the whatever the fucking fox jumps over!

            #endregion

            #region 15 mins of jokes?
            i.Age = 37; // In years


            #endregion

            #region About Child #1
            var child1 = new Person();
            i.Wonder("What is his name?");
            // Thanks
            // We can use that

            i.Think("When he comes back - we should play a game with him...");
            i.Wonder("Do you know something that scares him?");

            // What sort of joke would he like?
            i.AmGoingToBeVeryCarefulWhatISay();

            // Just that he seems quite nice
            // Round of applause for Dan!
            child1.Age = 8;

            child1.Name = "Jasmine";
            // TODO: Remove this before pushing to GitHub

            child1.WritesSongs();

            i.AmWinningAtParenting();

            child1.LovesAFoodFestival();

            // It is 00:50! 
            #endregion

            // THIS HAS BEEN AN EXPERIENCE


            #region About My Wife
            i.HaveAMantra("I am still enjoying this");

            //Surreal heckling!

            #endregion

            #region About Me

            #endregion

            #region Conclusions
            i.Think("This has been fun");
            i.Hope("You agree");
            i.WillSeeYouAllTomorrow();
            #endregion
        }

        private static void BoomingVoiceOfGod(string v)
        {
            
        }

        private static void TheEnd()
        {
            throw new NotImplementedException();
        }
    }
}
