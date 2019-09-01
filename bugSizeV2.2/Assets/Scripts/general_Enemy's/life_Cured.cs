using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class life_Cured : MonoBehaviour
{
    public int health;

    public GameObject kill_Mun;
    public GameObject effectMuerte;

    int numKill = 1;
    public void TakeDamage(int damage)
    {
        health -= damage;
        if(health <= 0)
        {
            Muere();
        }
    }

    void Muere()
    {
        txt_num_Killed.noKilled += numKill;
        txt_num_Cured.noCured -= numKill;
        Instantiate(kill_Mun, transform.position, Quaternion.identity);
        Instantiate(effectMuerte, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
