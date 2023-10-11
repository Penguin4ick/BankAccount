using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class BankAccount
    {
        private int nom;
        private string name;
        private float sum;

        public void otk()
        {
            Console.WriteLine("Введите номер счета: ");
            this.nom = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите Ваше прекрасное имя: ");
            this.name = Console.ReadLine();
            Console.WriteLine("Введите сумму: ");
            this.sum = float.Parse(Console.ReadLine());
        }
        public void Out()
        {
            Console.WriteLine("Номер счета: " + nom);
            Console.WriteLine("ФИО: " + name);
            Console.WriteLine("Сумма на счету" + sum);
        }
        public void dob(float sum)
        {
            Console.WriteLine("Вы добавили на счет " + sum);
            this.sum += sum;
            Console.WriteLine($"Ваш остаток на счете: {this.sum}");
        }
        public void umen(float sum)
        {
            Console.WriteLine("Вы сняли со счета " + sum);
            this.sum -= sum;
            Console.WriteLine($"Ваш баланс: {this.sum}");
        }
        public void obnul()
        {
            Console.WriteLine("Вы сняли со счёта всю сумму");
            Console.WriteLine("Было снято: " + this.sum);
            sum = 0;
        }
             public void transfer(float money)
        {
            Console.WriteLine($"Вы успешно перевели {money} на другой счёт");
            if (sum < 0)
            {
                Console.WriteLine("Благодарим вас за использование услуги оведрафт");
            }

        }

    }
}
