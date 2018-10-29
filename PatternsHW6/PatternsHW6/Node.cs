using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsHW6
{
    public abstract class Node
    {
        /// <summary>
        /// Лимит на выдачу
        /// </summary>
        protected double limit;

        /// <summary>
        /// Ссылка на следующее звено
        /// </summary>
        protected Node nextNode;
        
        /// <summary>
        /// Метод установки последующего звена
        /// </summary>
        /// <param name="nextNode"></param>
        public void SetNextNode(Node nextNode) =>
                                                  this.nextNode = nextNode;

        /// <summary>
        /// Метод запроса средств
        /// </summary>
        /// <param name="count"></param>
        public void RequestMoney(double count)
        {
            if (!CheckLimit(count))
                if (nextNode != null)
                    nextNode.RequestMoney(count);
        }

        /// <summary>
        /// Метод проверки лимита
        /// </summary>
        /// <param name="count">Запрашиваемая сумма</param>
        /// <returns></returns>
        protected abstract bool CheckLimit(double count);
    }
}
