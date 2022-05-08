using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWithFinger : MonoBehaviour
{
    public float speed = 1.0f;
	public Animator animator;
    SpriteRenderer Jarold;
    // Start is called before the first frame update
    void Start()
    {
        Jarold = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        var step =  speed * Time.deltaTime;
        
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            touchPosition.z = 0f;
            if (touchPosition.x < transform.position.x)
            {
                Jarold.flipX = true;
            }
            if (touchPosition.x > transform.position.x)
            {
                Jarold.flipX = false;
            }
            
            transform.position = Vector3.MoveTowards(transform.position, touchPosition, step);
            



        }

        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.z = 0f;
            transform.position = Vector3.MoveTowards(transform.position, mousePosition, step);
        }

        if ((Input.touchCount > 0) | (Input.GetMouseButtonDown(0)))
        {
            animator.SetBool("IsWalking", true);
        }
        else
        {
            animator.SetBool("IsWalking", false);
        }

    }
}