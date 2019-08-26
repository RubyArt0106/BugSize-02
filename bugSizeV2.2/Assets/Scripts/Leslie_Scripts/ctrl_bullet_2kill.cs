using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ctrl_bullet_2kill : MonoBehaviour
{
    public int damage;
    public GameObject impacto;
    private void OnTriggerEnter2D(Collider2D hitInfo)
    {//Llama al script
        enemy_Life enemy = hitInfo.GetComponent<enemy_Life>();
        life_Cured amigo = hitInfo.GetComponent<life_Cured>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        if (amigo != null)
        {
            amigo.TakeDamage(damage);
        }
        Instantiate(impacto, transform.position, transform.rotation);
        Destroy(gameObject);
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
