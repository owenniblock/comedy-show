class Scotland {
    constructor () {
        // TODO: Britain's `isgGreat` is a function, whereas this is a property
        // Make them the same sort of this?
        this.isGreat = true;

        this.peopleWhoLiveThere = [];
        this.peopleWhoLiveThere += new Person("Alan", "Black", 5.8, "Male");
        this.peopleWhoLiveThere += new Person("Lisa", "Black", 5.8, "Female"); // Hi!
        this.peopleWhoLiveThere += new Person("Nicola Sturgeon", "Brown", 5.35, "Female"); // Thanks Google!
        // I am not going add every single person I know in Scotland
        // Some of them are twats :-D (I don't mean that!)
        // It will take too long - but I love you all!
    }

    // sizeOf returns a number in the metric os Waleses:
    sizeOf = () => {
        let sizeOfScotlandSqM = 30918;
        let sizeOfWalesSqm = 8005.8;

        return sizeOfScotlandSqM / sizeOfWalesSqm;
    }
}