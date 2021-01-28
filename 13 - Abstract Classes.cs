using System;
using System.Collections.Generic;
using System.IO;
abstract class Book
{
    
    protected String title;
    protected  String author;
    
    public Book(String t,String a){
        title=t;
        author=a;
    }
    public abstract void display();


}

//Write MyBook class
class MyBook : Book
{
    private int price;
    public MyBook(String t, String a, int price) : base(t, a)
    {
        this.title = t;
        this.author = a;
        this.price = price;
    }

    public override void display()
    {
        Console.WriteLine($"Title: {title}\nAuthor: {author}\nPrice: {price}");
    }
}

class Solution {
    static void Main(String[] args) {
      String title=Console.ReadLine();
      String author=Console.ReadLine();
      int price=Int32.Parse(Console.ReadLine());
      Book new_novel=new MyBook(title,author,price);
      new_novel.display();
    }
}