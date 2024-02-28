namespace BlazorAppExemplo1.Models
{
    public class Pessoa
    {
        public string? Nome { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public string? Classificacao { get; set; }

        public double CalcularIMC() //Implementar o cálculo do IMC
        {
            return Peso / (Altura * Altura);        
        }

        public string Classificar() //Implementar a classificação do cálculo de IMC
        {
            if (CalcularIMC() < 18.5)
                return "Abaixo do peso";
            else if (CalcularIMC() < 25)
                return "Peso normal";
            else if (CalcularIMC() < 30)
                return "Sobrepeso";
            else if (CalcularIMC() < 40)
                return "Obesidade";
            else if (CalcularIMC() > 40)
                return "Obesidade grave";

            Classificacao = Classificar();
            return Nome +", você está"+ Classificacao;
        }
    }
}
