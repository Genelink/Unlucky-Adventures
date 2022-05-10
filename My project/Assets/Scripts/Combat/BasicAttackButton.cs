using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicAttackButton : MonoBehaviour
{
    Collider2D col;
    public GameObject Player;
    KnightCombat PlayerVar;
    GameObject[] SelectedEnemey;

    [SerializeField] Animator Animation;

    TouchInput TouchInput;
    MouseInput MouseInput;
    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        TouchInput = GetComponent<TouchInput>();
        MouseInput = GetComponent<MouseInput>();
        
        SelectedEnemey = GameObject.FindGameObjectsWithTag("Selected Enemy");

        if (SelectedEnemey.Length >= 1)
        {
            Animation.SetBool("CanAttack", true);
        }
        else
        {
            Animation.SetBool("CanAttack", false);
        }
        



        if (TouchInput.TouchBegan | MouseInput.MouseClicked)
        {
            PlayerVar = Player.GetComponent<KnightCombat>();
            PlayerVar.BasicAttack = true;
        }
    }
}
