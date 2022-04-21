using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicAttackButton : MonoBehaviour
{
    Collider2D col;
    public GameObject Player;
    KnightCombat PlayerVar;
    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            
            if (touch.phase == TouchPhase.Began)
            {
                Collider2D touchedCollider = Physics2D.OverlapPoint(touchPosition);
                if (col == touchedCollider)
                {
                    PlayerVar = Player.GetComponent<KnightCombat>();
                    PlayerVar.SwingButton = true;
                }
            }
        }
    }
}
