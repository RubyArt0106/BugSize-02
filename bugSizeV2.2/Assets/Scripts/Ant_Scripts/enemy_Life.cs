﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class enemy_Life : MonoBehaviour
{
    int numCure = 1;
    int numKill = 1;
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

    public AkEvent MuerteH;
    public AkEvent CuracionH;
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
        txt_num_Cured.noCured += numCure;
        if (tutorial)
        {
            MensajeCurar.gameObject.SetActive(true);
        }
        if(mun == true)
        {
            Instantiate(cure_Mun, transform.position, Quaternion.identity);
        }
        Instantiate(effecCured, transform.position, Quaternion.identity); ;
        Wwise_CuracionH();
        Destroy(gameObject);
    }
    void Muere()
    {
        txt_num_Killed.noKilled += numKill;
        if (tutorial)
        {
            MensajeMatar.gameObject.SetActive(true);
        }
        if (mun == true)
        {
            Instantiate(kill_Mun, transform.position, Quaternion.identity);
        }
        Instantiate(effectMuerte, transform.position, Quaternion.identity); ;
        Wwise_MuerteH();
        Destroy(gameObject);
    }
    void Wwise_CuracionH()
    {
        if (CuracionH != null)
        {
            CuracionH.HandleEvent(gameObject);
        }
    }
    void Wwise_MuerteH()
    {
        if (MuerteH != null)
        {
            MuerteH.HandleEvent(gameObject);
        }
    }
}
