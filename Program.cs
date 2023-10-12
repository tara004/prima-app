// See https://aka.ms/new-console-template for more information

Auto miaAuto;

miaAuto = new Auto();
miaAuto.stampa();

// eserzio automobile
class Auto
{
    //tipi personallizati
    public enum motore{
        benzina,    //0
        diesel,     //1
        elettrico   //2

    }

    public Auto()
    {
        this.marca = "Fiat";
        this.modello = "Punto";
        this.colore = "Rosso";
        this.tipoMotore = motore.diesel;
    }

    // proprietà
    public string marca;
    public string modello;
    public string colore;
    public motore tipoMotore;
    
    public void stampa() { 
        Console.WriteLine("Marca: "+ this.marca);
        Console.WriteLine("Modello: "+ this.modello);
        Console.WriteLine("Motore: "+ this.tipoMotore);
        Console.WriteLine("Colore: "+ this.colore);
    }
    

    

}


