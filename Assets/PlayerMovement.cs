using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 0.1f;
    
    public KeyCode rightKey = KeyCode.RightArrow;
    public KeyCode leftKey = KeyCode.LeftArrow;
    public KeyCode upKey = KeyCode.UpArrow;
    public KeyCode downKey = KeyCode.DownArrow;

    
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(rightKey))
        {
            transform.Translate(moveSpeed, 0, 0);
        }

        if (Input.GetKey(leftKey))
        {
            transform.Translate(-moveSpeed, 0, 0);
        }

        if (Input.GetKey(upKey))
        {
            transform.Translate(0, moveSpeed, 0);
        }

        if (Input.GetKey(downKey))
        {
            transform.Translate(0, -moveSpeed, 0);

        }

      
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "kid")
        {
            SceneManager.LoadScene(1);
        }
    }
}
