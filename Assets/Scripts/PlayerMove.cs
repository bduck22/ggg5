using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float Speed;
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Vertical"))
        {
            transform.Translate(0, 0, Speed * Input.GetAxis("Vertical") * Time.deltaTime);
        }

        if (Input.GetButton("Horizontal"))
        {
            transform.Translate(Speed * Input.GetAxis("Horizontal") * Time.deltaTime, 0, 0);
        }
    }
}
