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
            ThanksToTheSoundTechForSortingTheCable();

            var i = new OwenNiblock();
            i.Think("That was a nice wee");
            i.Think("A nice sit down wee, the best kind");

            i.Think("This is nice music - anyone know who it is?");
            // No one
            //Literally no one

            //Hello! It's OK - the show's no started yet.
            // IT IS NOT FUCKING JAVA
            i.Think("It's C# motherfucker");
            i.GettingAngry();
            i.SoSoAngry();

            i.Think("I bet he doesn't wash his hands again");

            i.Say("It's not my problem either");

            i.HopeNot();

            i.Say("..."); // I'm not very good at conversation

            i.LoveItHere("The toilet graffiti is great!");
            //TODO: Fix the error above before pushing to github

            //At another gig - a guy got 
            // really cross because I wasn't saving often enough...

            i.WillSaveEvery15Minutes();
            //No - I'll forget and then lose it!

            //Everyone's a critic
            // Calum has the best laugh!
            // If he's not laughing at my show - you will know!

            var mc = new MCBot();
            mc.Name = "Paul";
            mc.TalksToPeople();

            i.Think("I feel old");
            //My wife loves them too
            //EDITED...


            //FUCK THE FOOTBALL!!!!!!!!!
            // SHHHHH!!
            // They don't know I'm here!
            i.Think("I've broken Paul");

            //WARNING!!
            i.Wonders("What else he has a large collection of " +
                "on his phone...");
            //SORRY!

            var bison = new Bison();
            bison.HavingATrip = true;

            //EDITED!

            i.Think("That's cool - whenever you're ready - " +
                "I am :-)");

            #endregion

            #region Audience Warm Up
            i.Say("Hello");
            //I'm going to do this for an hour.
            //Should've watched the football!

            i.Wonder("If anyone wants to talk?");
            i.Say("Hello Sam");
            i.Ask("What do you do with most of your time?");
            // I didn't want to assume you had a job...
            // I don't know why.

            i.ReallyWantATattoo = true;
            //Stick with the code...!!!

            i.Say("What do you do Sam?");
            //Vague...!
            // It's a pound - after brexit it'll be worth nothing.
            i.Say("What sort of 'business development'?");
            //MAKE STUFF UP!
            i.Say("Shit");
            i.Wonder("If you work for the government :-P");

            var sam = Audience.First(x => x.Name == "Sam");
            sam.Age = 18; // I HOPE NOT!!!!!
            // FUCK - I don't know. Let's say 18.
            sam.HairColour = Dyed;
            sam.Cheer(); // Broken.
            sam.Interests = new List<string>
                { "Circus", "Pole dancing"};

            i.Ask("What's you favorite colour pole?");
            //WHAT do I know about pole dancing??????????????????????????????????????????????????
            //Nothing.

            //That's a shame.
            //Let's start the show!!!
            //It's a show (sort of) about Autism.
            //with typos.

            BoomingVoiceOfGod("Please cheer and applaud or something" +
                "I don't know - make some noise for the start of the show");


            #endregion

            #region About Child #1
            var child1 = new Person();
            child1.Name = "[REDACTED]";
            //TODO: ^ remove the above before putting online...!

            child1.Age = 8; // On Tuesday!!
            //Shit kid's parties are hard work!
            // I sat in the corning coding
            // And apparently that makes me a "bad Dad"...!
            // Ha - I'm a liar.
            // She hates lies - so I will remove that.

            i.Feel("Like I'm winning at parenting at the moment");
            // For homework she had to choose her favourite place..
            child1.FavouritePlace = "Fairy land";
            //Because I wouldn't let her put Wehtherspoons!

            child1.WritesSongs();

            child1.Likes("Abergavenny food festival");
            i.Like("Abergavenny food festival - without children...");

            child1.Loves = new List<String>();
            child1.Loves.Add("Her Sister");
            child1.Loves.Add("Her Mum");
            child1.Loves.Add("Her Grandpa");
            child1.Loves.Add("Her Grandma");
            child1.Loves.Add("Her Nain");
            child1.Loves.Add("Her Taid");
            child1.Loves.Add("Frodo & Beorn");
            child1.Loves.Add("Hippy the hamster");
            child1.Loves.Add("Sam the dog");
            child1.Loves.Add("Friends at school");
            child1.Loves.Add("Daddy!");
            //Awww - she loves me!
            // That was a pocket money week!

            i.HaveStartedSayingDadPhrases = true;
            child1.OnBarney("It's strange Daddy, " +
                "he's a T-rex but he doesn't eat the children");

            child1.ProbabilityOfBeingOnTheSpectrum = 7;

            // I forgot about Saffron
            var child2 = new Person();
            child2.HairColour = "RED";
            // Little more (insert good word later before posting online)

            child2.Says("Daddy, I'm going to get bigger" +
                "and bigger until I'm Dead");
            child2.ProbabilityOfBeingOnTheSpectrum = 1;
            child2.ProbabilityOfBeingAnEvilPhyscho = 999999999;

            #endregion

            #region About My Wife
            // HAHAHAHAHA - EDIT THIS OUT BEFORE POSTING ONLINE..!
            var myWife = new Person();
            myWife.HairColour = Dyed;
            myWife.HasTatoos = true;
            i.Think("I'm punching above my weight!");
            //TODO: leave the above bit in..!
            //Might get a blowjob
            // Edit that out!!!!!!!!!!!!!!!!!!!!!

            myWife.HasOCD();
            myWife.HasOCD();
            myWife.HasOCD();

            i.SlamHeckler();
            i.HadAnArgumentWith(myWife);
            myWife.Says("I want a divorce");
            i.Say("...");
            child1.Says("I want doesn't get");
            //That was a double pocket money week!

            myWife.IsLikeMarmite("More expensive since brexit");
            myWife.IsLikeMarmite("I like to put my cock in it");

            // For my birthday
            myWife.MadeMeCross = true;
            // Now people are going to think there some weird terrorist shit going on..!

            myWife.ProbabilityOfBeingOnTheSpectrum = 3;

            #endregion

            #region About Me
            i.Drive = true;
            myWife.Drives = false;

            i.Have("Two left feet");
            //FUCK THE FOOTBALL!
            //Makes it really hard to run
            //But really easy to steal shoes!

            i.Was("Born in the year of the cock");
            i.Like("My baths monkey hot");

            i.Collect("Collect reasons why I'm not a real man");
            i.ReasonsWhyIamNotARealManCount = 327;
            i.AmNotARealManBecause("I sit down to wee");
            i.AmNotARealManBecause("When I saw the trailer " +
                "for the new Star Wars film" +
                "a little bit of wee came out.");

            i.AmNotARealManBecause("I play the flute");
            // Heckle: "no wonder your kids hate you!!!" - Sam, Fuel, 14/06/2018 22:01

            #endregion

            #region Conclusions
            // I really don't know what I'm doing but this is fun!
            // So I'm going to do it again.

            // I'm going to do this at Greenman...
            // WHAT THE FUCK AM I THINKING????????
            // I'm sure it'll be fine...


            // I might be on the Autism spectrum..?
            // My daughter (child1) might be on the spectrum
            // But she's also awesome!
            // 

            TheEnd();

            #endregion
        }

        private static void BoomingVoiceOfGod(string v)
        {
            throw new NotImplementedException();
        }

        private static void ThanksToTheSoundTechForSortingTheCable()
        {
            throw new NotImplementedException();
        }

        private static void TheEnd()
        {
            throw new NotImplementedException();
        }
    }
}
