using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatCounter : MonoBehaviour
{
    public int CAT_NO = 4;
    public bool win = false;
    public int counter = 0;

    public GameObject cage;

    void onCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "CAT")
        {
            counter += 1;
        }
    }

    void onCollisionExit(Collision col)
    {
        if (col.gameObject.tag == "CAT")
        {
            counter -= 1;
        }
    }

    void Update()
    {
        if (counter == 4)
        {
            win = true;
        }

        if (win)
        {
            cage.SetActive(false);
        }
    }
}
