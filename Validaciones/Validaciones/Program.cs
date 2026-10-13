while (true)
{
    Console.WriteLine("subir un mensaje");
    string texto = Console.ReadLine();
    int numero;
    if(int.TryParse(texto, out numero) && numero >= 10)
    {
        Console.WriteLine(numero);
    }

}