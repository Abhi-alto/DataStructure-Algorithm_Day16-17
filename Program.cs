﻿using Algorithms_DataStructures;
Console.WriteLine("Hello, to the algorithm and data structure problems");
Console.WriteLine("Enter a word whose anagram you want");
String s = Console.ReadLine();
Console.WriteLine("Enter the word you want to check for");
String find = Console.ReadLine();
question obj = new question(find,s);
obj.anagram("", s);