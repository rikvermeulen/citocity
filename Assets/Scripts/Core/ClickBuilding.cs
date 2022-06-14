using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickBuilding : MonoBehaviour
{
    public string Scene = "Scenes/Lang";
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) {
            Vector2 cubeRay = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D cubeHit = Physics2D.Raycast(cubeRay, Vector2.zero);
            if (cubeHit.collider.name == gameObject.name) {
                Debug.Log("We hit");
                SceneManager.LoadScene(Scene);
            }
        }
    }
}
