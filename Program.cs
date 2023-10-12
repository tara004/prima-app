// See https://aka.ms/new-console-template for more information

Auto miaAuto;

miaAuto = new Auto();
miaAuto.stampaDescrizione();

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
    
    public void stampaDescrizione()
    {
        Console.WriteLine(generaDescrizione());
    }
    public string generaDescrizione() {

        //diciarazione variabili 
        string result;

        //constituisco il risultato le descrizioni 
        result =  "Marca:   " + this.marca;
        result += "\nModello: "+ this.modello;
        result += "\nMotore:  "+ this.tipoMotore;
        result += "\nColore:  "+ this.colore;

        //restituisco il risultato
        return result;
    }
    

    

}


