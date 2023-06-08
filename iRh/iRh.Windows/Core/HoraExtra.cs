namespace iRh.Windows.Core
{
    public static  class HoraExtra
    {
        public static double Calcula(double salario, double HorasFeitas)
        {
            var valorHoraTrabalhada = salario / 200;
            var valorHoraExtra = valorHoraTrabalhada * 0.20;
            var totalReceber = (valorHoraExtra + valorHoraTrabalhada) * HorasFeitas;
            return totalReceber;

        }
    }
}
