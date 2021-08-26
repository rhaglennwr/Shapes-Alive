public class SphereClass : ShapeClass 
{
    public new string Shape { get; set; }
    
    public SphereClass()
    {
        Shape = "Sphere";
    }

    public SphereClass(string newShape) : base(newShape)
    {
        Shape = "Sphere";
    }
}