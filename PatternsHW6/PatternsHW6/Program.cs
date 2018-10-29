using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsHW6
{
    class Program
    {
        private static Node GetChainOfNodes()
        {
            // Создаем звенья
            var workerNode = new WorkerNode();
            var managerNode = new ManagerNode(2500);
            var directorNode = new DirectorNode(10000);

            // Устанавливаем цепь
            workerNode.SetNextNode(managerNode);
            managerNode.SetNextNode(directorNode);

            return workerNode;
        }

        static void Main(string[] args)
        {
            Node nodes = GetChainOfNodes();
        
            nodes.RequestMoney();
            Console.ReadKey();
        }
    }
}
