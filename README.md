# cs-con-dictionary

```cs
Dictionary<string, string> openWith1 = new();

openWith1.Add("txt", "notepad.exe");
openWith1.Add("bmp", "paint.exe");
openWith1.Add("dib", "paint.exe");
openWith1.Add("rtf", "wordpad.exe");

var openWith2 = new Dictionary<string, string>();

openWith2.Add(".txt", "notepad");
openWith2.Add(".bmp", "paint");
openWith2.Add(".dib", "paint");
openWith2.Add(".rtf", "wordpad");

foreach (var pair in openWith1)
{
    Console.WriteLine( $"KEY:{pair.Key} => VALUE:{pair.Value}" );
    Console.WriteLine( $"KEY:{pair.Key} => VALUE:{openWith1[pair.Key]}" );
}

var keyColl = openWith2.Keys;

foreach (var key in keyColl )
{
    Console.WriteLine( $"KEY:{key} => VALUE:{openWith2[key]}" );
}

var valueColl = openWith2.Values;

foreach (var value in valueColl )
{
    Console.WriteLine( $"VALUE:{value}" );
}

// 配列化 : 要 System.Linq
var arr = openWith1.Keys.ToArray();

// Length
for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine( $"KEY:{arr[i]}" );
}

// List化 : 要 System.Linq
var list = openWith1.Values.ToList();

foreach (var value in list)
{
    Console.WriteLine( $"VALUE:{value}" );
}

// Count
for (int i = 0; i < list.Count; i++)
{
    Console.WriteLine( $"VALUE:{list[i]}" );
}
```
