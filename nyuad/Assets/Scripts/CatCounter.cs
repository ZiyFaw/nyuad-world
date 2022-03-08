using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatCounter : MonoBehaviour
{
    int CAT_NO = 4
    public GameObject door;

    public int counter = 0;

    public bool win = false;

    private void onTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Cat"))
        {
            counter += 1;
        }
    }

    private void onTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Cat"))
        {
            counter -= 1;
        }
    }

    private void onTriggerStay(Collider other)
    {
        if (counter == CAT_NO)
        {
            win = true;
        }
    }

    private void Update()
    {
        if(win)
        {
            door.SetActive(false);
        }
    }
}
