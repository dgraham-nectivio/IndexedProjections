var fruits = new List<string>
{
     "🍌", 
     "🍊", 
     "🍒", 
     "🍎"
};

var evenFruits = fruits
    .Where((item, index) => index % 2 == 0)
    .Select((item, index) => $"{index} - {item}");

foreach (var fruit in evenFruits)
    Console.WriteLine(fruit);