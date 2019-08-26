using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class enemy_Life : MonoBehaviour
{
    public int health;
    public int infection;
    public bool mun = false;
    public bool tutorial = false;
    public Flowchart MensajeMatar;
    public Flowchart MensajeCurar;

    public GameObject cure_Mun;
    public GameObject kill_Mun;
    public GameObject effecCured;
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
        if(health <= 0)
        {
            Muere();
        }
    }

    void Curado()
    {
        if (tutorial)
        {
            MensajeCurar.gameObject.SetActive(true);
        }
        if(mun == true)
        {
            Instantiate(cure_Mun, transform.position, Quaternion.identity);
        }
        Instantiate(effecCured, transform.position, Quaternion.identity); ;
        Destroy(gameObject);
    }
    void Muere()
    {
        if(tutorial)
        {
            MensajeMatar.gameObject.SetActive(true);
        }
        if (mun == true)
        {
            Instantiate(kill_Mun, transform.position, Quaternion.identity);
        }
        Instantiate(effectMuerte, transform.position, Quaternion.identity); ;
        Destroy(gameObject);
    }
}
