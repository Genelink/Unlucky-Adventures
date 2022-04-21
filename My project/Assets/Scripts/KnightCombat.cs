using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightCombat : MonoBehaviour
{
    public int Health = 20;
    public int Damage = 5;
    GameObject[] EnemyObject;
    public SpriteRenderer spriteRenderer;
    public Sprite IdleSprite;
    public Sprite SwingSprite;
    SpiderCombat EnemyVar;
    public bool SwingButton = false;

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
        if (SwingButton == true)
        {
            SwordSwing();
            SwingButton = false;

        }
    }

    void SwordSwing()
    {
        EnemyObject = GameObject.FindGameObjectsWithTag("Selected Enemy");
        EnemyVar = EnemyObject[0].GetComponent<SpiderCombat>();       
        EnemyVar.Health -= Damage;    
        
        
    }

}
