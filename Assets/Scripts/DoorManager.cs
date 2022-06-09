using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorManager : MonoBehaviour
{
    private bool enterAllowed;
    private string sceneToLoad;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<MathDoor>())
        {
            sceneToLoad = "Math";
            enterAllowed = true;
        }
        else if (collision.GetComponent<LangDoor>())
        {
            sceneToLoad = "Lang";
            enterAllowed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.GetComponent<MathDoor>() || collision.GetComponent<LangDoor>())
        {
            enterAllowed = false;
        }
    }

    private void Update()
    {
        if (enterAllowed && Input.GetKey(KeyCode.F))
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
