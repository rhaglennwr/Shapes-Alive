using UnityEngine;

public class CapsuleClicker : MonoBehaviour
{
    // Update is called once per frame
    private void Update()
    {
        if (!Input.GetMouseButtonDown(0)) return;
        if (Camera.main is null) return;
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (!Physics.Raycast(ray, out var hit)) return;
        if (hit.transform.name != "Capsule") return;
        var capsuleClass = new CapsuleClass();
        capsuleClass = new CapsuleClass("Capsule");
    }
}
