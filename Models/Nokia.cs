namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string Modelo, string IMEI, int Memoria) : base(numero, Modelo, IMEI, Memoria)
        {
            
        }
        
        
        // TODO: Sobrescrever o método "InstalarAplicativo"
        //Impementado!!!
          public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Instalando  " + nomeApp, "no Nokia");
        }
    }
}