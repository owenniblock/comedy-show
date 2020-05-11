
// Despite appearances, I actually love this country
// I am merely furstrated by how things are turing out right now
// However, in my adopted home of Wales, I am happy(er)
class Britain {
    constructor () {
        // Build it on slavery and war! :-(
        this.history = "Chequered";
        this.size = QuiteSmall; // Wait? QuiteSmall doesn't exist!

    }

    isGreat = () => {
        // My naming convention is all over the shop
        // TODO: Make this consistent..
        if (this.government.Name == "The Tories") {
            return false;
        }

        if (this.government.Slogan.includes("Stay Alert")) {
            return false;
        }

        if (this.universalCredit != true) {
            return false;
        }

        if (this.thePound == Strong) {
            // We literally don't care
        }

        return true;
    }

    getCountries = () => {
        // NOT "New England" merely a new instance of the England class:
        // Silly me: I had a bug in here where we added new NorthernIreland()
        // However that makes up the United Kingdom not Great Britain
        return [new Wales(), new Scotland(), new England()];
    }

    // TODO: Check if we're actually good at cricket...
    winsAt = () => {
        return [
            "Not Handling Pandemics",
            "Cricket",
            "Making Stodgy Food",
            "Remeniscing", //Even though times were not as good in "the old days"
            "Having a stiff upper lip, chap",
            
        ];
    }

    // TODO: Check if we're actually rubbish at cricket...
    losesAt = () => {
        return [
            "Being sensible",
            "Following the letter of the law", // Rulez matter...
            "Cricket",
            "Treating people fairly",
            "Paying people fairly",
            "Not being racist",
            "Staying in the EU", // :-(
            "Being kind"
        ]
    }
}