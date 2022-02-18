using System;

namespace EsquerdaVolver
{
    internal class Program
    {
        static void Main(string[] args) {
            char[] rosaDosVentos = { 'O', 'N', 'L', 'S' };
            int casoDeTeste, sentido;
            char[] comando;
            while (true) {
                sentido = 1;
                Console.WriteLine("Digite a quantidade de testes que serão feitos(0 encerra o programa): ");
                casoDeTeste = int.Parse(Console.ReadLine());
                if (casoDeTeste == 0)
                    break;
                if (casoDeTeste < 0 || casoDeTeste > 1000) {
                    Console.WriteLine("São aceitos valores entre 1 e 1000");
                    continue;
                }
                Console.WriteLine("Insira os comandos emitidos pelo sargento : ");
                comando = Console.ReadLine().ToCharArray();
                for (int i = 0; i < casoDeTeste; i++) {
                    if (comando[i] == 'E')
                        if (sentido == 0)
                            sentido = 3;
                        else
                            sentido--;
                    else if (comando[i] == 'D')
                        if (sentido == 3)
                            sentido = 0;
                        else
                            sentido++;
                }
                Console.WriteLine(rosaDosVentos[sentido]);
            }
        }
    }
}