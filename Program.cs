class Program
{
    static void Main(string[] args)
    {
        // Asi se escribe un comentario

        // Asi se muestra un mensaje por pantalla
        Console.WriteLine("Prubas");


        String message = "Hello World";

        // El tipo de dato por defecto para los decimales es double
        // Por lo que toca hacer casting(f)
        float variableDecimal = 3.1416f;

        Console.WriteLine(variableDecimal);


        // Dynamic, tipo de dato que es tipado dinamico, puede cambiar durante toda la ejecucion del programa
        dynamic myDinamic = 3;
        myDinamic = "Ola mundio";
        Console.WriteLine(myDinamic);


        // Var, es una nueva forma de asignar variables dinamicas, pero no pueden cambiar durante la ejecucion del programa
        // Se quedan con ese mismo tipo de dato desde que se inicializan
        var myString = "Esto es una variable var";
        // myString = 23;  Esto da un error


        // Constantes
        const int myNumber = 212;



        // Colecciones de datos

        // Array, es inmutable y fuertemente tipado
        // Se le puede asignar solo el tamaño
        int[] myArray = new int[3];
        myArray[0] = 248;
        myArray[1] = 123;
        myArray[2] = myNumber;
        Console.WriteLine($"El valor del array int[2] es: {myArray[2]}");


        // Tambien se le puede asignar los datos que tendra de una vez
        double[] myArrayDouble = new double[] {2.3, 4.3, 5.2, 3.1};
        Console.WriteLine($"MyArrayDouble in index 0 is: {myArrayDouble[0]}");







        // Para dejar la consola un ratito
        Console.ReadKey();

        
    }
}