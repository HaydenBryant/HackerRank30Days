using System;
using System.Collections.Generic;
using System.IO;
abstract class Book
{

    protected String title;
    protected String author;

    public Book(String t, String a)
    {
        title = t;
        author = a;
    }
    public abstract void display();


}

//Write MyBook class
class MyBook : Book
{
    protected int price;
    public MyBook(string title, string author, int p)
        : base(title, author)
    {
        price = p;
    }

    public override void display()
    {
        Console.WriteLine("Title: {0}\nAuthor: {1}\nPrice: {2}", title, author, price);
    }
}

class Solution {