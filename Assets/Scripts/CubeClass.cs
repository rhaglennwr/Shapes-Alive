using System.IO;

public class CubeClass : ShapeClass
{
    public CubeClass()
    {
        shape = "Cube";
        //Debug.Log("You clicked on Cube!");
    }

    public CubeClass(string newShape) : base(newShape)
    {
        //shape = "Cube";
    }
}
