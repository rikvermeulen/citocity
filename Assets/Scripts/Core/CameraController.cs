using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Should scale from mouse position to coordinates
    private int dragSpeed = 35;
    private Vector3 dragOrigin;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            dragOrigin = Input.mousePosition;
            return;
        }

        if (!Input.GetMouseButton(0)) return;

        Vector3 pos = Camera.main.ScreenToViewportPoint(dragOrigin - Input.mousePosition);
        Vector3 move = new Vector3(pos.x * dragSpeed, 0, pos.y * dragSpeed);

        dragOrigin = Input.mousePosition;

        transform.Translate(move, Space.World);
    }
}
