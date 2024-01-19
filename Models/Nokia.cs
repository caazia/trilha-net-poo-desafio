namespace DesafioPOO.Models
{
    // DONE: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }

        // DONE: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} em seu Nokia.");
        }

        public override void DesinstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Desinstalando o aplicativo {nomeApp} em seu Nokia.");
        }



    }
}