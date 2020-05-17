// Why don't I need a require here? Magic!
class Wales {
    constructor () {
        // What makes Wales?
        this.sheep = Int32.MaxValue;
        this.peopleWhoLiveThere = [];
        this.peopleWhoLiveThere += new Wife("Jem", "Black", 5.3, "Female");
        // TODO: add more people in Wales
        // So my wife isn't lonely!
        // this.peopleInWales += new Person("")

        this.hasMountains = true;
        this.isStillOnLockdown = true; // Stay at home!
    }

    isGreat = () => {
        return true;
    }

    // Wales is a country the size of Wales.
    sizeOf = () => {
        return new Wales().sizeOf();
    }
}