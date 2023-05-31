namespace iRh.Windows.Core
{
    public static class Irrf
    {
        public static double Calcula(double SalarioaReceber)
        {
            double DescontoImpostoDeRenda = 0;
            if (SalarioaReceber <= 1903.98)
            {
               
             
            }
            else if(SalarioaReceber <= 2826.65)
            {
                DescontoImpostoDeRenda = (SalarioaReceber / 100) * 7.5 - 142.80;
                return DescontoImpostoDeRenda;
            }
            else if (SalarioaReceber <= 3751.05)
            {
                DescontoImpostoDeRenda = (SalarioaReceber / 100) * 15 - 354.80;
                return DescontoImpostoDeRenda;
            }
            else if (SalarioaReceber <= 4664.68)
            {
                DescontoImpostoDeRenda = (SalarioaReceber / 100) * 22.5 - 636.13;
                return DescontoImpostoDeRenda;
            }
            else if(SalarioaReceber > 4664.68)
            {
                DescontoImpostoDeRenda = (SalarioaReceber / 100) * 27.5 - 869.36;
                return DescontoImpostoDeRenda;
            }
            return DescontoImpostoDeRenda;
        }
    }
}
