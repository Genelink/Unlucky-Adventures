using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingDebug : MonoBehaviour
{
    KnightCombat KC;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        KC = GetComponent<KnightCombat>();
        
    }
}
