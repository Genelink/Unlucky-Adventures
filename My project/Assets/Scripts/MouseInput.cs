using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInput : MonoBehaviour
{
    Collider2D col;
    public bool MouseClicked = false;
    public bool MouseClicked_Down = false;

    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 mousePos = Input.mousePosition;
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(mousePos);
            

            Collider2D mouseCollider = Physics2D.OverlapPoint(mousePosition);
            if (col == mouseCollider)
            {                  
                MouseClicked = true;
            }
        }
        else
        {
            MouseClicked = false;
        }
        
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Input.mousePosition;
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(mousePos);
            

            Collider2D mouseCollider = Physics2D.OverlapPoint(mousePosition);
            if (col == mouseCollider)
            {                  
                MouseClicked_Down = true;
            }
        }
        else
        {
            MouseClicked_Down = false;
        }
    }
}
