using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Result : MonoBehaviour
{
    public Transform Player;

    void Start()
    {
        GetComponent<Text>().enabled = false;
    }

    void Update()
    {
        if (Player.position.y <= -1)
        {
            GetComponent<Text>().enabled = true;
            GetComponent<Text>().text = "You Lose";
        }
        if (Player.position.z <= -50 && Player.position.y > 0)
        {
            GetComponent<Text>().enabled = true;
            GetComponent<Text>().text = "You Win";
        }
    }
}