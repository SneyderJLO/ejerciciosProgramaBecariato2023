string a = "";
int contadorEspacios = 6;
for (int i = 0; i < 6; i++)
{
    a += "#";
    Console.WriteLine(a.PadLeft(contadorEspacios));
}