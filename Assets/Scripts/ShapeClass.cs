using UnityEngine;

//Parent class.
public class ShapeClass
{
    private readonly string Shape;

    protected ShapeClass()
    {
        Shape = "Blob";
    }

    protected ShapeClass(string newShape)
    {
        Shape = newShape;
        Debug.Log("ShapeClass with string parameter " + Shape + " is called.");
    }
}