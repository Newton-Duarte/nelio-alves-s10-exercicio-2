using System.Globalization;

System.Console.Write("Enter the number of shapes: ");

int shapesCount = int.Parse(Console.ReadLine());
int counter = 1;

List<Shape> shapes = new();

while (counter <= shapesCount)
{
  System.Console.WriteLine($"Shape #{counter} data:");
  System.Console.Write("Rectangle or Circle (r/c)? ");
  var type = Console.ReadLine();

  System.Console.Write("Color (Black/Blue/Red)? ");
  var color = Console.ReadLine();

  if (type.ToLower() == "r")
  {
    System.Console.Write("Width: ");
    var width = double.Parse(Console.ReadLine());

    System.Console.Write("Height: ");
    var height = double.Parse(Console.ReadLine());

    var rectangle = new Rectangle(Enum.Parse<Color>(color), width, height);
    shapes.Add(rectangle);
  }
  else
  {
    System.Console.Write("Radius: ");
    var radius = double.Parse(Console.ReadLine());

    var circle = new Circle(Enum.Parse<Color>(color), radius);
    shapes.Add(circle);
  }

  counter++;
}

System.Console.WriteLine("SHAPE AREAS:");

foreach(var shape in shapes)
{
  System.Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
}