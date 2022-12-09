


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

    var Deck = new Dictionary <string,Cards>();
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

    List<Cards>cardList = cards(Cards);

        while (!GameOver(deck))
        {   
            int currentCard = Current(cardList<Cards> carList); 
                Console.WriteLine("The card is: " + currentCard);
            string playerguess = Console.ReadLine("Higher of lower? [h/l] ");
            int nextCard = Next(cardList<Cards> cardList);
                Console.WriteLine("Next card was: " + nextCard);
            string currentScore = Action(cardList<Cards> cardList);
                Console.WriteLine("Your score is: " + currentScore);
            bool gameState = GameOver(deck);
            string decision = Continue();        
        }
    }


    static int Current(List<Cards> cardList) {
        Random random = new Random();
        int currentCard = random.Next(cardList);
        return currentCard;
    }
    static int Next(List<Cards> cardList) {
        Random random = new Random();
        int nextCard = random.Next(cardList);
        return nextCard;

        if (nextCard = currentCard);
            Random random = new random();
            int nextCard = random.Next(cardList);
            return nextCard;
    }
    static string Action(List<Cards> cardList) {
            currentScore = 300;
            if (nextCard > currentCard && playerGuess = "h") {
                currentScore + 100;
                return currentScore;
            }
            if (nextCard < currentCard && playerGuess = "l") {
                currentScore - 75;
                return currentScore;
            }
            else {
                Console.WriteLine("Invalid Guess, try again"); 
            }
    }

    static bool GameOver() {
        bool gameState = false;
        if (score <= 0 ) {
            gameState = true;
        }
        return gameState;
    }

    static string Continue() {
        string decision = Console.ReadLine("Play again? [y/n]");
        if (decision = "n") {
            CurrentScore = 0;
            return decision;
        }
        if (decision = "y") {
            return decision;
        }
        else {
            Console.WriteLine("Invalid Choice");
        }
    }
}

class Cards {
    public int number;
    public Cards (int number) {
    this.number = number; 
    }
}