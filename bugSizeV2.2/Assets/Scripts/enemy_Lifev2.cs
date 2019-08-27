using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_Lifev2 : MonoBehaviour
{
    public int health;
    public int infection;
    public bool mun = false;

    public GameObject cure_Mun;
    public GameObject kill_Mun;
    public GameObject effectCured;
    public GameObject effectMuerte;

    public void GitGud(int med)
    {
        infection -= med;
        if (infection <= 0)
        {
            Curado();
        }
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Muere();
        }
    }

    void Curado()
    {
        if (mun == true)
        {
            Instantiate(cure_Mun, transform.position, Quaternion.identity);
        }
        Instantiate(effectCured, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    void Muere()
    {
        if (mun == true)
        {
            Instantiate(kill_Mun, transform.position, Quaternion.identity);
        }
        Instantiate(effectMuerte, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
