public class CapsuleClass : ShapeClass
{
    public CapsuleClass()
    {
        shape = "Capsule";
        //Debug.Log("You clicked on Cube!");
    }

    public CapsuleClass(string newShape) : base(newShape)
    {
        //shape = "Capsule";
    }
}
