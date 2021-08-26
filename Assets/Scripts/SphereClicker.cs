using UnityEngine;

public class SphereClicker : MonoBehaviour
{
    // Update is called once per frame
    private void Update()
    {
        if (!Input.GetMouseButtonDown(0)) return;
        if (Camera.main is null) return;
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (!Physics.Raycast(ray, out var hit)) return;
        if (hit.transform.name != "Sphere") return;
        var sphereClass = new SphereClass();
        sphereClass = new SphereClass("Sphere");
    }
}
