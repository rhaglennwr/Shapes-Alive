public class CapsuleClass : ShapeClass
{
    public new string Shape { get; set; }
    
    public CapsuleClass()
    {
        Shape = "Capsule";
    }

    public CapsuleClass(string newShape) : base(newShape)
    {
        Shape = "Capsule";
    }
}
