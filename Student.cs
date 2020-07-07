using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SeqList
{
    public struct Score
    {
        public double cs;
        public double eng;
        public double math;
        public double avg;
    }
    public struct Stu
    {
        public string stunNum;
        public string stuName;
        public Score score;
    };
    public class Student
    {
        public Student() { }
        private int font = 0;
        private int rear = 0;
        private int num = 0;//队列中节点的个数
        private List<Stu> q = new List<Stu>();
        public int Num
        {
            set { num = rear - font; }
        }
        public void enqueue(Stu student)
        {
            if (q.Count == 0)
            {
                font = rear = 0;
            }
            this.q.Add(student);
            this.rear++;
            this.num = this.rear - this.font;
        }
        public void Dequeue()
        {
            this.q.Remove(q[q.Count]);
            this.rear--;
            this.num = this.rear - this.font;
        }
        public void Print()
        {
            Console.WriteLine("总数为：" + this.num);
            for (int i = 0; i < q.Count; i++)
            {
                if (i!=0 &&i%5 == 0)
                {
                    Console.WriteLine();
                }
                Console.WriteLine("学号：" + q[i].stunNum + " " + "姓名：" + q[i].stuName + "计算机=" + q[i].score.cs + "英语=" + q[i].score.eng + "数学=" + q[i].score.math + "平均分=" + q[i].score.avg);
            }
        }
    }
}
