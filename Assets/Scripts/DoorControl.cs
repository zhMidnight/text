using UnityEngine;

public class DoorControl : MonoBehaviour
{
    private Animator doorAnimator;
    private float playerToDoor;
    private Transform player;
    private bool isOpen = false;

    void Start()
    {
        doorAnimator = GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        playerToDoor =Vector3.Distance(player.transform.position, this.transform.position);

        /*if (playerToDoor <= 2f)
        {

            if (isOpen == false && Input.GetKeyDown(KeyCode.F))
            {
                doorAnimator.SetTrigger("Open");
                isOpen = true;
            }
            if (isOpen == true && Input.GetKeyDown(KeyCode.T))
            {
                doorAnimator.SetTrigger("Close");
                isOpen = false;
            }

        }*/

            if (isOpen == false && playerToDoor <= 2f)
            {
                doorAnimator.SetTrigger("Open");
                isOpen = true;
            }
            if (isOpen == true && playerToDoor > 2f)
            {
                doorAnimator.SetTrigger("Close");
                isOpen = false;
            }



    }

}


