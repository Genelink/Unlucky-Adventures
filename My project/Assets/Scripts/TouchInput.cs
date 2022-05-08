using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchInput : MonoBehaviour
{
    Collider2D col;
    public bool TouchBegan = false;
    
    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            
            if (touch.phase == TouchPhase.Began)
            {
                Collider2D touchedCollider = Physics2D.OverlapPoint(touchPosition);
                if (col == touchedCollider)
                {                  
                    TouchBegan = true;
                }

            }

            // Make it so it glows with a red ring, and gets the tag Selected Enemy, and if any other ones are selected then they get the enemy tag...
        }
        else
        {
            TouchBegan = false;
        }
    }
}
