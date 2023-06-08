namespace iRh.Windows.Core
{
    public static class Periculosidade
    {
        public static double Calcula(double salario, double horasPericulosidade) 
        {
            double adicionalPericulosidade = 0;
            adicionalPericulosidade = (salario / 200) * 0.30 * horasPericulosidade;

            return adicionalPericulosidade;
        }
    }
}
