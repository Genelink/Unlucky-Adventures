using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightCombat : MonoBehaviour
{
    public int maxHealth = 20;
    public int Health = 20;
    public int Damage = 3;

    public Animator Animation;

    int HealthCheck;
    GameObject[] EnemyObject;
    
    SpiderCombat EnemyVar;


    [SerializeField] GameObject CAEnemy1;
    SpiderCombat CAEnemy1Var;
    [SerializeField] GameObject CAEnemy2;
    SpiderCombat CAEnemy2Var;
    
    public bool BasicAttack = false;
    public bool ChargedAttack = false;

    public bool MyTurn = false;

    [SerializeField] GameObject TensionBar;
    Turns Turns;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void ChangeSprite(Sprite NextSprite)
    {
        
    }
    
    void Update()
    {
        Turns = TensionBar.GetComponent<Turns>();
        
        if ((BasicAttack == true) && (MyTurn == true))
        {
            Attack1();
            Turns.ChangeTurn();

        }

        if ((ChargedAttack == true) && (MyTurn == true))
        {
            StartCoroutine(Attack2());
            MyTurn = false;
            

            

        }

        
        if (HealthCheck != Health)
        {
            Animation.SetTrigger("IsHurt");
            
        } 


        
        if (Health <= 0)
        {
            Health = 0;
            Animation.SetBool("IsDied", true);
            
            //Destroy(gameObject);
        }

    HealthCheck = Health;
    BasicAttack = false;
    ChargedAttack = false;
    }


    void Attack1()
    {
        EnemyObject = GameObject.FindGameObjectsWithTag("Selected Enemy");
        EnemyVar = EnemyObject[0].GetComponent<SpiderCombat>();       
        Animation.SetTrigger("Attack1");
        EnemyVar.Health -= Damage;
        FindObjectOfType<AudioManager>().Play("Powder Attack");
        

        
        
    }

    IEnumerator Attack2()
    {
        CAEnemy1Var = CAEnemy1.GetComponent<SpiderCombat>();
        CAEnemy2Var = CAEnemy2.GetComponent<SpiderCombat>();

        Animation.SetTrigger("Attack2");

        Debug.Log("Started Coroutine at timestamp : " + Time.time);
        
        yield return new WaitForSeconds(0.5f);
        
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);

        CAEnemy1Var.Health -= Damage * 2;
        CAEnemy2Var.Health -= Damage * 2;
        FindObjectOfType<AudioManager>().Play("Charge Attack");
        Turns.ChangeTurn();
        

        
        
    }

    IEnumerator WaitTimeSec(float Seconds)
    {
        yield return new WaitForSeconds(Seconds);
    }

}
