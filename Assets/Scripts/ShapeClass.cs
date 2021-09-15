using UnityEngine;

//Parent class.
public class ShapeClass : MonoBehaviour
{
    //ENCAPSULATION
    private readonly string Shape;

    protected ShapeClass()
    {
        Shape = "Blob";
    }

    protected ShapeClass(string newShape)
    {
        Shape = newShape;
        //ABSTRACTION
        LogPrinter(Shape);

        //Debug.Log("ShapeClass with string parameter " + Shape + " is called.");
    }

    //Polymorphism using Shape
    private static void LogPrinter(string Shape)
    {
        Debug.Log("ShapeClass with string parameter " + Shape + " is called.");
    }
}