
import { Scotland } from "landmass/Scotland";

class Haggis {
    isHaggis = () => {
        // Sheep's heart, liver, and lungs, minced with onion, 
        // oatmeal, suet, spices, and salt, mixed with stock, 
        // and traditionally encased in the animal's stomach and boiled
        return this.containsMeat && this.cookInStomach;
    }

    isTasty = (personEating) => {
        return !personEating.Vegetarian && personEating.DoesNotThinkOfIngredients;
    }

    makesAGoodFootball = false; //It falls appart when you kick it

    countryOfOrigin = new Scotland();
}