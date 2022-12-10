
/// losing points on correctguess, gaining points on incorrect guess, not ending game when N is input

class Hilo
{
    static void Main(string[] args)
    {

    var one = new Cards(1);
    var two = new Cards(2);
    var three = new Cards(3);
    var four = new Cards(4);
    var five = new Cards(5);
    var six = new Cards(6);
    var seven = new Cards(7);
    var eight = new Cards(8);
    var nine = new Cards(9);
    var ten = new Cards(10);
    var eleven = new Cards(11);
    var twelve = new Cards(12);
    var thirteen = new Cards(13);

    Dictionary<int,Cards> Deck = new Dictionary <int,Cards>();
    Deck.Add(1, one);
    Deck.Add(2, two);
    Deck.Add(3, three);
    Deck.Add(4, four);
    Deck.Add(5, five);
    Deck.Add(6, six);
    Deck.Add(7, seven);
    Deck.Add(8, eight);
    Deck.Add(9, nine);
    Deck.Add(10, ten);
    Deck.Add(11, eleven);
    Deck.Add(12, twelve);
    Deck.Add(13, thirteen);

    // List<Cards>cardList = (Deck);

        int score = 300;
        while (score > 0)
        {   
            int currentCard = Current(Deck); 
                Console.WriteLine("The card is: " + currentCard);
                Console.WriteLine("Higher of lower? [h/l]");
            string playerGuess = Console.ReadLine();
            int nextCard = Next(Deck);
                Console.WriteLine("Next card was: " + nextCard);
            int currentScore = Compute(playerGuess, nextCard, currentCard, score);
                Console.WriteLine("Your score is: " + currentScore);
            score = Continue(currentScore);        
        }
    }

    static int Current(Dictionary<int,Cards> Deck) {
        Random random = new Random();
        int currentCard = random.Next(Deck.Count);
        return currentCard;
    }
    static int Next(Dictionary<int,Cards> Deck) {
        Random random = new Random();
        int nextCard = random.Next(Deck.Count);
        return nextCard;
    }
    static int Compute(string playerGuess, int nextCard, int currentCard, int score) {
            if (nextCard > currentCard && playerGuess == "h" || nextCard < currentCard && playerGuess == "l") {
                int currentScore = score + 100;
                return currentScore;
            }
            else {
                int currentScore = score - 75;
                return currentScore;
            }
    }
    static int GameOver(int currentScore) {
        if (currentScore <= 0 ) {
            int score = 0;
            return score;
        }
        else {
            int score = currentScore;
            return score;
        }
    }
    static int Continue(int currentScore) {
        if (currentScore > 0){
            Console.WriteLine("Play again? [y/n] ");
            string decision = Console.ReadLine();
            if (decision == "n") {
                int score = currentScore - currentScore;
                Console.WriteLine("Thanks for Playing.");
                return score;
            }
            else {
            int score = currentScore - 0;
            return score;
            }
        }
        else {
            int score = currentScore;
            Console.WriteLine("Thanks for Playing.");
            return score;
        }
    }
    
}

class Cards {
    public int number;
    public Cards (int number) {
    this.number = number; 
    }
}