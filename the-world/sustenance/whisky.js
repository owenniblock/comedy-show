class Whisky {
    // Want to buy me a whisky - get me this one?
    // https://www.thewhiskyexchange.com/p/1481/cragganmore-1981-20-year-old-the-bottlers
    // :-D
    FavouritehWiskyBrands = () => {
        return ["Penderyn", "Glenmorangie", "Cragganmore", "Bunnahabhain"]; //Bourban Cask where possible
    }

    isItDrinkable = () => {
        if (this.isPeaty) {
            return true; //Just about - drink it fast
        }

        if (this.Blended) {
            return this.IsMixedWithSomethingToMakeItTasteNicer;
        }

        if (this.SmoothAndNiceAndLovely) {
            return true;
        }
    }
}