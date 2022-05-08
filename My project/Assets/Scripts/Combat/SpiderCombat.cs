using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderCombat : MonoBehaviour
{
    public int maxHealth = 10;
    public int Health = 10;
    public int Damage = 3;
    int HealthCheck;
    public bool MyTurn = false;
    
    public bool Selected = false;
    
    TouchInput Finger;

    public Animator Animation;
    
    // Start is called before the first frame update
    void Start()
    {
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        Finger = GetComponent<TouchInput>();

        if (Finger.TouchBegan)
        {
            Selected = true;
            this.tag = "Selected Enemy";
        }
        
        
        // EVERYTHING ABOVE THIS!!!


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