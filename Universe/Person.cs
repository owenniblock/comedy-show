using System;
using System.Collections.Generic;
using System.Text;

namespace Universe
{
    public class Person : IPerson
    {
        public string HairColour;
        public int ProbabilityOfBeingAnEvilPhyscho;

        public string Name { get; set; }
        public int? Age { get; set; }
        public byte ProbabilityOfBeingOnTheSpectrum { get; set; }
        public List<string> Skills { get; set; }
        public List<string> Interests { get; set; }
        public string Occupation { get; set; }
        public List<string> Loves { get; set; }
        public string FavouritePlace { get; set; }
        public object HasTatoos { get; set; }
        public bool MadeMeCross { get; set; }
        public bool Drives { get; set; }

        public void Says(string something)
        {

        }

        public void Say(string something) => Says(something);

        public void Thinks(string something)
        {

        }

        public void Think(string something) => Thinks(something);

        public void Wonders(string something)
        {

        }

        public void Wonder(string something) => Wonders(something);

        public void WritesSongs()
        {
            throw new NotImplementedException();
        }

        public void HasOCD()
        {
            throw new NotImplementedException();
        }

        public void Likes(string v)
        {
            throw new NotImplementedException();
        }

        public void OnBarney(string v)
        {
            throw new NotImplementedException();
        }

        public void IsLikeMarmite(string v)
        {
            throw new NotImplementedException();
        }

        public void LovesAFoodFestival()
        {
            throw new NotImplementedException();
        }
    }
}
