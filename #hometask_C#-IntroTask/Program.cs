// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int[] numbers = { 123, 345, 678, 1111, 1111, 12345, 56789, 123456 };


int m3count = 0;
foreach (int num in numbers)
{
    if (num >= 100 && num <= 999)
    {
        m3count += num;
    }
}
long m4count = 1;
foreach (int num in numbers)
{
    if (num >= 1000 && num <= 9999)
    {
        m4count *= num;
    }
}

int m5count = 0;
foreach (int num in numbers)
{
    if (num >= 10000 && num <= 99999)
    {
        m5count += num;
    }
}

int m6count = 0;
foreach (int num in numbers)
{
    if (num >= 100000 && num <= 999999)
    {
        m6count += num;
    }
}
var result = m3count + m4count + 7 + m5count - (m3count * m3count) + m6count;
result -= (m3count + m4count);
result %= 18;
result %= 3;
result %= 1;
result += m5count;
Console.WriteLine("Cavap:  " + result);