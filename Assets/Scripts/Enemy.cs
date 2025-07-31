using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
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

    public float Intersection;

    public Transform Target;

    public float LoadTime;
    void Start()
    {
        LoadTime = Random.Range(0.1f, 0.3f);
        time = LoadTime;
    }

    public float time;

    public float attacktime = 0;
    void Update()
    {
        if (time >= LoadTime)
        {
            TargetLoad();
        }
        else time += Time.deltaTime;

        if (Target)
        {
            if (Vector3.Distance(transform.position, Target.position) <= Intersection)
            {
                if (attacktime >= 1)
                {
                    attacktime = 0;
                    Attack();
                }
                else
                {
                    attacktime += Time.deltaTime * AttackSpeed;
                }
            }
            else transform.position = Vector3.MoveTowards(transform.position, Target.position, Speed * Time.deltaTime);
        }
    }
    public void TargetLoad()
    {
        time = 0;
        foreach (GameObject t in GameObject.FindGameObjectsWithTag("Object"))
        {
            if (!Target)
            {
                Target = t.transform.parent;
            }
            else if (t.transform.parent != Target)
            {
                if (Vector3.Distance(transform.position, t.transform.position) < Vector3.Distance(transform.position, Target.position))
                {
                    Target = t.transform.parent;
                }
            }
        }
    }
    public void Attack()
    {
        if (Target.GetComponent<Terret>())
        {
            Target.GetComponent<Terret>().Hp -= Damage;
        }
        else if (Target.GetComponent<Player>())
        {
            Target.GetComponent<Player>().Hp -= Damage;
        }
        else
        {

        }
    }
}
