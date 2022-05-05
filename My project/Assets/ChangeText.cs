using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{
    Text textchange;
    public GameObject Spider;
    SpiderCombat SpiderVar;

    // Start is called before the first frame update
    void Start()
    {
        textchange = GetComponent<Text>();
        SpiderVar = Spider.GetComponent<SpiderCombat>();
        
    }

    // Update is called once per frame
    void Update()
    {
        SpiderVar = Spider.GetComponent<SpiderCombat>();
        textchange.text = "Health: " + SpiderVar.Health + "/" + SpiderVar.maxHealth ;
    }
}
