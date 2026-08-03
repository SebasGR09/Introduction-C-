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
        double[] myArrayDouble = new double[] { 2.3, 4.3, 5.2, 3.1 };
        Console.WriteLine($"MyArrayDouble in index 0 is: {myArrayDouble[0]}");





        // Dictionary
        // Son muy similares a los hashmap de java, pero se ponen los tipos en ambos lados
        Dictionary<int, string> myDiccionaryPuellaMagi = new Dictionary<int, string>
        {
            {0, "Madoka" },
            {1, "Homura" },
            {2, "Sayaka" },
            {3, "Kyouko" },
            {4, "Mami" }
        };

        Dictionary<string, int> ola = new Dictionary<string, int>
        {
            {"Sandra", 777 },
            {"Oscar", 248 },
            {"Alejandro", 25 },
            {"Sebas", 109 }

        };
        Console.WriteLine(myDiccionaryPuellaMagi[3]);  // Se busca por key
        ola.Add("Tina", 23);
        ola.Remove("Sebas");
        Console.WriteLine(ola["Tina"]);





        // HashSet, es una estructura (lista) pero desorganizada
        HashSet<int> myHashSet = new HashSet<int>();
        myHashSet.Add(myNumber);
        myHashSet.Remove(myNumber);
        myHashSet.Add(248);

        HashSet<String> myHashString = new HashSet<string> { "ReoNa", "Ado", "Aimer", "Lana9", "MafuMafu" };
        //Console.WriteLine(myHashString[0]); Para acceder a estos datos es mejor usar un foreach





        // Tuples no son inmutables, pero se deben definir sus tipos de datos o nombres desde un principio
        // Por lo que se usa un var cuando deseamos tener una tupla grande con bastantes valores
        // Caso contrario se ponen los tipos de valores con sus nombres entre parentesis

        // Usando var
        var myTuple = (3, 3, "MafuMafu", 3.1, 0, true, myHashString);
        Console.WriteLine($"Tuple with var: {myTuple}");

        // Usando validacion manual ()
        (int, int num2, double num3, string) numbersTupla = (2, 3, 3.14, "Oliwi");
        Console.WriteLine($"Tupla without var: {numbersTupla}");

        Console.WriteLine($"Access with tupla variable (4): {numbersTupla.Item4}");




        // Bucles
        // El for es igual que java, nada cambia
        for(int i = 0; i<=10; i+= 2)
        {
            Console.WriteLine(i);
        }

        // ForEach sirve mucho para recorrer estructuras, todas las anteriormente vistas
        foreach(int item in myArray)
        {
            Console.WriteLine(item);
        }

        foreach(var itemDiccionary in myDiccionaryPuellaMagi)
        {
            Console.WriteLine(itemDiccionary);
        }


        // While, igual que java
        int iterador = 0;
        while (iterador <= 10)
        {
            Console.WriteLine(iterador);
            iterador = Convert.ToInt32(Console.ReadLine());  // Convertir un String a Int

        }


        // Condicionales, varian el flujo del programa. Son iguales que en Java

        // If, else if, else
        if (myHashSet.Count == 0)
        {
            Console.WriteLine("El set esta vacio");
        }
        else 
        {
            Console.WriteLine("El set tiene elementos");
        }



        // Switch, igual que Java
        int day = Convert.ToInt32(Console.ReadLine());
        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2: 
                Console.WriteLine("Tuesday");
                break;
            default:
                Console.WriteLine("Me importa un comino");
                break;
        }



        // Para dejar la consola un ratito
        Console.ReadKey();

        
    }
}