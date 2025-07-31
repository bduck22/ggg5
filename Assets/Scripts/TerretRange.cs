using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerretRange : MonoBehaviour
{
    public Terret terret;
    void Start()
    {
        terret = transform.parent.GetComponent<Terret>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            if (terret.Target != null)
            {
                if (Vector3.Distance(transform.position, other.transform.parent.position) < Vector3.Distance(transform.position, terret.Target.transform.position))
                {
                    terret.Target = other.transform.parent.GetComponentInChildren<Enemy>();
                }
            }
            else
            {
                terret.Target = other.transform.parent.GetComponentInChildren<Enemy>();
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            if (terret.Target == other.transform.parent.GetComponentInChildren<Enemy>())
            {
                terret.Target = null;
            }
        }
    }
}
