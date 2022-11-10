using Exercice3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice4_Droite
{
    class Droite
    {
        private Point X1;
        private Point Y1;
        public Point(double pX1, double pY1)
        {
            this.X1 = pX1;
            this.Y1 = pY1;
        }
        public double PointX1 getX1()
        {
                return X1;
        }
        public void PointX1 setX1(PointX1 x1)
        {
                this.X1 = x1;
        }
        public double PointY1 getY1()
        {
            return Y1;
        }
        public void PointY1 setY1(PointY1 y1)
        {
            this.Y1 = y1;
        }
      
        static public bool egalite(Point A, Point B, Point C, Point D)
        {
            return (A.PointX1 == C.PointX1 && A.PointY1 == C.PointY1 && B.PointX1 == D.PointX1 && B.PointY1 == D.PointY1);
        }
    }

}
