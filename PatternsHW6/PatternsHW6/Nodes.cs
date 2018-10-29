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
        
        public WorkerNode(double limit)
        {
            this.limit = limit;
        }

        protected override bool CheckLimit(double count)
        {
            Console.WriteLine("Требуется одобрение выдачи запрашиваемой суммы руководителем");
            return false;
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

        protected override bool CheckLimit(double count)
        {
            if (count <= limit)
            {
                Console.WriteLine("Выдача запрашиваемой суммы одобрена.");
                return true;
            }
            Console.WriteLine("Требуется одобрение выдачи запрашиваемой суммы директором.");
            return false;
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

        protected override bool CheckLimit(double count)
        {
            if (count <= limit)
            {
                Console.WriteLine("Выдача запрашиваемой суммы одобрена.");
                return true;
            }
            Console.WriteLine("Превышен допустимый лимит. В выдаче средств отказано.");
            return false;
        }
    }
}
