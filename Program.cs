using System;
using CarApp;
using Shapes;
using Base;
using Mammals;
using SeqList;
using Books;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(4, 20);
            SmallCar smallCar = new SmallCar(4, 20, 20);
            BigCar bigCar = new BigCar(8, 40, 3, 500);
            Console.WriteLine(bigCar.Print());
            Shape shape = new Circle(1,2);
            Console.WriteLine(shape.GetArea());
            BaseClass baseClass = new BaseClass();
            BaseClass ba = new DerivedClass();
            DerivedClass derivedClass = new DerivedClass();
            baseClass.fn1();
            baseClass.fn2();
            ba.fn1();
            ba.fn2();
            derivedClass.fn1();
            derivedClass.fn2();
            Cat cat = new Cat();
            Dog dog = new Dog();
            Student student = new Student();
            for (int i = 0; i<10;i++) 
            {
                Stu stu = new Stu();
                stu.stuName = stu.stunNum = Convert.ToString(i);
                stu.score.cs = stu.score.eng = stu.score.math = i;
                stu.score.avg = (stu.score.cs + stu.score.eng + stu.score.math)/3;
                student.enqueue(stu);
            }
            student.Print();
            Stacks stacks = new Stacks();
            for (int i = 0; i < 10; i++)
            {
                Book book = new Book();
                book.author = book.bookName = book.publish = Convert.ToString(i);
                book.price = i;
                stacks.Push(book);
            }
            stacks.Print();
        }
    }
}
