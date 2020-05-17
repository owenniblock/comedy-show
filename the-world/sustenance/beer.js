class Beer {
    beerType = ["Home Brew", "Craft", "Lager", "Traditional Ale"];

    //TODO: Make beer prices currency agnostic?
    whatTypeOfBeerIsThis = (beer, location) => {
        if ((beer.price >= 10 & location == "London")
            || (beer.Price >= 4 && location != "London" && beer.IsInACan)) {
            return "Craft";
        }

        // It will put hairs on your chest & a beard on your face (regardless of gender)
        if (beer.Strength > "30%") {
            return "Home Brew";
        }

        //TODO: Consider not having lager in our world...
        if (beer.TastesLikePiss) {
            return "Lager";
        }

        if (beer.TastesLikeTheNectarOfTheGods) {
            return "Traditional Ale";
        }

        throw "This type of beer does not exist in our world"; 
    }
}