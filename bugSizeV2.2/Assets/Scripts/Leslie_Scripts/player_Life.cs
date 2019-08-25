using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class player_Life : MonoBehaviour
{
    float timer = 0.5f;
    public int health;
    public int numHearths;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite voidHeart;

    private Animator anim;
    //public GameObject effctMuerte;   <_Para el sprite de muerte
    public void TakeDamage(int damageGiven)
    {
        health -= damageGiven;
        Debug.LogWarning("Daño");
        anim.SetBool("isDamage", true);
        if (timer >= 0)
        {
            timer -= Time.deltaTime;
            anim.SetBool("isDamage", false);
            timer = 0.5f;
        }
        if (health <= 0)
        {
            Debug.LogWarning("Muerte");
            //Muere();
        }

    }
    /*void Muere()
    {
        Instantiate(effectMuerte, transform.position, Quaternion.identity); ;
        Destroy(gameObject);
    }*/

    void Update()
    {
        int i;
        //Evita que tenga mas vida que los corazones
        if (health > numHearths)
        {
            health = numHearths;
        }
        //Control de corazones 
        for (i = 0; i < hearts.Length; i++)
        {
            if (i < health)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = voidHeart;
            }
            if (i < numHearths)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
    }
    void Start()
    {
        anim = GetComponent<Animator>();
    }
}
