using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turns : MonoBehaviour
{

    public bool Test = false;
    
    public string CurrentTurn = "Player";
    
    public GameObject Player;
    KnightCombat PlayerVar;
    
    public GameObject Spider;
    SpiderCombat SpiderVar;
    
    public GameObject Crow;
    SpiderCombat CrowVar;



    // Start is called before the first frame update
    void Start()
    {
        PlayerVar = Player.GetComponent<KnightCombat>();

        SpiderVar = Spider.GetComponent<SpiderCombat>();

        CrowVar = Crow.GetComponent<SpiderCombat>();


        PlayerVar.MyTurn = true;


    }

    // Update is called once per frame
    void Update()
    {

        if (Test)
        {
            ChangeTurn();
            Test = false;
        }


    }

    
    
    
    
    void ChangeTurn()
    {
        if (CurrentTurn == "Player")
        {
            CurrentTurn = "Spider";
            
        }
        else if (CurrentTurn == "Spider")
        {
            CurrentTurn = "Crow";
            
        }
        else if (CurrentTurn == "Crow")
        {
            CurrentTurn = "Player";
            
        }

    }


}
