using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicAttackButton : MonoBehaviour
{
    Collider2D col;
    public GameObject Player;
    KnightCombat PlayerVar;
    GameObject[] SelectedEnemey;
    TouchInput Finger;
    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Finger = GetComponent<TouchInput>();
        
        SelectedEnemey = GameObject.FindGameObjectsWithTag("Selected Enemy");
        



        if (Finger.TouchBegan)
        {
            PlayerVar = Player.GetComponent<KnightCombat>();
            PlayerVar.BasicAttack = true;
        }
    }
}
