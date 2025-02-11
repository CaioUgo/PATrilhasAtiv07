using System;

class Program
{
    static void Main()
    {
    	int [,] inteiros = new int[3, 3];
    	
    	
    	for (int i = 0; i < 3; i++)
    	{
    		for (int j = 0; j < 3; j++)
    		{
    			Console.WriteLine("Digite o elemento da linha {0} e coluna {1}: ", i, j );
    			inteiros[i, j]= int.Parse(Console.ReadLine());
    			
   			} 	
    	}
    	
    	Console.Clear();
    	Console.WriteLine("ELEMENTOS DA MATRIZ");
    	Console.WriteLine();
    	
 		for (int i = 0; i < 3; i++)
    	{
    		for (int j = 0; j < 3; j++)
    		{
    			Console.Write(inteiros[i, j] + " ");
    		}
    	
    		Console.WriteLine();
    	}   	
        
 		Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();    	 
    	
    }
}
