using UnityEngine;

//Parent class.
public class ShapeClass
{
    protected string shape;

    protected ShapeClass()
    {
        shape = "blob";
        //Debug.Log("ShapeClass with no parameters is called.");
    }

    protected ShapeClass(string newShape)
    {
        shape = newShape;
        Debug.Log("ShapeClass with string parameter " + shape + " is called.");
    }
}