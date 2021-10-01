using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    [Header("Set in Inspector")]
    public float speed;
    private Rigidbody rb;
    public Transform Player;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        if (Player.position.y <= -1)
        {
            Time.timeScale = 0.2f;
        }
        if (Player.position.x >= 50 || Player.position.z >= 50)
        {
            Time.timeScale = 0.2f;
        }

        if (transform.position.y < -3f)
        {
            LoadScene();
        }
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

        rb.AddForce(movement * speed);
    } 
    public void LoadScene()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main-Prototype 1");
    }
}