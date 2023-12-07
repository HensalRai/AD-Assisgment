

namespace Exercise6
{
    internal class Stack<T> : IEnumerable<T>
    {
        private List<T> list = new List<T>();

        public void Push(T item)
        {
            list.Add(item);
        }

        public T Pop()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("Cannot pop from an empty stack.");
            }

            int index = list.Count - 1;
            T item = list[index];
            list.RemoveAt(index);
            return item;
        }

        public T Peek()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException("Cannot peek an empty stack.");
            }

            T topItem = list[list.Count - 1];
            return topItem;
        }

        public bool IsEmpty
        {
            get { return list.Count == 0; }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        static void Main(string[] args)
        {
            Stack<int> intStack = new Stack<int>();

            intStack.Push(5);
            intStack.Push(10);
            intStack.Push(15);

            PrintStack(intStack);

            int poppedItem = intStack.Pop();
            Console.WriteLine($"Popped item: {poppedItem}");

            PrintStack(intStack);

            int topItem = intStack.Peek();
            Console.WriteLine($"Top item: {topItem}");

            bool isEmpty = intStack.IsEmpty();
            Console.WriteLine($"Is the stack empty? {isEmpty}");
        }

        static void PrintStack(Stack<int> stack)
        {
            if (stack.IsEmpty)
            {
                Console.WriteLine("Stack is empty");
                return;
            }

            Console.Write("Remaining items in the stack: ");
            foreach (int item in stack)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}
