using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class life_Cured : MonoBehaviour
{
    public int health;

    public GameObject kill_Mun;
    public GameObject effectMuerte;

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
        Instantiate(kill_Mun, transform.position, Quaternion.identity);
        Instantiate(effectMuerte, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
