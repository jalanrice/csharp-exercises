using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace C7Exercises
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    abstract class Shape
    {
        
        double Perimeter { get; set; }
        double Area { get; set; }
        int Edges { get; set; }
        public int Id { get; set; }
        private static int nextId = 1;

        public Shape (double perimeter, double area, int edges, int id)
        {
            Perimeter = perimeter;
            Area = area;
            Edges = edges;
            Id = nextId;

            nextId++;
        }

        public Shape (double perimeter, double area, int edges)
            : this (perimeter, area, edges, nextId)
        {
            
        }
    }

    class Circle : Shape
    {
        double Radius { get; set; }

        public Circle(double perimeter, double area, int edges, double radius, int id) : base(perimeter, area, edges, id)
        {
           
        }
                
    }

    class Rectangle : Shape
    {
        double Width { get; set; }
        double Length { get; set; }

        public Rectangle(double perimeter, double area, int edges, double width, double length, int id) : base(perimeter, area, edges, id)
        {

        }

    }

    class Square : Rectangle
    {
        double Length { get; set; }
        
        public Square(double perimeter, double area, int edges, double width, double length, int id) : base(perimeter, area, edges, length, id)
        {
          
        }
    }


    
}
