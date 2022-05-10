using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChargedStrike : MonoBehaviour
{
    public GameObject Player;
    KnightCombat PlayerVar;
    [SerializeField] GameObject Tension;
    TensionBar TensionBar;
    



    TouchInput TouchInput;
    MouseInput MouseInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TouchInput = GetComponent<TouchInput>();
        MouseInput = GetComponent<MouseInput>();
        TensionBar = Tension.GetComponent<TensionBar>();

        if (TouchInput.TouchBegan | MouseInput.MouseClicked)
        {
            PlayerVar = Player.GetComponent<KnightCombat>();
            PlayerVar.ChargedAttack = true;
            TensionBar.RemoveTension();
        }
    }
}
