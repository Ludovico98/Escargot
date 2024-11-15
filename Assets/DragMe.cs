using UnityEngine;

public class DragMe : MonoBehaviour
{
    private Vector3 offset;

    void OnMouseDown()
    {
        // Calculate the offset between the mouse position and the object's position
        offset = transform.position - GetMouseWorldPos();
    }

    void OnMouseDrag()
    {
        // Update the object's position based on the mouse position and offset
        transform.position = GetMouseWorldPos() + offset;
    }

    private Vector3 GetMouseWorldPos()
    {
        // Get the mouse position in screen coordinates, then convert it to world coordinates
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = 0; // Set Z to 0 for 2D space
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }
}