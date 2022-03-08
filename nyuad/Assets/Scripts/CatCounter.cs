using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatCounter : MonoBehaviour
{
    public int CAT_NO = 4;
    public GameObject door;

    public int counter = 0;

    public bool win = false;

    public Transform cat;
    Collider m_Collider;
    Vector3 m_Point;

    private void Start()
    {
        m_Collider = GetComponent<Collider>();
        m_Point = cat.position;
    }

    private void onTriggerEnter(Collider other)
    {
        //if (other.gameObject.CompareTag("Cat"))
        //{
          //  counter += 1;
        //}
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
        if (other.gameObject.CompareTag("Cat"))
        {
            counter += 1;
        }
    }

    private void Update()
    {
        if (m_Collider.bounds.Contains(m_Point))
        {
            Debug.Log("Bounds contain the point : " + m_Point);
        }
        if (win)
        {
            door.SetActive(false);
        }
    }
}
