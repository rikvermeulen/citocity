using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Should scale from mouse position to coordinates.
    // There is definetely a far better way to get these factors instead of random numbers that happen to work.
    // It's probably based on the width and height of the canvas.
    private int xFactor = 35;
    private int yFactor = 18;
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
        Vector3 move = new Vector3(pos.x * xFactor, pos.y * yFactor);

        transform.Translate(move, Space.World);

        dragOrigin = Input.mousePosition;
    }
}
