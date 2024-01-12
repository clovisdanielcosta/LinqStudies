
namespace LinqStudies;

public class Deck
{
    public List<string> Cards { get; set; }

    public List<Card> CardsList { get; set; }

    public List<(int, string)> TupleCards { get; set; }

    public Deck()
    {
        Cards = new List<string>
                {
                    "two",
                    "three",
                    "four",
                    "five",
                    "six",
                    "seven",
                    "eight",
                    "nine",
                    "ten",
                    "jack",
                    "queen",
                    "king",
                    "ace"
                };

        CardsList = new List<Card>
                     {
                         new( 2, "two" ),
                         new( 3, "three"),
                         new( 4, "four"),
                         new( 5, "five"),
                         new( 4, "six"),
                         new( 7, "seven"),
                         new( 4, "eight"),
                         new( 9, "nine"),
                         new( 10, "ten"),
                         new( 10, "jack"),
                         new( 12, "queen"),
                         new( 13, "king"),
                         new( 1, "ace")
                     };

        TupleCards = new List<(int, string)>
                     {
                         ( 2, "two" ),
                         ( 3, "three"),
                         ( 4, "four"),
                         ( 5, "five"),
                         ( 4, "six"),
                         ( 7, "seven"),
                         ( 4, "eight"),
                         ( 9, "nine"),
                         ( 10, "ten"),
                         ( 10, "jack"),
                         ( 12, "queen"),
                         ( 13, "king"),
                         ( 1, "ace")
                     };
    }
}