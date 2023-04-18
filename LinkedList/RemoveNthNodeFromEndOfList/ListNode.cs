using System.Text;

namespace LinkedList.RemoveNthNodeFromEndOfList
{
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
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