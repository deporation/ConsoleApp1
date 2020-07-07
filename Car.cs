using System;

namespace CarApp
{
    public class Car
    {
        private int wheelnum;
        private float weight;
        public Car(int wheelnum, float weight)
        {
            this.wheelnum = wheelnum;
            this.weight = weight;
        }
        public int getWheelnum()
        {
            return this.wheelnum;
        }
        public float getWeight()
        {
            return this.weight;
        }
        public String Print()
        {
            return "轮子数：" + this.wheelnum + " " + "车重：" + this.weight;
        }
    }
    public class SmallCar : Car
    {
        private int guestCnt;
        public SmallCar(int wheelnum, float weight, int guestCnt) : base(wheelnum, weight)
        {
            this.guestCnt = guestCnt;
        }
        public String Print()
        {
            return "轮子数：" + this.getWheelnum() + " " + "车重：" + this.getWeight() + " " + "顾客数量：" + this.guestCnt;
        }
    }
    public class BigCar : Car
    {
        private int guestCnt;
        private float guestweight;
        public BigCar(int wheelnum, float weight, int guestCnt, float guestweight) : base(wheelnum, weight)
        {
            this.guestCnt = guestCnt;
            this.guestweight = guestweight;
        }
        public String Print()
        {
            return "轮子数：" + this.getWheelnum() + " " + "车重：" + this.getWeight() + " " + "顾客数量：" + this.guestCnt + "载货量：" + this.guestweight;
        }
    }
}
