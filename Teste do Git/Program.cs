using System;


try 
{
    Console.Write("Informe um valor: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Informe um valor: ");
    int b = Convert.ToInt32(Console.ReadLine());
    int rt = a / b;
    Console.WriteLine($"O resultado da divisão é: {rt}");
}
catch(DivideByZeroException ex)
{
    Console.WriteLine($"\nDvisão por zero é invalido!\n{ex.Message} - Menssagem de erro");
}
catch(InvalidCastException ex)
{
    Console.WriteLine($"\nDvisão por letra é invalida, não se pode converte letra em número!\n{ex.Message} - Menssagem de erro");
}
catch(Exception ex)
{
    Console.WriteLine($"\nOcorreu algum erro!\n{ex.Message} - Menssagem de erro");
}

