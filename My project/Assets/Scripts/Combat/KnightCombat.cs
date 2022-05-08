using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightCombat : MonoBehaviour
{
    public int Health = 20;
    public int Damage = 3;
    GameObject[] EnemyObject;
    public SpriteRenderer spriteRenderer;
    SpiderCombat EnemyVar;
    public bool BasicAttack = false;
    public bool MyTurn = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void ChangeSprite(Sprite NextSprite)
    {
        spriteRenderer.sprite = NextSprite;
    }
    
    void Update()
    {
        
        
        if ((BasicAttack == true) && (MyTurn == true))
        {
            SwordSwing();
            BasicAttack = false;

        }
    }

    void SwordSwing()
    {
        EnemyObject = GameObject.FindGameObjectsWithTag("Selected Enemy");
        EnemyVar = EnemyObject[0].GetComponent<SpiderCombat>();       
        EnemyVar.Health -= Damage;    
        
        
    }

    IEnumerator WaitTimeSec(int Seconds)
    {
        yield return new WaitForSeconds(Seconds);
    }

}
