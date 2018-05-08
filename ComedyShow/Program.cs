using Comedy;
using System;
using System.Collections.Generic;
using System.Linq;
using Universe;

namespace ComedyShow
{
    class Program
    {
        public static Audience Audience { get; set; }
        public static MCBot YourMC { get; set; }
        public static int MusicVolume { get; private set; }

        static void Main(string[] args)
        {
            #region Before The Show
            //Tech set-up! :-) Thanks guys!
            var techPerson = new PersonAtShow();
            techPerson.Name = "Johnny";

            var i = new OwenNiblock();
            i.Think("I like this song :-)");
            i.Think("This venue is lovely. I hope the swallow" +
                "doesn't poo on my laptop though");

            var mc = new MCBot();
            mc.Name = "MC Botty Bot";
            i.Think("People can come in, that's fine");
            i.Say("Sure, they can come in!");

            i.Think("Why is there a Bambi light shade in here?");
            i.Wonder("Is everyone going to now be looking" +
                "for the light shade?");

            i.Wonder("Why people won't sit at the front..!");
            i.Think("I'm not that scary!");

            i.Think("This is going to fun!");
            i.Wonder("If no-one sits at the front - you " +
                "_are_ the front..!");
            i.Wonders("If I can do the whole show without" +
                "saying a word..!");
            i.Think("My wife would prefer it!");
            i.Think("You've been saved! We have a front row");

            i.Wonder("If we're going to start on time");

            i.Think("It's a garage..?");
            i.Say("I have a very small car");
            i.Say("It's a Toyota Yaris");

            i.Wonder("If everyone is nice");
            i.Think("You seem nice");

            i.Say("I'm outta here");
            i.Wonder("How that would go");
            i.Think("I'd still like to see it");

            i.Says("This is C#");
            i = new OwenNiblock();
            //Very good

            //This IS my life!
            //I'm not sure I should brag about that

            //After the show - the code will be at:
            //https://github/com/owenniblock/comedy-show

            //We should start!

            MusicVolume = 11; //!!!!
            mc.Says("Please welcome to the stage..." +
                "Owen Niblock!!!");

            i.Say("Thank you");

            MusicVolume = 6;
            while (Audience.WalkingIn)
            {
                
            }

            #endregion

            #region Audience Warm Up
            mc.Says("This is a ridiculous idea");
            //I'm going to see how much ot the show I can
            // do before I have to talk
            // I have an hour of jokes
            // I hope we don't get to them!!

            mc.Says("We should talk to someone..");
            //Could someone volunteer? I hate picking on people!

            mc.Says("Hello man with Bandana!");
            mc.Says("What is your name?");
            var audienceMember1 = new PersonAtShow();
            audienceMember1.Name = "Jay";
            //Shit that took a long time!

            audienceMember1.Occupation = null;
            audienceMember1.Occupation = "Crane driver";
            mc.Says("Really????");
            // That it pretty cool!

            mc.Says("What sort of crane?");
            //Technical is the name of the game!!
            //My daughter would like to meet you!

            //She's 7 - fuck off :-P
            mc.Says("This had taken a sudden turn..!");
            mc.Says("This show is about Autism. Sort of.");
            mc.Says("I mean - look at him!");

            i.Think("That's a bit harsh");
            i.Wonder("If sympathy counts as success..?");

            //YES!
            //It's very hot

            i.Think("I should have worn a T-shirt");
            i.Wonder("What I am doing!?");

            //OK - let's get on to the meat of the show..
            //You seem warmed up?

            //No - you're cool - Mr Bandana Man.



            #endregion

            #region About Child #1
            var child1 = new Person();
            child1.Name = "[REDACTED]"; //TODO: I will remove this before putting it online!! Sensible!
            child1.Occupation = "Layabout"; //She does like cranes though
            child1.Says("She has an order of love...");
            var orderOfJasminesLove = new List<string>();
            orderOfJasminesLove.Add("Mum");
            orderOfJasminesLove.Add("Sister");
            orderOfJasminesLove.Add("Nain"); // Her Welsh Grandma
            orderOfJasminesLove.Add("Taid"); // Her Welsh Grandpa
            orderOfJasminesLove.Add("Sam the dog"); // My parent's dog :)
            orderOfJasminesLove.Add("Frodo"); // Our cat
            orderOfJasminesLove.Add("Beorn"); // Our other cat
            orderOfJasminesLove.Add("Grandma");
            orderOfJasminesLove.Add("Grandpa"); //TODO: Move these around before pushing up to git...
            orderOfJasminesLove.Add("Hippy the Hamster");
            orderOfJasminesLove.Add("Her best friend Ava");
            //It's ok!
            orderOfJasminesLove.Add("Dad"); //!!!!!
            //She loves me!
            //That was a pocket money week
            //I'm totally not saying a word for this whole show.
            //Shit
            //Lies lies and more lies

            i.Wonder("If you would beat my daughter at a pendants competition..." +
                "She's very very good!");

            child1.ProbabilityOfBeingOnTheSpectrum = 7; // Out of 10.
            //We're currently going through the process of
            // Diagnosis...
            // She is AMAZING!
            // But sometimes finds life hard.
            var niceLadyAtTheFront = new PersonAtShow();
            niceLadyAtTheFront.ProbabilityOfBeingOnTheSpectrum = 1;
            //Phew.

            child1.Thinks("Ballet is the best thing." +
                "Cats are second best." +
                "I have no joke for this." +
                "But if you see her - say hi." +
                "She'll get shy but he happy");

            child1.WritesSongs();

            //She does :)
            // Although not seen Cats yet!

            //I am going to sing one of Jasmine's songs...
            // That is ACTUALLY one of her songs :)
            // I'll tell her you loved it!

            //This was Jasmine's thoughts on Barnie..

            child1.Says("Daddy, he's a massive purple T-Rex but he doesn't eat the children");
            //She has a point!
            //That should be the final episode!!
            #endregion
            //I'm lost!
            #region About Child #2
            var child2 = new Person();
            child2.Name = "[REDACTED]"; //TODO: Redact before uploading to github.
            child2.Age = 3;
            child2.Says("Poopeepants"); //ALL THE FUCKING TIME!!!
            child2.Says("Daddy, I'm going to get bigger and bigger until I'm dead");
            child2.Says("No, there's no Tooth Fairy");
            //She said it to make her 7 year old sister cry!
            //She's evil!!!!!!!!
            child2.HairColour = "Red";// Doing nothing for the stereotypes...

            child2.Says("Mummy.. you look beautiful today-can-I-have-a-sweety?");

            child2.ProbabilityOfBeingOnTheSpectrum = 0; // Maybe -1..?
            child2.ProbabilityOfBeingAnEvilPhyscho = 10000000;
            //She takes after my wife :-D
            //TODO: ^ Remove the above...!

            //You can tell when she's cross.
            //She's awake.
            i.Think("Is she cross when she's asleep?");
            //We don't know - she hasn't slept yet..!

            //We played Drs And Nurses.
            // There were no beds so I had to sleep on the landing.
            // And then... I died!
            // And had to go in the cupboard.
            // Which they both decided was the morgue..!
            //It's ok - I have now put gin in there.
            //I look forward to dying again!

            child2.WritesSongs(); // <-- She wants to be like her sister...
                                  //She told me to sing this song.
                                  //EXACTLY like this...
                                  //I'll tell her you liked it...


            //TODO: Remove the whitespace.

            //Forgot a bit.
            //It's a Work In Progress.
            //Shut up!

            child2.Interests.Add("Painting");
            //This is her painting...
            i.Say("Aww, what is it?");
            child2.Says("It's a house");
            child2.Says("They're flames");
            child2.Says("They're all dead");
            child2.ProbabilityOfBeingAnEvilPhyscho = 999999999;

            //This was her first full sentence..
            child2.Says("Daddy hair gone");
            //I have flyaway hair - it just never came back.










            #endregion

            #region About My Wife
            //HAHHAHAHAHAHAHA
            //TODO: Remove all of this section..!
            i.Think("I am glad you're not hecking...!");
            //How would I SLAM you back down..?
            i.SlamHeckler("Your Mum.. or something");

            i.Think("That was gross");
            i.Think("We could be friends");

            //The best heckle I ever had.
            //Was in Edinburgh.
            //I did this joke:
            i.Say("I like my mem like I like my coffee");
            i.Say("I don't like coffee");

            var heckler = new Person(); //Barely a person..!
            heckler.Says("You like black coffee!!");
            var myWife = heckler; //!!
            //Yeah - I married that lady...
            //she doesn't heckle me any more...
            //We have two kids.
            //She can't come to my gigs :-)

            //So don't heckle me... I might try and impregnate you!
            //You would like to see me try!
            //But that is next year's show.

            i.Think("That bit has gone far enough");

            myWife.HasOCD();
            myWife.HasOCD();
            myWife.HasOCD();

            //She prefers it if I say it 3 times.

            //We were arguing...
            myWife.Says("I want a divorce..!");
            i.Say("...");
            child1.Says("I want doesn't get!");
            //That was a double pocket money week!

            var dadPhrases = "I'll tell you what's not fair.." +
                "life!";

            dadPhrases = "You can't make a omlette.";
            //I can't spell! (But I can hear you).

            dadPhrases = "Nope. I can't remember." +
                "Yes. Have some sweets." +
                "Have some more." +
                "Yeah. No problems." +
                "Have some more sweets." +
                "What." +
                "No, that's fine." +
                "Right. I'm out to do my show." +
                "You can have them now";

            //I might not go back!
            i.Say(dadPhrases); //I'm turning in to my Dad..!

            //My wife is like Marmite.
            //More expensive since Brexit.

            myWife.Says("I'm like a ninja in the bedroom." +
                "In out and out doesn't feel a thing");

            i.Think("Holy shit we might manage the whole show" +
                "without many words");
            //Ha

            //She brought me this bag for my birthday..
            //It made me cross
            //She could tell - because I was pushing that anger deep deep down..!
            // I was cross because I thought she was saying
            // "Things to make me look damn good.." It
            // was empty! Nothing can make you look good...

            //She said "No. You dick"
            //I think you ALREADY look good (weirdo)
            // But we can fix this - let's put things in it...

            //She put 3 bottles on wine in...
            //Apparently that helps!
            //And then (she is funnier than me)...
            //She put this in...
            //She got the size just right!

            //She does :) And we rib each other but love each other.
            //TODO: Leave the above.
            //Might get a blowjob.
            //TODO: Remove that bit..!

            //You are right.
            //But we have had sex.
            //Twice!

            //She has started singing when I get aroused..! WTF
            //It's really offputting..!
            // I LITERALLY NEVER THOUGHT OF THAT..!

            //I really want her to sing the theme tune from Space Oddessy(?)
            //That would help!

            //I closed it! What an idiot.

            myWife.WritesSongs(); // <-- this was her contribution to the show...!
            //She's an ex goth.
            //She is "Vegan-ish"..
            //We eat Vegan at home - but Veggie out.
            //Or Chicken and fish and meat.
            //Lovely lovely meat...!

            //TODO: Remove the above...!



            #endregion

            #region About Me
            //What can I tell you about me...
            i.ProbabilityOfBeingOnTheSpectrum = 8;
            //I asked my wife.
            //She said...
            myWife.Says("You're going to do a show where you stand on stage and program....." +
                "Do. The. Fucking. Maths.");
            //Maths. Not Math. She's not a monster.

            i.DoTheSchoolRun(); //<-- my wife doesn't drive.
            //The other Mum's try to make me feel awkward..
            // They stand around talking about things.
            //Like the other day.
            // Stood in a circle.
            //Talking about vibrators...!
            //I'll be honest - maybe I should have left it in the car..!

            i.Have("2 left feet");
            //Means I'm rubbish at football.
            //But great at stealing shoes.

            i.ReallyWantATattoo = true;//!!!!!
            //I'm not 100% decided yet..
            //So I might get a placeholder image...
            //or some lorem ipsum..
            //Or a chip on my shoulder (I Motorola 68008)

            //That's a good idea!
            //Know anyone who can Henna?
            //Biro will do.
            //If I wasn't wearing my tie...!

            //We've all got those.

            i.Wonder("I don't know what I'm doing with my life anymore!");

            //It's what we're all thinking!

            i.Like("My baths monkey hot");
            //Shit - I spoke.
            //Failed!! :-)

            i.AmNotARealMan = true; //I've started collecting reasons :)

            //I have 386! In a little black book.
            var reason = "Because when my wife and I tried roleplay, it didn't really work." +
                "She dressed as a nurse." +
                "And I dressed as an orc";

            reason = "Because when I saw the trailer for the new startwars films.." +
                "A little bit of wee came out";

            reason = "Because Downton Abbey makes me cry";
            reason = "Because I watch Downton Abbey";

            //Shut up it's good.
            reason = "Because I'd rather sit down to wee";
            //Treat! A rest from the kids. And my life.
            myWife.Says("Why does it take you so long to go to the toilet?");
            i.Say("Dunno. Must be a man thing");

            reason = "I LOVE my Pyjamas." +
                "They have pockets!";
            //Get some!! PJs with pockets are the best thing!

            // 3.!
            //You can make your own jokes - it's saves me typing!
            reason = "My penis." +
                "My penis" +
                "My penis, is below the average size for a male." +
                "Or any other gender";

            reason = "Because I've got a big book of DIY..." +
                "Which I use to press flowers!";

            reason = "Because I play the flute";

            //Just noticed we have 3 minutes left!!!!!
            //Shit.
            //I have about 4 more hours of typing



            #endregion

            #region Conclusions
            //Here are my conclusions
            //Most of my family may or may not be on the spectrum
            //Somewhere.
            //They're fucking awesome.
            //I think - if my daughter _is_ on the spectrum
            //It's just part of who she is.
            //And that is totally cool :-)

            //I think she takes after me :-/
            //So she's in for a rough time!!
            //But ultimately - she will succeed!
            //My other child - may commit murder at some point.
            //We will find a way to hide the bodies.

            mc.Says("That is the end of the show/" +
                "I hope you've enjoyed it as much as Owen clearly enjoying" +
                "dicking about on his computer :-)");

            //THANK YOU SO MUCH!

            TheEnd();

            //Better go check on the kids.!


            #endregion
        }

        private static void TheEnd()
        {
            throw new NotImplementedException();
        }
    }
}
