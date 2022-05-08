using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardMouse : MonoBehaviour
{
    public float speed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var step =  speed * Time.deltaTime;
        
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            touchPosition.z = 0f;
            transform.position = Vector3.MoveTowards(transform.position, touchPosition, step);
            



        }
    }
}
