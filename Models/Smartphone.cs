namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }
        // DONE: Implementar as propriedades faltantes de acordo com o diagrama

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
            // DONE: Passar os parâmetros do construtor para as propriedades
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando... Aguarde enquanto carrega as configurações...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine($"Recebendo ligação do número: 980000000.");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}