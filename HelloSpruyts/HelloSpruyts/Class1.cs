using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloSpruyts
{
    internal abstract  class Class1
    {
        private static string[] placeHolderGloats = new string[]
          { "This is a test",
              "I have nothing to say ",
              "Speechless simply speechless" };
        private static string[] rockGloats = new string[]
       { "Nooooo! A rock is smashing my lovely scissors!",
           "Hmm! I chose rock too. So i guess we all win, how lovely", "Ha! Rock! I always choose PAPER!" };
        private static string[] paperGloats = new string[]
       { "Wretched paper is suffocating my beautiful rock, you fiend",
           "It's rather dull if we both choose paper,don't you think? Draw.",
           "Ha! Paper! Don't you know it's SCISSORS! Snip! Snip! Snip!" };
        private static string[] scissorsGloats = new string[]
       { "No, please that's my favourite piece of paper!",
           "Oh right. You want scissors too? OK a draw I guess. Boring", "Ha! Scissors!  Obviously ROCK!" };
        private static string[] ddtGloats = new string[]
       { "What is D D T anyway sounds fake",
           "draw draw", "The Stockholm Convention on Persistent Organic Pollutants, which took effect in 2004 put a global ban on several persistent organic pollutants, and restricted DDT use to vector control." };
        private static string[] humanityGloats = new string[]
       { "Wretched paper is suffocating my beautiful rock, you fiend",
           "It's rather dull if we both choose paper,don't you think? Draw.",
           "Ha! Paper! Don't you know it's SCISSORS! Snip! Snip! Snip!" };
        private static string[] mosquitoGloats = new string[]
       { "No, please that's my favourite piece of paper!",
           "Oh right. You want scissors too? OK a draw I guess. Boring", "Ha! Scissors!  Obviously ROCK!" };

        
        //public Thingy(String Name, String Beats, int BeatsPic, String Verb, string[] Incidental
        private static Thingy rock = new Thingy("Rock", "Scissors", "ms-appx:///Assets/beatsrock.JPG", "smashes", rockGloats);
        private static Thingy paper = new Thingy("Paper", "Rock", "ms-appx:///Assets/cutspaper.JPG", "wraps", paperGloats);
        private static Thingy scissors = new Thingy("Scissors", "Paper", "ms-appx:///Assets/smashesscisors.JPG", "cut", scissorsGloats);

        private static Thingy monkey = new Thingy("Monkey", "Banana", "ms-appx:///Assets/beatsmonkey.JPG", "eats", placeHolderGloats);
        private static Thingy clown = new Thingy("Clown", "Monkey", "ms-appx:///Assets/slipsclown.JPG", "shoots", placeHolderGloats);
        private static Thingy banana = new Thingy("Banana", "Clown", "ms-appx:///Assets/eatsbanana.jpg", "slips up", placeHolderGloats);

        private static Thingy knife = new Thingy("Knife", "Fork", "ms-appx:///Assets/beatsknife.JPG", "stabs", placeHolderGloats);
        private static Thingy spoon = new Thingy("Spoon", "Knife", "ms-appx:///Assets/beatsspoon.JPG", "reflects and shrinks", placeHolderGloats);
        private static Thingy fork = new Thingy("Fork", "Spoon", "ms-appx:///Assets/beatsfork.JPG", "forks", placeHolderGloats);

        private static Thingy humanity = new Thingy("Humanity", "DDT", "ms-appx:///Assets/beatshumanity.png", "outlaws", placeHolderGloats);
        private static Thingy mosquito = new Thingy("Mosquito", "Humanity", "ms-appx:///Assets/beastmosquito.png", "plagues", placeHolderGloats);
        private static Thingy ddt = new Thingy("DDT", "Mosquito", "ms-appx:///Assets/beatsddt.png", "exterminates", ddtGloats);

        private static Thingy fire = new Thingy("Fire", "Air", "ms-appx:///Assets/beatsfire2.png", "consumes", placeHolderGloats);
        private static Thingy water = new Thingy("Water", "Fire", "ms-appx:///Assets/beatswater.png", "extinguishes", placeHolderGloats);
        private static Thingy air = new Thingy("Air", "Water", "ms-appx:///Assets/beatsair.png", "evaporates", placeHolderGloats);

        private static Thingy slug = new Thingy("Slug", "Snake", "ms-appx:///Assets/beatslug2.png", "slimes", placeHolderGloats);
        private static Thingy frog = new Thingy("Frog", "Slug", "ms-appx:///Assets/beatsfrog.png", "tongue-grabs", placeHolderGloats);
        private static Thingy snake = new Thingy("Snake", "Frog", "ms-appx:///Assets/beatsssnake.jpg", "swallows whole", placeHolderGloats);

        private static Thingy fox = new Thingy("Fox", "Chief", "ms-appx:///Assets/beatsfox.png", "outsmarts", placeHolderGloats);
        private static Thingy hunter = new Thingy("Hunter", "Fox", "ms-appx:///Assets/beatshunter.png", "guts", placeHolderGloats);
        private static Thingy chief = new Thingy("Chief", "Hunter", "ms-appx:///Assets/beatschief.png,", "banishes", placeHolderGloats);

        private static Thingy red = new Thingy("Red", "Yellow", "ms-appx:///Assets/beatsred.png", "is more dangerous than", placeHolderGloats);
        private static Thingy blue = new Thingy("Blue", "Red", "ms-appx:///Assets/beatsblue.png", "depresses", placeHolderGloats);
        private static Thingy yellow = new Thingy("Yellow", "Blue", "ms-appx:///Assets/beatsyellow.png", "greens up", placeHolderGloats);



        private static Thingy beer = new Thingy("Beer", "Spirits", "ms-appx:///Assets/beatsbeer.jpg", "raises", placeHolderGloats);
        private static Thingy wines = new Thingy("Wines", "Beer", "ms-appx:///Assets/beatswine.JPG", "make you feel queer after", placeHolderGloats);
        private static Thingy spirits = new Thingy("Spirits", "Wines", "ms-appx:///Assets/beatsspirits.png", "are stronger than", placeHolderGloats);

        private static Thingy mummy = new Thingy("Mummy", "Baby", "ms-appx:///Assets/oppressesmummy.png", "takes care of", placeHolderGloats);
        private static Thingy daddy = new Thingy("Daddy", "Mummy", "ms-appx:///Assets/beatsdaddy.jpg", "oppresses", placeHolderGloats);
        private static Thingy baby = new Thingy("Baby", "Daddy", "ms-appx:///Assets/looksafterbaby,jpg", "outscreams", placeHolderGloats);

        private static Thingy plants = new Thingy("Plants", "Funghi", "ms-appx:///Assets/beatsplants.JPG", "are prettier than", placeHolderGloats);
        private static Thingy animals = new Thingy("Animals", "Plants", "ms-appx:///Assets/beats_animal.JPG", "eat", placeHolderGloats);
        private static Thingy funghi = new Thingy("Fungi", "Animals", "ms-appx:///Assets/beats_fungi.JPG", "decompose", placeHolderGloats);

        public static Thingy[] ALL_THINGS = new Thingy[]{rock, paper, scissors, humanity, mosquito, ddt,mummy,daddy,baby, monkey, clown, banana,plants,animals,funghi,red,blue,yellow, knife,
            spoon, fork, slug, frog, snake, beer, wines, spirits, fire, water, air, fox, hunter, chief};



    }
}
