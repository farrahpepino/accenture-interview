// You are given an amount of 1000. First, add 10% of the amount, then add 18% of the new total. Write a C# program to calculate and print the final total.

using System;

class Percentage
{
    private double amount;

    public Percentage(double amount){
        this.amount = amount;
    }

    public double GetAmount(){
        return this.amount;
    }

    public double CalculateAmount(){
        amount += amount * 0.10;
        amount += amount * 0.18;

        return amount;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Percentage p = new Percentage(1000);

        double finalTotal = p.CalculateAmount();

        Console.WriteLine("Final Total: " + finalTotal);
    }
}
