class OwenNiblock {
    constructor(mum, dad) {
        this.mum = mum;
        this.dad = dad;

        this.twitter = "https://twitter.com/owenniblock";
        this.youtube = "https://youtube.com/owenniblock";
        this.github = "hittps://github.com/owenniblock/comedy-show"; // Find is within there in /the-world

        this.age = 39;

        this.pets = [
            new Cat("black", "Pippin", "Cheeky"),
            new Cat("black", "Frodo", "Cuddly"),
            new Cat("black", "Beorn", "Hungry"),
            new Mouse("black & white", "Monty"),
            new Hamster("black and white", "Flash", "Speedy"),
            new Hamster("grey and white", "Smokey", "Shy")
        ];

        // TODO: Split this out to a person class
        // She's a person in her own right ((c) Rhod Gilbert)
        this.wife = new Wife("Jem", "Black", 5.3, "Female");

        this.wife.interest = [
            "Learning Spanish",
            "Poirot",
            "Miss Fisher's Murder Mysteries",
            "Sci-Fi",
            "Fantasy",
            "A dark ale",
            "Dark chocolate",
            "Peanut butter", //She's wrong
            "Licorice"
        ];

        this.wife.dislikes = [
            "maybe this?", // She might not like this! (I hope she does)
            "Injustice",
            "People eating apples near her",
            "Inconsistency",
            "Things not being 3s"
        ]

        this.probabilityOfBeingAutistic = 0.6;
        this.probabilityOfBeingOCD = 0.99;
        this.probabilityOfHavingThatOtherThing = 8; //TODO: Write this when you're not so tired Owen...

        let child1 = new Child("First Child", 9,
            ["Harry Potter", "Minecraft", "Ballet", "Mary Potter"], 1, "Female"
        );

        child1.hairColour = "Brown";

        child1.thingsSheSays = [
            "I want doesn't get"
        ];
        

        let child2 = new Child("Second Child", 5,
            ["YouTube", "Eating"], 0.3, "Female"
        );

        child2.thingsSheSays = [
            "No"
        ];

        child2.hairColour = "Red"; // RED!

        this.children = [child1, child2];

        this.idiot = true; // More evidence for this later :)

        this.probabilityOfBeingAutistic = 0.75; // Probably autistic but undiagnosed...

        this.job = "Computer Geek";

        this.manliness = {
            isARealMan: false,
            reasons: [
                "I like a light ale, whilst my wife prefers a stout",
                "I like to sit down to wee",
                "I quite like Hey Duggie",
                "I like poetry",
                "I like fiddly things", // Not genetalia
                "I like singing strange tunes while I'm thinking",
                "I pulled a muscle doing 1 pull up",
                "I had an argument with my wife and I shouted so hard, I put my back out"
            ]
        };

        this.interest = [
            "Sci-Fi",
            "Fantasy",
            "Mechanical Keyboards",
            "Programming",
            "Computers",
            "Dota 2",
            "Comedy",
            "Beer",
            "Whisky",
            "Reading",
            "Cats",
            "Robots",
            "Talking to myself (often in the third person)"
        ];

        this.dislikes = [
            "Physical Contact With Other Human Beings", // Except very close family
            "Injustice",
            "Peanut Butter",
            "isms",
            "Change", // Struggling with lockdown right now
            "Hugs",
        ]
    }    
}