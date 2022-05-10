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

    bool ChangeTurnDone;

    TensionBar TensionBar;



    // Start is called before the first frame update
    void Start()
    {
        PlayerVar = Player.GetComponent<KnightCombat>();

        SpiderVar = Spider.GetComponent<SpiderCombat>();

        CrowVar = Crow.GetComponent<SpiderCombat>();

        TensionBar = GetComponent<TensionBar>();


        PlayerVar.MyTurn = true;


    }

    // Update is called once per frame
    void Update()
    {

        if (Test)
        {
            Test = false;
            ChangeTurn();
            
        }


    }

    
    
    
    
    public void ChangeTurn()
    {
        ChangeTurnDone = false;

        while (ChangeTurnDone == false)
        {
            if (CurrentTurn == "Spider")
            {
                CurrentTurn = "Crow";
                
                

                PlayerVar.MyTurn = false;
                SpiderVar.MyTurn = false;
                CrowVar.MyTurn = true;

                ChangeTurnDone = true;
                break;
            
            }

            else if (CurrentTurn == "Player")
            {
                CurrentTurn = "Spider";
                PlayerVar.MyTurn = false;
                SpiderVar.MyTurn = true;
                CrowVar.MyTurn = false;
                
                ChangeTurnDone = true;
                break;
            
            }
        
            else if (CurrentTurn == "Crow")
            {
                TensionBar.AddTension();

                CurrentTurn = "Player";
                PlayerVar.MyTurn = true;
                SpiderVar.MyTurn = false;
                CrowVar.MyTurn = false;
                
                ChangeTurnDone = true;
                break;
            }
        }

    }

}
