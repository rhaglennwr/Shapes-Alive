public class SphereClass : ShapeClass 
{
    public SphereClass()
    {
        shape = "Sphere";
        //Debug.Log("You clicked on Cube!");
    }

    public SphereClass(string newShape) : base(newShape)
    {
        //shape = "Sphere";
    }
}