using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayersHealthDisplay : MonoBehaviour
{
    Text textchange;
    public GameObject Player;
    KnightCombat PlayerVar;

    // Start is called before the first frame update
    void Start()
    {
        textchange = GetComponent<Text>();
        PlayerVar = Player.GetComponent<KnightCombat>();
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerVar = Player.GetComponent<KnightCombat>();
        textchange.text = "Health: " + PlayerVar.Health + "/" + PlayerVar.maxHealth ;
    }
}
