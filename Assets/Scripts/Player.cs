using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Hp
    {
        get
        {
            return hp;
        }
        set
        {
            if (value > maxhp)
            {
                hp = maxhp;
            }
            if (value <= 0)
            {
                //»ç¸Á
                hp = 0;
            }
            else
            {
                hp = value;
            }

            //°»½Å
        }
    }
    public float hp;
    public float maxhp;

    public float Damage;

    public float Speed;

    public float AttackSpeed;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
