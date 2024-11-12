using PointGeometrics;

Point3D P1 = new Point3D(1, 2, 3);
Point3D P2 = new Point3D(4, 5, 6);

Console.WriteLine("Result of: " + P1 + " + " + P2 + ":");
Console.WriteLine(P1.Add(P2));

Console.WriteLine("Result of: " + P1 + " - " + P2 + ":");
Console.WriteLine(P1.Substract(P2));

Console.WriteLine("Result of: " + P1 + " * " + 5 + ":");
Console.WriteLine(P1.Multiply(5));

Console.WriteLine("Result of: " + P1 + " / " + 10 + ":");
Console.WriteLine(P1.Divide(10));

Console.WriteLine("Distance from: " + P1 + " to: " + P2 + ":");
Console.WriteLine(P1.ComputeDistance(P2));
