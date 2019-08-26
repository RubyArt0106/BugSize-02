using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ctrl_Municion : MonoBehaviour
{
    public bool kill = false;
    public int numMun_Cure;
    public int numMun_Kill;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag.Equals("Player"))
        {
            if(kill == false)
            {
                txt_cura_Mun.noMunicion += numMun_Cure;
                Destroy(gameObject);
            }
            else
            {
                txt_kill_Mun.noMunicion += numMun_Kill;
                Destroy(gameObject);
            }
        }
    }
}
