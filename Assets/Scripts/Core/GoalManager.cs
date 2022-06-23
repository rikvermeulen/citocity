using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalManager : MonoBehaviour
{
    [SerializeField] private Transform previousRoom;
    [SerializeField] private Transform nextRoom;
    [SerializeField] private RoomController cam;
    public string popUp;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("test");

            PopUpSystem pop = GameObject.FindGameObjectWithTag("GameController").GetComponent<PopUpSystem>();
            pop.PopUp(popUp);
            // cam.MoveToNewRoom(nextRoom);
        }
    }

    public void nextQuestion()
    {
        cam.MoveToNewRoom(nextRoom);
    }
}
