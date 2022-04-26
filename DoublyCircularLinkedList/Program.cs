namespace DoublyCircularLinkedList
{
    internal class Program
    {
        class CLList
        {
            public static CLList head;
            public String data;
            public CLList next;
            public CLList prev;
            public CLList(String d)
            {
                data = d;
                next = null;
                prev = null;
            }
            public static void rotateRight(int nPositions)
            {
                CLList curr = head;
                for (int i = 0; i < nPositions; i++)
                {
                    curr = curr.prev;
                }
                head = curr;
            }
            public static void rotateLeft(int nPositions)
            {
                CLList curr = head;
                for (int i = 0; i < nPositions; i++)
                {
                    curr = curr.next;
                }
                head = curr;
            }
            public static void AddList(string data)
            {
                CLList newNode = new CLList(data);
                if (head == null)
                {
                    head = newNode;
                    head.next = head;
                    head.prev = head;
                }
                else
                {
                    CLList curr = head;
                    while (curr.next != head)
                    {
                        curr = curr.next;
                    }
                    curr.next = newNode;
                    newNode.prev = curr;
                    newNode.next = head;
                    head.prev = newNode;
                }
            }
            public static void PrintList()
            {
                CLList curr = head;
                string result = "";
                do
                {
                    result += "\"" + curr.data + "\", ";
                    curr = curr.next;
                } while (curr != head);
                Console.WriteLine(result);
            }
        }

        static void Main(string[] args)
        {
            // add A,B,C,D to the list
            CLList.AddList("A");
            CLList.AddList("B");
            CLList.AddList("C");
            CLList.AddList("D");

            CLList.rotateRight(2);
            Console.WriteLine("After rotating right by 2 positions:");
            CLList.PrintList();

            CLList.rotateLeft(2);
            Console.WriteLine("After rotating left by 2 positions:");
            CLList.PrintList();

            CLList.rotateLeft(1);
            Console.WriteLine("After rotating left by 1 positions:");
            CLList.PrintList();

            Console.ReadLine();
        }
    }
}