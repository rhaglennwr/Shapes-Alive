
//INHERITANCE
public class CubeClass : ShapeClass
{
    public new string Shape { get; set; }
    
    public CubeClass()
    {
        Shape = "Cube";
    }

    public CubeClass(string newShape) : base(newShape)
    {
        Shape = "Cube";
    }
}
