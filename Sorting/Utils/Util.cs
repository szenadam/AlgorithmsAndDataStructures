using System;

namespace Sorting.Utils
{
    public static class Util
    {
        public static void WriteS1L(E1 head)
        {
            var h = head;
            while (h.next != null)
            {
                Console.Write("{0}->", h.key);
                h = h.next;
            }
            Console.WriteLine("{0}\n", h.key);
        }

        public static E1 BuildS1LFromArray(int[] array)
        {

            if (array.Length == 0) return null;
            
            var head = new E1(array[0]);

            var temp = head;

            for (int i = 1; i < array.Length; i++)
            {
                var foo = new E1(array[i]);
                temp.next = foo;
                temp = temp.next;
            }

            return head;
        }
    }
}
