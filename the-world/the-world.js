// This is the World. Let's make it!
// What's in the world? We'll decide as we go.
// Probably make some mistakes (like the Platipus)
// But we're in a rush - not long to create the world.
// So we're not going to create unit tests (sorry future devs!)
class TheWorld {
    TheWorldIsBroken = false;
    PeopleInTheWorld = [];

    constructor() {
        this.day1();
        this.day2();
        this.day3();
        this.day4();
        this.day5();
        this.day6();

        if (this.TheWorldIsBroken) {
            this.dayToFixStuffBeforeGoingLive();
        }
    }

    destructor() {
        this = null;
    }

    day1() {
        this.PeopleInTheWorld += new OwenNiblock(null, null); // TODO: Create my Mum and Dad
    }

    day2() {
        this.LandMasses = [
            new Britain(),
            // TODO: Make the rest of the world!
        ]

    }

    day3() {
        
    }

    day4() {
        
    }

    day5() {
        
    }

    day6() {
        
    }

    dayToFixStuffBeforeGoingLive() {
        
    }
}