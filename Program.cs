//Linked-List 
using LinkedList;

LinkList list = new LinkList();

list.InsertFirst(1);
list.InsertFirst(2);
list.InsertFirst(3);
list.InsertLast(4);
list.InsertAfter(4, 9);
list.InsertBefore(9, 10);
list.DeleteFirst();
list.DeleteLast();
list.DisplayList();