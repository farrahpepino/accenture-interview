// Write a C# program to find and display all even numbers from a given integer array.

using System;
using System.Collections.Generic;


class Program{
    static void Main(string[] args){

        int size = 5;
        int min = 0;
        int max = 100;

        int[] numArr = new int[size];
        // int[] numArr = { 12, 7, 9, 20, 33 };
        List<int> evenNums = new List<int>();

        Random random = new Random();

        for (int i = 0; i < size; i++){
            numArr[i] = random.Next(min, max+1);
        }

        Console.WriteLine("Array of numbers: " + string.Join(", ", numArr));
        Console.WriteLine("Even numbers");
        for(int i=0; i< size; i++){
            if(numArr[i]%2==0){
                evenNums.Add(numArr[i]);
                Console.WriteLine(numArr[i]);
            }
        }
        Console.WriteLine("Even numbers: " + string.Join(", ", evenNums));

    }
}