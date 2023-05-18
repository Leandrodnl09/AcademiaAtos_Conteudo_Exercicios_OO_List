namespace AcaademiaAtos_Conteudo02_Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMotor motor; // interface

            // MotorEletrico me = new MotorEletrico();

            Console.WriteLine("Aperte 1 para ligar motor eletrico ou 2 para ligar motor a combustão!");
            int op = int.Parse(Console.ReadLine()); 

            if (op == 1)
            {
                motor = new MotorEletrico(); // usando interface
                motor.Ligar();

                motor.Desligar();
            }
            else if (op == 2)
            {
                motor = new MotorCombustao();
                motor.Ligar();

                motor.Desligar();
            }
        }
    }
}