using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float MoveSpeed;

    // Update is called once per frame
    public void Move(Vector2 _direction)
    {
        transform.Translate(_direction * MoveSpeed * Time.deltaTime);
    }
    void Update()
    {
       if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.left * MoveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * MoveSpeed * Time.deltaTime);
        }
    }
}
