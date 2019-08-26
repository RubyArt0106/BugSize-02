using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala_Behaviour : MonoBehaviour
{
    public int damage;
    public GameObject impacto;
    private void OnTriggerEnter2D(Collider2D hitInfo)
    {//Llama al script
        enemy_Life enemy = hitInfo.GetComponent<enemy_Life>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        Instantiate(impacto, transform.position, transform.rotation);
        Destroy(gameObject);
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

}
