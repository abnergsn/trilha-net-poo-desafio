namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        
        public Iphone(string numero, string Modelo, string IMEI, int Memoria) : base(numero, Modelo, IMEI, Memoria)
        {
            
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
        // Implementado!!!
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Instalando  " + nomeApp, "no Iphone");
        }

    }
}