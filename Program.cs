var cartas = new List<string>
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

var listaCartas = new List<Carta>
{
    new Carta( 2, "two" ),
    new Carta( 3, "three" ),
    new Carta( 4, "four" ),
    new Carta( 5, "five" ),
    new Carta( 4, "six" ),
    new Carta( 7, "seven" ),
    new Carta( 4, "eight" ),
    new Carta( 9, "nine" ),
    new Carta( 10, "ten" ),
    new Carta( 10, "jack" ),
    new Carta( 12, "queen" ),
    new Carta( 13, "king" ),
    new Carta( 1, "ace" ),
};

var orderByNumber = listaCartas.OrderBy(c => c.Posicao).ToList();
Print(orderByNumber);       

var orderByNumberThenBy = listaCartas.OrderBy(p => p.Posicao).ThenBy(n => n.Naippe).ToList();
Print(orderByNumberThenBy);     

var orderByNumberThenByDescending = listaCartas.OrderByDescending(p => p.Posicao).ThenByDescending(n => n.Naippe).ToList();
Print(orderByNumberThenByDescending);        

var inversaoLista = cartas.Where(c => c.StartsWith("t")).Reverse().ToList();
Print(inversaoLista);

var inversaoPalavrasNaLista = cartas.Select(c => c.Reverse().ToArray()).ToList();
foreach (var item in inversaoPalavrasNaLista) Console.WriteLine(item);
Console.WriteLine("----------");
Print(inversaoPalavrasNaLista);

var contains = cartas.Where(c => c.Contains("in")).ToList();
Print(contains);


var words = new List<string> { "apple", "banana", "orange", "pear" };
Print(words);

var sortedWords = words.OrderBy(w => w.Length).ThenBy(w => w);
Print(sortedWords);        

var groupedWords = words.GroupBy(word => word.Length);

foreach (var item in groupedWords.OrderBy(o => o.Key))
    foreach (var word in item)
    {
        Console.WriteLine("Lenght: " + item.Key + " | " + word);
    }

var nomeCompletoInvertido = "Clovis Daniel Costa".Select(n => n).Reverse().ToArray();
Console.WriteLine(nomeCompletoInvertido);

var b = "";

void Print(IEnumerable<object> obj)
{
    foreach (var item in obj)
        Console.WriteLine(item);

    Console.WriteLine(" ----------------");
}

public record Carta(int Posicao, string Naippe);