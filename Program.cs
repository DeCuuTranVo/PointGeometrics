using PointGeometrics;

// User Input:
Console.WriteLine("Input:");
Console.WriteLine("Enter Coordinate X of Point P1:");
decimal P1_X = decimal.Parse(Console.ReadLine());

Console.WriteLine("Enter Coordinate Y of Point P1:");
decimal P1_Y = decimal.Parse(Console.ReadLine());

Console.WriteLine("Enter Coordinate Z of Point P1:");
decimal P1_Z = decimal.Parse(Console.ReadLine());

Console.WriteLine("Enter Coordinate X of Point P2:");
decimal P2_X = decimal.Parse(Console.ReadLine());

Console.WriteLine("Enter Coordinate Y of Point P2:");
decimal P2_Y = decimal.Parse(Console.ReadLine());

Console.WriteLine("Enter Coordinate Z of Point P2:");
decimal P2_Z = decimal.Parse(Console.ReadLine());

// TestCase for point P1(1,2,3) and point P2(4,5,6)
Point3D P1 = new Point3D(P1_X, P1_Y, P1_Z);
Point3D P2 = new Point3D(P2_X, P2_Y, P2_Z);

Console.WriteLine();
Console.WriteLine("Output:");
// Addition
Console.WriteLine("Result of: " + P1 + " + " + P2 + ":");
Console.WriteLine(P1.Add(P2));

// Substraction
Console.WriteLine("Result of: " + P1 + " - " + P2 + ":");
Console.WriteLine(P1.Substract(P2));

// Multiplication
Console.WriteLine("Result of: " + P1 + " * " + 5 + ":");
Console.WriteLine(P1.Multiply(5));

// Division
Console.WriteLine("Result of: " + P1 + " / " + 10 + ":");
Console.WriteLine(P1.Divide(10));

// Computing distance between 2 points
Console.WriteLine("Distance from: " + P1 + " to: " + P2 + ":");
Console.WriteLine(P1.ComputeDistance(P2));
