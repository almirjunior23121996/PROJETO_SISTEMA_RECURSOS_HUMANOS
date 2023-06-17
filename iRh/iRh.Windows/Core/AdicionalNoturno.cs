namespace iRh.Windows.Core
{
    public static class AdicionalNoturno//terceiro passo 
    {
        const double HORAS_DE_TRABALHO = 220.0;
        public static double Calcula(double salarioValorEmConta, double HorasNoturnasFeitas)//quarto passo 
        {
            var valor_por_hora = salarioValorEmConta / HORAS_DE_TRABALHO;
            var valor_do_adicional = valor_por_hora * 0.20;
            var salario_com_adicional = (valor_por_hora + valor_do_adicional) * HorasNoturnasFeitas;
            return salario_com_adicional;//quinto passo
        }
    }
}
