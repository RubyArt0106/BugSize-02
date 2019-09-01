using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_Lifev2 : MonoBehaviour
{
    int numCure = 1;
    int numKill = 1;
    public int health;
    public int infection;
    public bool mun = false;

    public GameObject cure_Mun;
    public GameObject kill_Mun;
    public GameObject effectCured;
    public GameObject effectMuerte;

    public AkEvent MuerteC;
    public AkEvent CuracionC;

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
        txt_num_Cured.noCured += numCure;
        if (mun == true)
        {
            Instantiate(cure_Mun, transform.position, Quaternion.identity);
        }
        Instantiate(effectCured, transform.position, Quaternion.identity);
        Wwise_CuracionC();
        Destroy(gameObject);
    }

    void Muere()
    {
        txt_num_Killed.noKilled += numKill;
        if (mun == true)
        {
            Instantiate(kill_Mun, transform.position, Quaternion.identity);
        }
        Instantiate(effectMuerte, transform.position, Quaternion.identity);
        Wwise_MuerteC();
        Destroy(gameObject);
    }

    void Wwise_CuracionC()
    {
        if (CuracionC != null)
        {
            CuracionC.HandleEvent(gameObject);
        }
    }
    void Wwise_MuerteC()
    {
        if(MuerteC != null)
        {
            MuerteC.HandleEvent(gameObject);
        }
    }


}
