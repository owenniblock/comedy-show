using System.Collections.Generic;

namespace Universe
{
    public interface IPerson
    {
        string Name { get; set; }
        int? Age { get; set; }
        byte ProbabilityOfBeingOnTheSpectrum { get; set; }
        List<string> Skills { get; set; }
        List<string> Interests { get; set; }
        string Occupation { get; set; }
        void Says(string something);
        void Say(string something);
        void Thinks(string something);
        void Think(string something);
    }
}