using System;

class Program
{
    static void Main()
    {
    	decimal soma = 0;
    	decimal media = 0;
    	Random rand = new Random();	
    	decimal [,] matrizdecimal = new decimal [2, 2] {
    		{1.2m, 2.3m},
    		{3.1m, 2.1m} 		
    	};
    	
    	Console.WriteLine("MATRIZ COMPLETA   ");
    	for (int i = 0; i < 2; i++) 
    	{
    		for (int j = 0; j < 2; j++) 
    		{
    			Console.Write(matrizdecimal[i, j] + " |");
    		}
    		Console.WriteLine();
    	}
  
    	Console.WriteLine("\n\rA média dos números da matriz é: ");
    	
    	for (int i = 0; i < 2; i++)
    	{
    		for (int j = 0; j < 2; j++) 
    		{
    			soma += matrizdecimal[i, j];
    			media = soma / 4;
    		}
    	}
      	
    	Console.WriteLine(media);	
 		Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();    	    	
    }
}
