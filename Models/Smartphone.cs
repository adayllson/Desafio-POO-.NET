namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama (IMPLEMENTADO!).
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
            // TODO: Passar os parâmetros do construtor para as propriedades (IMPLEMENTADO!).
        }

        public void Ligar()
        {
            Console.WriteLine($"O smartphone de número {Numero}, modelo {Modelo}, IMEI {IMEI} e memória {Memoria} está Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine($" O smartphone de número {Numero}, modelo {Modelo}, IMEI {IMEI} e memória {Memoria} está Recebendo a ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}