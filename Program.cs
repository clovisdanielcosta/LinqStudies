using LinqStudies;

var deck = new Deck();
var cards = deck.Cards;
var cardsList = deck.CardsList;
var words = new List<string> { "apple", "banana", "orange", "pear" };



var listFilterReverse = cards.Where(c => c.StartsWith("t")).Reverse().ToList();
var listReverseEachWord = cards.Select(c => c.Reverse().ToArray()).ToList();
var listFilterContains = cards.Where(c => c.Contains("in")).ToList();



var orderedByNumber = cardsList.OrderBy(c => c.Position).ToList();
var orderedByNumberThenBy = cardsList.OrderBy(p => p.Position).ThenBy(n => n.Suit).ToList();
var orderedByNumberThenByDescending = cardsList.OrderByDescending(p => p.Position).ThenByDescending(n => n.Suit).ToList();
var orderedByLengthThenByWord = words.OrderBy(w => w.Length).ThenBy(w => w);



var groupedByWordLength = words.GroupBy(word => word.Length);

foreach (var item in groupedByWordLength.OrderBy(o => o.Key))
    foreach (var word in item)
        Console.WriteLine("Lenght: " + item.Key + " | " + word);



var name = "Jones Daniel Celsari";

var ReverseFullName = name.Reverse().ToArray();
Console.WriteLine(ReverseFullName);

var splited = name.Split(" ");


var registers = new Registers().RegisterList;
var totalValue = registers.Sum(t => t.OperationType == 1 ? t.Value: (t.OperationType == 2 ? -t.Value: 0));



var end = "";