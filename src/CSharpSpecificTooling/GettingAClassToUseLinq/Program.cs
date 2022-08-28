using GettingAClassToUseLinq;

var prospect1 = new Prospect("First", Guid.NewGuid());
var prospect2 = new Prospect("Second", Guid.NewGuid());
var prospect3 = new Prospect("Third", Guid.NewGuid());
var prospect4 = new Prospect("Another", Guid.NewGuid());
var prospect5 = new Prospect("Other", Guid.NewGuid());

var prospects = new SortedList<int, Prospect>();

prospects.Add(1, prospect1);
prospects.Add(2, prospect2);
prospects.Add(3, prospect3);
prospects.Add(4, prospect4);
prospects.Add(5, prospect5);

var weekly = new WeeklyTargets()
{
    Prospects = prospects
};

Console.WriteLine("Test of the loop.");
foreach (var p in weekly.Prospects)
{
    Console.WriteLine($"Key: {p.Key}, name: {p.Value.Name}, id: {p.Value.ProspectID}");
}

// Select where prospect name equal "Second";
Console.WriteLine("Test LINQ");

var result = (from p in weekly.Prospects.Values
             where p.Name == "Second"
             select p)
             .First();

Console.WriteLine($"Name: {result.Name}, id: {result.ProspectID}");
