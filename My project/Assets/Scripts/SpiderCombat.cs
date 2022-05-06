using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderCombat : MonoBehaviour
{
    public int maxHealth = 10;
    public int Health = 10;
    public int Damage = 3;
    int HealthCheck;
    
    Vector3 SelectedPos;
    Collider2D col;
    public bool Selected = false;

    public Animator Animation;
    // Start is called before the first frame update
    void Start()
    {
        SelectedPos = transform.position;
        col = GetComponent<Collider2D>();
        SelectedPos.y -= 1;
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
                if ((col == touchedCollider) && (Selected == false))
                {                  
                    Selected = true;
                    this.tag = "Selected Enemy";
                }
            }

            // Make it so it glows with a red ring, and gets the tag Selected Enemy, and if any other ones are selected then they get the enemy tag...
        }

        if (HealthCheck != Health)
        {
            Animation.SetBool("IsHurt", true);
            
        } 


        if (Health <= 0)
        {
            Animation.SetBool("IsDied", true);
            
            //Destroy(gameObject);
        }

    HealthCheck = Health;
    }

    void FixedUpdate()
    {
        Animation.SetBool("IsHurt", false);
    }
}