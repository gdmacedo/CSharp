namespace DesafioPOO.Models
{
    // Herdando da classe "Smartphone"
    public class Iphone : Smartphone
    {
        // Sobrescrevendo o método "InstalarAplicativo"
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo \"{nomeApp}\" no Iphone");
        }
    }
}