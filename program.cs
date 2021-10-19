using System;

namespace INA_EDITS
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(5); // 5, 5
            Point p2 = new Point(4, 12); // 4, 12
            Console.WriteLine(p1.GetDistanceFromAnotherPoint(p2)); // 7.071

            Point p3 = new Point(p1); // 5, 5
            Console.WriteLine(p3.GetDistanceFromAnotherPoint(p1)); // 0 distance

            Point p4 = new Point(); // random, random
            
            // מערך עצמים
            Point[] points = new Point[4] { p1, p2, p3, p4 };
            for (int i = 0; i < points.Length; i++)
                Console.WriteLine(points[i].ToString());

            Console.WriteLine("------");
            Console.WriteLine(Point.GetCount());
            Point p5 = new Point(1, 3);
            Console.WriteLine(Point.GetCount());

        }
    }
    class Point
    {
        private double x; // x ערך
        private double y; // y ערך 
        private int id;
        private static int count = 0;
        public Point(double a, double b) // פעולה בונה עם 2 פרמטרים
        {
            this.x = a;
            this.y = b;
            count++;
            this.id = count;
        }
        public Point(double a) // פעולה בונה עם פרמטר אחד
        {
            this.x = a;
            this.y = a;
            count++;
            this.id = count;
        }
        public Point(Point AnotherPoint) // פעולה בונה המעתיקה נתוני נקודה אחרת
        {
            this.x = AnotherPoint.x;
            this.y = AnotherPoint.y;
            count++;
            this.id = count;
        }
        public Point() // פעולה בונה עם מספרים אקראיים
        {
            this.x = new Random().Next(10);
            this.y = new Random().Next(10);
            count++;
            this.id = count;
        }
        // set
        public void SetX(double NewX) { this.x = NewX; }

        public void SetY(double NewY) { this.y = NewY; }

        // get
        public double GetX() { return this.x;  }

        public double GetY() { return this.y;  }

        public int GetID() { return this.id; }

        public static int GetCount() { return count; }


        public double GetDistanceFromAnotherPoint(Point p2)
        { // לחשב מרחק מנקודה אחת 
            // distance = Math.sqrt ( (x1 - x2)^2 + (y1-y2)^2 )
            double d = Math.Round(Math.Sqrt(Math.Pow(this.x - p2.x, 2) + Math.Pow(this.y - p2.y, 2)), 3);
            return d;
        }
        public override string ToString()
        {
            string str = "";
            str = "x: " + this.x.ToString() + ", y: " + this.y.ToString() + ", id: " + this.id.ToString();
            return str;
        }
    }
}
