using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace media_idade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a idade do primeiro aluno: ");

            int aluno1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a idade do segundo aluno: ");

            int aluno2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a idade do terceiro aluno: ");

            int aluno3 = Convert.ToInt32(Console.ReadLine());

            int media_idade = (aluno1 + aluno2 + aluno3) / 3;

            Console.Write("A média das idades é : " + media_idade);

            Console.ReadKey();

        }
    }
}
