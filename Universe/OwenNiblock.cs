using System;

namespace Universe
{
    public class OwenNiblock : Niblock, IPerson
    {
        public string Name { get => "Owen Niblock"; }
        public int? Age { get => 37; }
        //TODO: Work this out:
        public byte ProbabilityOrBeingOnTheSpectrum { get => 0; }
    }
}
