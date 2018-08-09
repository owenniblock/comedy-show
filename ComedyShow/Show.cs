using System;
using Universe;

namespace ComedyShow
{
    internal class Show
    {
        public Show()
        {
        }

        public DateTime DateAndTime { get; internal set; }
        public string Title { get; internal set; }
        public OwenNiblock Performer { get; internal set; }
        public bool IsFunny { get; internal set; }
        public bool IsGeeky { get; internal set; }
    }
}