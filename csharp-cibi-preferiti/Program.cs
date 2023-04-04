// See https://aka.ms/new-console-template for more information

//inizializzo un array dei cibi preferiti 
string[] cibi = {
    "pasta e fagioli",
    "cotoletta",
    "pasta e piselli",
    "pasta e patate",
    "parmigiana",
    "lasagna",
    "salsiccia e cime di rapa",
    "gateau",
    "sushi",
    "kebab",
};


// Stampa di quanti elementi ci sono in classifica
Console.WriteLine($"All'interno della classifica sono presenti {cibi.Length} cibi!");
Console.WriteLine("");


// Stampa degli elementi della classifica dal primo all'ultimo
//Esempio con il ciclo for
Console.WriteLine("Stampa con ciclo for");
for ( int i = 0; i < cibi.Length; i++ ) { 
    
    Console.WriteLine(cibi[i] );
}
Console.WriteLine("");

// Esempio con ciclo foreach
Console.WriteLine("Stampa con ciclo foreach");
var n = 0;
foreach ( var i in cibi ) {

    Console.WriteLine($"{n + 1}: {i}");
    n++;
}
Console.WriteLine("");


//Stampa cibo primo in classifica
Console.WriteLine($"Il cibo in primo posizione è : {cibi[0]}");

//Stampa cibo ultimo in classifica
Console.WriteLine($"Il cibo all`ultimo posizione  è : {cibi[9]}");