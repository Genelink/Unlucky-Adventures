using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TensionCheck : MonoBehaviour
{
    [SerializeField] int CheckingFor;
    [SerializeField] GameObject TensionBarGO;
    TensionBar TensionBar;
    Animator Animator;
    public bool EnoughTension = false;
    // Start is called before the first frame update
    void Start()
    {
        Animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        TensionBar = TensionBarGO.GetComponent<TensionBar>();

        if (TensionBar.Tension >= CheckingFor)
        {
            Animator.SetBool("EnoughTension", true);
            EnoughTension = true;
        }
        else
        {
            Animator.SetBool("EnoughTension", false);
            EnoughTension = false;
        }

            
    }
}
