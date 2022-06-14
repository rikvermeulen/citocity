using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickBuilding : MonoBehaviour
{
    public string Scene = "Scenes/Lang";
    private bool clicking = false;
    private Vector2 oldMousePos;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            Vector2 cubeRay = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D cubeHit = Physics2D.Raycast(cubeRay, Vector2.zero);
            if (cubeHit.collider.name == "test") {
                oldMousePos = getMousePos2D();
                clicking = true;
            }
        }
        if (Input.GetMouseButtonUp(0)) {
            clicking = false;
            Vector2 mousePos2D = getMousePos2D();
            if (System.Math.Abs(mousePos2D.x - oldMousePos.x) < 1 &&
                    System.Math.Abs(mousePos2D.y - oldMousePos.y) < 1
                    )
            {
                SceneManager.LoadScene(Scene);
            }
        }
    }
    Vector2 getMousePos2D () {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
        return mousePos2D;
    }
}
