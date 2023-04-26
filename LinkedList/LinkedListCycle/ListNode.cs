using System.Text;

namespace LinkedList.LinkedListCycle
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            AddToBuilder(builder, this);

            return builder.ToString();
        }

        public void AddToBuilder(StringBuilder builder, ListNode listNode)
        {
            if (listNode.next is null)
            {
                builder.Append($"{listNode.val}");

                return;
            }

            builder.Append($"{listNode.val} ------> ");

            AddToBuilder(builder, listNode.next);
        }
    }
}