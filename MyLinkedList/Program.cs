using MyList;

MyLinkedList ml = new MyLinkedList();
ml.AddFirst(17);
ml.AddFirst(7);
ml.AddFirst(3);

ml.Remove(3);
ml.Remove(7);
ml.Remove(17);

Console.WriteLine(ml);

