using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    static public bool goalMet = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Finish.goalMet = true;
            Material mat = GetComponent<Renderer>().material;

            Color c = mat.color;

            c.a = 1;

            mat.color = c;
        }
    }
}
