namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // DONE: Implementar as propriedades faltantes de acordo com o diagrama
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            // DONE: Passar os parâmetros do construtor para as propriedades
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public static void Ligar()
        {
            Console.WriteLine($"Ligando... Aguarde enquanto carrega as configurações...");
        }

        public static void ReceberLigacao()
        {
            Random random = new();
            Console.WriteLine("Recebendo ligação do número: " + random.Next(980000000, 999999999));
        }

        public abstract void InstalarAplicativo(string nomeApp);

        public abstract void DesinstalarAplicativo(string nomeApp);

    }
}