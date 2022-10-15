Console.WriteLine("Введите 5 целых чисел:");
string? a = Console.ReadLine();
string? b = Console.ReadLine();
string? c = Console.ReadLine();
string? d = Console.ReadLine();
string? e = Console.ReadLine();

int intValue1 = Convert.ToInt32(a);
int intValue2 = Convert.ToInt32(b);
int intValue3 = Convert.ToInt32(c);
int intValue4 = Convert.ToInt32(d);
int intValue5 = Convert.ToInt32(e);
int max = intValue1;

if ( intValue2 > max ) max = intValue2;
if ( intValue3 > max ) max = intValue3;
if ( intValue4 > max ) max = intValue4;
if ( intValue5 > max ) max = intValue5;

Console.WriteLine("Cамое большое число из списка:");
Console.WriteLine(max);
