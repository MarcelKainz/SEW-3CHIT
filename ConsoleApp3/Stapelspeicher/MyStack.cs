using System;
using System.Collections;
using System.Collections.Generic;
using Stapelspeicher;

MyIntStack m = new MyIntStack(10);
MyStringStack s = new MyStringStack(3);

m.push(3);
m.push(34);
m.push(99);

Console.WriteLine(m.pop());
Console.WriteLine(m.pop());
Console.WriteLine(m.pop());

s.push("tabudz");
s.push("bah");
s.push("bfahusbeos");

Console.WriteLine(s.pop());
Console.WriteLine(s.pop());
Console.WriteLine(s.pop());

Console.WriteLine("----------------------");

MyGenericStack<string> g1 = new MyGenericStack<string>(3);
g1.Push("asdf");
g1.Push("jklö");
Console.WriteLine(g1.Pop());

Console.WriteLine("----------------------");

MyGenericStack<int> g2 = new MyGenericStack<int>(4);
g2.Push(6);
g2.Push(12);
Console.WriteLine(g2.Pop());

Stack s1 = new Stack(4);
s1.Push(1);
s1.Push(2);
s1.Push(3);
s1.Push(4);
s1.Push(5);
s1.Push(6);
Console.WriteLine(s1.Pop());
Console.WriteLine(s1.Pop());

//Warum das ganze??
//Listen sind dynamische Arrays
List<string> l1 = new List<string>();

l1.Add("asdf");
l1.Add("jklö");
l1.Add("qwertz");
foreach (var item in l1)
    Console.WriteLine("----------");

Console.WriteLine("----------------");

l1.Remove("jklö");
foreach(var item in l1[2])
    Console.WriteLine(item);
Console.WriteLine("--------------------");