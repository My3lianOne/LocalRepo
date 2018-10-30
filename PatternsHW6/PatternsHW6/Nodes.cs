using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsHW6
{
    /// <summary>
    /// Класс-звено "Работник"
    /// </summary>
    public class WorkerNode : Node
    {
        
        public WorkerNode()
        {
        }

        public override void RequestMoney(Request request) { }
        public override void RequestMoney()
        {
            Console.WriteLine();
            Console.WriteLine("РМ РАБОТНИКА");
            Console.WriteLine();
            Request request = CreateRequest();
            nextNode.RequestMoney(request);

            request.Print();
        } 

        /// <summary>
        /// Метод создания запроса на получение средств.
        /// </summary>
        /// <returns>Запрос</returns>
        private Request CreateRequest()
        {
            Console.WriteLine("Введите ФИО:");
            string FIO = Console.ReadLine();

            Console.WriteLine("Введите сумму:");
            double count;
            double.TryParse(Console.ReadLine(), out count);

            Console.WriteLine("Введите назначение:");
            string purpose = Console.ReadLine();

            return new Request(FIO, purpose, count);
        }
    }

    /// <summary>
    /// Класс-звено "Руководитель"
    /// </summary>
    public class ManagerNode : Node
    {
        public ManagerNode(double limit)
        {
            this.limit = limit;
        }
        public override void RequestMoney() { }

        public override void RequestMoney(Request request)
        {
            Console.WriteLine();
            Console.WriteLine("РМ РУКОВОДИТЕЛЯ");
            Console.WriteLine();
            request.Print();
            if (request.Count <= limit)
            {
                Console.WriteLine($"Одобрить выдачу? (да\\нет)");
                if (Console.ReadLine().ToUpper() == "ДА")
                {
                    request.Approve();
                }
                else
                {
                    Console.WriteLine("Укажите причину отказа:");
                    string reason = Console.ReadLine();
                    request.Decline(reason);
                }
            }
            else
            {
                Console.WriteLine("Недостаточно прав на одобрение указанной суммы. Передать на согласование вышестоящему руководству? (да\\нет)");
                if (Console.ReadLine().ToUpper() == "ДА")
                {
                    nextNode.RequestMoney(request);
                }
                else
                {
                    Console.WriteLine("Укажите причину отказа:");
                    string reason = Console.ReadLine();
                    request.Decline(reason);
                }
            }
        }
    }

    /// <summary>
    /// Класс-звено "Директор"
    /// </summary>
    public class DirectorNode : Node
    {
        public DirectorNode( double limit)
        {
            this.limit = limit;
        }

        public override void RequestMoney() { }

        public override void RequestMoney(Request request)
        {
            Console.WriteLine();
            Console.WriteLine("РМ ДИРЕКТОРА");
            Console.WriteLine();
            request.Print();
            Console.WriteLine($"Одобрить выдачу? (да\\нет)");
            if (Console.ReadLine().ToUpper() == "ДА")
            {
                request.Approve();
                Console.WriteLine("Заявка одобрена");
            }
            else
            {
                Console.WriteLine("Укажите причину отказа:");
                string reason = Console.ReadLine();
                request.Decline(reason);
            }
        }
    }
}
