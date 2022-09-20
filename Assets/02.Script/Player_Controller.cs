using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    [SerializeField]
    private GameObject idle;
    [SerializeField]
    private GameObject run;

    private float speed = 5.0f;

    private void Update()
    {
        Player_Move();
    }

    private void Player_Move()
    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            idle.SetActive(false);
            idle.GetComponent<SpriteRenderer>().flipX = false;
            run.SetActive(true);
            run.GetComponent<SpriteRenderer>().flipX = false;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            idle.SetActive(false);
            idle.GetComponent<SpriteRenderer>().flipX = true;
            run.SetActive(true);
            run.GetComponent<SpriteRenderer>().flipX = true;
        }
        else
        {
            idle.SetActive(true);
            run.SetActive(false);
        }
    }
}