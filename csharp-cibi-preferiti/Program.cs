// See https://aka.ms/new-console-template for more information

//inizializzo un array dei cibi preferiti 
string[] cibi = {
    "cotoletta",
    "pasta e fagioli",
    "pasta e patate",
    "parmigiana",
    "lasagna",
};

// Stampa di quanti elementi ci sono in classifica
Console.WriteLine($"All'interno della classifica sono presenti {cibi.Length} cibi!");

// Stampa degli elementi della classifica dal primo all'ultimo
//Esempio con il ciclo for
for ( int i = 0; i < cibi.Length; i++ ) { 
    
    Console.WriteLine(cibi[i] );
}