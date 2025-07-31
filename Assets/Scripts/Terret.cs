using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Terret : MonoBehaviour
{
    public Enemy Target;

    public float Hp
    {
        get
        {
            return hp;
        }
        set
        {
            if(value > maxhp)
            {
                hp = maxhp;
            }
            if(value <= 0)
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

    public float Power;
    public float AttackSpeed;
    public float AttackDelay;

    public float time=1;
    public float delaytime = 0;

    public bool stop;

    public bool Invin;
    void Start()
    {
        
    }
    void Update()
    {
        if (!stop)
        {
            if (Target)
            {
                if (delaytime >= AttackDelay)
                {
                    if (time >= 1)
                    {
                        Attack();
                        time = 0;
                    }
                    time += Time.deltaTime * AttackSpeed;
                }
                else
                {
                    delaytime += Time.deltaTime;
                }
            }
            else
            {
                delaytime = 0;
                time = 1;
            }
        }
    }
    private void Attack()
    {
        Debug.Log("Attack");
        Target.Hp -= Power;
    }
}
