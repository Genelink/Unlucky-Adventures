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
        
    }

    void SwordSwing()
    {
        EnemyObject = GameObject.FindGameObjectsWithTag ("SelectedEnemy");
        EnemyVar = EnemyObject[0].GetComponent<SpiderCombat>();
        EnemyVar.Health -= Damage;
    }
}
