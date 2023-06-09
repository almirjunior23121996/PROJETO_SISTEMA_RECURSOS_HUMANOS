using System.Runtime.InteropServices;

namespace iRh.Windows.Core
{
    
    public static  class Inss
    {
        
        public static double Calcula(double salario)
        {
            double valorDoDesconto = 0.0;
            double calculoDoInposto;
            if (salario <= 1302.0) 
            {
                calculoDoInposto = (salario / 100) * 7.5;
                valorDoDesconto = calculoDoInposto + valorDoDesconto;
                return valorDoDesconto;
                
            }
            if(salario < 2571.29) 
            {
                valorDoDesconto = 97.65;
                calculoDoInposto = ((salario - 1302.01) / 100) * 9;
                valorDoDesconto = calculoDoInposto + valorDoDesconto;
                return valorDoDesconto;
            }
            if(salario < 3856.94 || salario < 5507.49) 
            {
                valorDoDesconto = 97.65 + 114.23;
                calculoDoInposto = ((salario - 2571.30) / 100) * 12;
                valorDoDesconto = calculoDoInposto + valorDoDesconto;
                return valorDoDesconto;
            }
            if (salario > 7507.49)
            {
                valorDoDesconto = 97.65 + 114.24 + 154.28;
                calculoDoInposto = ((7507.49 - 3856.95) / 100) * 14;
                valorDoDesconto = calculoDoInposto + valorDoDesconto;
                return valorDoDesconto;
            }
            return valorDoDesconto;
            

        }
          

           

     
    }
}
