using System;
using System.Collections.Generic;
using System.Text;

namespace Comedy
{
    public class Audience : List<AudienceMember>
    {
        public bool WalkingIn { get; set; }
    }
}
