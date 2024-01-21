using System.ComponentModel.DataAnnotations.Schema;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // DONE: Implementar as propriedades faltantes de acordo com o diagrama
        private string modelo;
        public string Modelo {
            get { return modelo; }
            set { modelo = value; }
        }
        private string imei;
        public string Imei {
            get { return imei; }
            set { imei = value; }
        }
        private int memoria;
        public int Memoria {
            get { return memoria; }
            set { memoria = value; }
        }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            // DONE: Passar os parâmetros do construtor para as propriedades
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
            Console.WriteLine($"Número: {numero}; Modelo: {modelo}; IMEI {imei}; Mémoria: {memoria}.\n");
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