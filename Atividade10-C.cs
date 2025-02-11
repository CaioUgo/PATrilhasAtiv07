using System;

class Program
{
    static void Main()
    {
    	Random rand = new Random();	
    	int [,] matriz10 = new int[4, 2];
		int soma = 0;
		
    	for (int i = 0; i < 4; i++) 
    	{
    		for (int j = 0; j < 2; j++) 
    		{
    			matriz10[i, j] = rand.Next(1, 10);
    			Console.Write(matriz10[i, j] + " ");  			
    		}     		
    		Console.WriteLine();	
    	}
    		   	  	
    	for (int i = 0; i < 4; i++) 
    	{
    		for (int j = 0; j < 2; j++) 
    		{
    			soma += matriz10[i, j];
    		}
    	}
    	    	
    	Console.WriteLine("\n\rA soma de todos os elementos da matriz é: {0}", soma);
    	    	
 		Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();    	     	
    }
}
