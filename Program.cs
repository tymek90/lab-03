// Console.Write("Podaj mi liczbe.");
// int liczba =int.Parse(Console.ReadLine());
// if (liczba%2==0)
// {
//     Console.WriteLine("Liczba jest parzysta");
// }
// else
// {
//     Console.WriteLine("Liczba jest nieparzysta.");
// }


// // Console.Write("Podaj mi kierunek wyprawy");
// // string kierunek =(Console.ReadLine());
// // switch(kierunek)
// // {
// //     case "polnoc":  Console.WriteLine("Wyruszasz w strone gor!");
// //                     break;
// //     case "poludnie": Console.WriteLine("Wyruszasz w strone pustni!");
// //                     break;
// //     case "wschod": Console.WriteLine("Wyruszasz w strone lasu!");
// //                     break;
// //     case "zachod": Console.WriteLine("Wyruszasz w strone morza!");
// //                     break;
// //     default: Console.WriteLine("Nie znam tego kierunku.");
// //                     break;
// }    

// Console.Write("Podaj swoj wiek.");
// int wiek =int.Parse(Console.ReadLine());

// if (wiek<0)
// {
//     Console.WriteLine("Niepoprawny wiek.");
// }
// else if (wiek<=12)
// {
//     Console.WriteLine("Jest to dziecko");
// }
// else if (wiek<=17)
// {
//     Console.WriteLine("Jest to nastoltek");
// }
// else if (wiek<=64)
// {
//     Console.WriteLine("Jest to osoba dorosla");
// }
// else
// {
//     Console.WriteLine("Jest to senior");
// }

using System.Reflection.Metadata;

// Console.WriteLine("Ile masz punktow zycia?");
// int punktyZycia =int.Parse(Console.ReadLine());
// Console.WriteLine("Czy bohater ma klucz?");
// bool czyMaKlucz =bool.Parse(Console.ReadLine());
// Console.WriteLine("Czy bohater zna haslo?");
// bool czyZnaHaslo =bool.Parse(Console.ReadLine());
// if(punktyZycia<=0)
// {
//     Console.WriteLine("Nie mozesz wejsc do lochu poniewaz nie zyjesz.");
// }
// else if(czyMaKlucz||czyZnaHaslo)
// {
//     Console.WriteLine("Mozesz wejsc do lochu,poniewaz zyjesz lub masz klucz albo znasz haslo.");
// }
// else
// {
//     Console.WriteLine("Nie mozesz wejsc do lochu,poniewaz nie masz sposobu na otwarcie");
// }

Console.WriteLine("Ile masz aktualnie hp?");
int hp =int.Parse(Console.ReadLine());
Console.WriteLine("Jakie sa podstawowe obrazenia broni?");
int obrazeniaBroni =int.Parse(Console.ReadLine());
Console.WriteLine("Czy bohater ma miksture?");
bool czyMaMiksture =bool.Parse(Console.ReadLine());
Console.WriteLine("Wybierz akcje!");
Console.WriteLine("1-atak!");
Console.WriteLine("2-leczenie!");
Console.WriteLine("3-ucieczka");
int akcja =int.Parse(Console.ReadLine());
if (hp<=0)
{
    Console.WriteLine("Bohater nie zyje,Przegrales!");
}
switch (akcja)
{
    case 1: Console.WriteLine("Bohater zadaje 50 obrazen.");
                break;
    case 2:
    if (czyMaMiksture)
    Console.WriteLine("Bohater sie leczy jesli ma miksture.");
                break;
    case 3: Console.WriteLine("Bohater przeskakuje przez plot i ucieka");
                break;
    default: Console.WriteLine("Nieznana akcja.");
                break;
}

if(hp<20)
{
    Console.WriteLine("Uwaga!Masz niski stan zdrowia.");
}