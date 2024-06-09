string meinname = "philipp";
Console.WriteLine(meinname);

int ganzezahlen = 4;
ganzezahlen++;
Console.WriteLine(ganzezahlen);

void zählbis3()
{
    Console.WriteLine(1);
    Console.WriteLine(2);
    Console.WriteLine(3);
    Console.WriteLine("----");


}

zählbis3();
zählbis3();
zählbis3();

void saghallo(string vorname)
{
    Console.WriteLine("moin " + vorname);
}
saghallo("philipp");

float punktvorstrichrechnung(float number)
{
    float resultat = number + number * 2;
    return resultat;
}
float punktvorstrich = punktvorstrichrechnung(5);
Console.WriteLine(punktvorstrich);


double umfangeineskreises(double radius)
{
    double result = 2 * Math.PI * radius;
    return result;
}

Console.WriteLine(umfangeineskreises(5));


string eingabe = Console.ReadLine();
Console.WriteLine(eingabe + "1");


