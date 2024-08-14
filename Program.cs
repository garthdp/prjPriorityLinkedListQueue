namespace prjPriorityLinkedListQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queues QP = new Queues();
            QPNode qPNode = QP.newNode(4, 1);
            qPNode = QP.push(qPNode, 5, 2);
            qPNode = QP.push(qPNode, 6, 3);
            qPNode = QP.push(qPNode, 7, 4);
            while (QP.isEmpty(qPNode) == 0)
            {
                Console.WriteLine("{0:D} ", QP.peek(qPNode));
                qPNode = QP.pop(qPNode);
            }
        }
    }
}