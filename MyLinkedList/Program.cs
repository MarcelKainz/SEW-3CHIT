using MyList;

MyLinkedList ml = new MyLinkedList();

ml.AddFirst(3);
ml.AddFirst(17);
ml.AddFirst(7);
ml.AddFirst(7);
ml.AddLast(44);

Console.WriteLine(ml);

ml.Remove(7);
Console.WriteLine(ml);

ml.Remove(99);
Console.WriteLine(ml);

ml.AddBefore(44, 55);
Console.WriteLine(ml);

ml.AddAfter(55, 66);
Console.WriteLine(ml);
