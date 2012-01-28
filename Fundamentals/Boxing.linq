<Query Kind="Program" />

void Main()
{
	double e = 2.718281828459045;
	double d = e;
	object o11 = d;
	object o22 = e;
	Console.WriteLine(d == e);
	Console.WriteLine(o11 == o22);
	
	double e1 = 2.718281828459045;
	object o1 = e1;
	object o2 = e1;
	Console.WriteLine(o1 == o2);

	//For reference Equals
	Console.WriteLine(o1.Equals(o2));

	
	Point p = new Point(1, 1);
	object o = p;
	p.x = 2;
	Console.WriteLine(((Point)o).x);
}

/*struct*/ class Point {
	public int x, y;

	public Point(int x, int y) {
		this.x = x;
		this.y = y;
	}
}

