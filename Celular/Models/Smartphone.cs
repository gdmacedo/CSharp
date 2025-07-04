namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        protected Smartphone(string numero, string modelo, string imei, int memoria)
        {
            // Passando os parâmetros do construtor para as propriedades
            nNumero = numero;
            cModelo = modelo;
            nIMEI = imei;
            nMemoria = memoria;
        }

        // Implementando as propriedades faltantes de acordo com o diagrama
        public string nNumero { get; set; }
        private string cModelo { get; set; }
        private string nIMEI { get; set; }
        private int nMemoria { get; set; }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}