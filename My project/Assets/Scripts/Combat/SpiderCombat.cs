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

    bool NotDead = true;

    GameObject[] EnemyObject;
    
    
    public bool Selected = false;
    
    TouchInput TouchInput;
    MouseInput MouseInput;

    public Animator Animation;



    GameObject[] PlayerObject;
    KnightCombat PlayerVar;

    [SerializeField] GameObject TensionBar;
    Turns Turns;

    [SerializeField] GameObject OtherEnemy;
    SpiderCombat OtherEnemyVar;
    
    // Start is called before the first frame update
    void Start()
    {
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        Turns = TensionBar.GetComponent<Turns>();
        TouchInput = GetComponent<TouchInput>();
        MouseInput = GetComponent<MouseInput>();

        

        if (Selected)
        {
            this.tag = "Selected Enemy";
        }
        else
        {
            this.tag = "Enemy";
        }
        
        
        
        if (TouchInput.TouchBegan | MouseInput.MouseClicked && NotDead)
        {
            OtherEnemyVar = OtherEnemy.GetComponent<SpiderCombat>();
            OtherEnemyVar.Selected = false;
            
            Selected = true;
            
        }
        

        if (MyTurn)
        {
            OtherEnemyVar = OtherEnemy.GetComponent<SpiderCombat>();
            OtherEnemyVar.Selected = false;
            
            Selected = false;
            
            
            if (NotDead)
            {
                StartCoroutine(WaitThenAttack(1.5f));
                MyTurn = false;
            }
            else
            {
                Turns.ChangeTurn();
            }
        }
        
        
        
        // EVERYTHING ABOVE THIS!!!


        if (HealthCheck != Health)
        {
            Animation.SetTrigger("IsHurt");
            
        } 


        if (Health <= 0)
        {
            Animation.SetBool("IsDied", true);
            NotDead = false;
            Health = 0;
            
            //Destroy(gameObject);
        }

    HealthCheck = Health;
    }

    void FixedUpdate()
    {
        
    }

    void Attack()
    {
        PlayerObject = GameObject.FindGameObjectsWithTag("Player");
        PlayerVar = PlayerObject[0].GetComponent<KnightCombat>();       
        PlayerVar.Health -= Damage;
        Animation.SetTrigger("Attack1");
        FindObjectOfType<AudioManager>().Play("Enemy Hit");
        Turns.ChangeTurn();
        
    }

    IEnumerator WaitThenAttack(float Seconds)
    {
        Debug.Log("Started Coroutine at timestamp : " + Time.time);
        
        yield return new WaitForSeconds(Seconds);
        
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);

        Attack();
        

    }
}