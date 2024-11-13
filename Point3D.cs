using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PointGeometrics
{
    public class Point3D
    {
        // 3D coordinations of points
        public decimal X { get; set; } = 0;
        public decimal Y { get; set; } = 0;
        public decimal Z { get; set; } = 0;

        // Constructor
        public Point3D(decimal pX, decimal pY, decimal pZ)
        {
            this.X = pX;
            this.Y = pY;
            this.Z = pZ;
        }

        // Addition

        public Point3D Add(Point3D that)
        {
            if (that is null)
            {
                throw new NullReferenceException("The argument 3D point can not be null.");
            }
            return new Point3D(pX: this.X + that.X, pY: this.Y + that.Y, pZ: this.Z + that.Z); 
        }

        // Substraction

        public Point3D Substract(Point3D that)
        {
            if (that is null)
            {
                throw new NullReferenceException("The argument 3D point can not be null.");
            }
            return new Point3D(pX: this.X - that.X, pY: this.Y - that.Y, pZ: this.Z - that.Z);
        }

        // Multiplication

        public Point3D Multiply(decimal k)
        {
            return new Point3D(pX: this.X * k, pY: this.Y * k, pZ: this.Z * k);
        }

        // Division

        public Point3D Divide(decimal k)
        {
            if (k == 0)
            {
                throw new DivideByZeroException("The argument decimal can not equal 0.");
            }
            return new Point3D(pX: this.X / k, pY: this.Y / k, pZ: this.Z / k);
        }

        // Distance calculation

        public decimal ComputeDistance(Point3D that)
        {
            if (that is null)
            {
                throw new NullReferenceException("The argument 3D point can not be null.");
            }

            decimal XComponent = (this.X - that.X) * (this.X - that.X);
            decimal YComponent = (this.Y - that.Y) * (this.Y - that.Y);
            decimal ZComponent = (this.Z - that.Z) * (this.Z - that.Z);

            decimal Distance = (decimal) Math.Round(Math.Sqrt((double) (XComponent + YComponent + ZComponent)), 4);
            return Distance;
        }

        // Console output
        public override string ToString()
        {
            return "Point3D( " + X + ", " + Y + ", " + Z + ")";
        }
    }
}
