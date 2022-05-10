using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TensionBar : MonoBehaviour
{
    public int Tension = 0; 
    
    Animator Animator;
    // Start is called before the first frame update
    void Start()
    {
        Animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Animator.SetInteger("Tension", Tension);
    }
    public void AddTension()
    {
        Tension = 1;
    }

    public void RemoveTension()
    {
        Tension = 0;
    }
}
