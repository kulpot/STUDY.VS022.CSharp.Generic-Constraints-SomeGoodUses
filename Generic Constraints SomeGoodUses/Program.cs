using System;
using System.Collections;

//ref link:https://www.youtube.com/watch?v=PF_LPi_9lqo&list=PLRwVmtr-pp05ETzLYQ8kv1cI5v9ddT8er&index=15
//

class ClassOne { }

class MainClass
{
    //static void TakeA<T>(T arg) where T : IComparable 
    //static void TakeA<T>(int arg) where T : IComparable
    //static void TakeA(IComparable arg) { }
    static void TakeA<T>(T arg) 
        where T : IComparable 
        where T : IEnumerable
    { 
    }
    static void TakeA( arg)
    { 
    }
    static void Main()
    {
        //TakeA<int>(5);
        TakeA(5);
    }
}