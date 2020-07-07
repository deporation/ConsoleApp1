using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Books
{
    struct Book 
    {
        public string bookName;
        public string author;
        public string publish;
        public double price;
    }
    class Stacks
    {
       
        private Stack st = new Stack();
        public void Push(Book book) 
        {
            this.st.Push(book);
        }
        public void Pop() 
        {
            this.st.Pop();
        }
        public void Print() 
        {
            foreach (Book book in this.st)
            {
                Console.WriteLine(book.bookName +" " +book.author + " "  + book.publish+ " " + book.price);
            }
        }
        
    }
}
