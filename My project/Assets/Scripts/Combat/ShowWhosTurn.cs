using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowWhosTurn : MonoBehaviour
{
    Text textchange;
    public GameObject TurnCounter;
    Turns TurnCounterVar;

    // Start is called before the first frame update
    void Start()
    {
        textchange = GetComponent<Text>();
        
    }

    // Update is called once per frame
    void Update()
    {
        TurnCounterVar = TurnCounter.GetComponent<Turns>();

        textchange.text = TurnCounterVar.CurrentTurn;   
    }
}
