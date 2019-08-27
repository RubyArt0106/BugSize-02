using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ctrl_bullet_2cure : MonoBehaviour
{
    public int medi;
    public GameObject impacto;
    private void OnTriggerEnter2D(Collider2D hitInfo)
    {//Llama al script
        enemy_Life enemy = hitInfo.GetComponent<enemy_Life>();
        enemy_Lifev2 enem = hitInfo.GetComponent<enemy_Lifev2>();
        if (enemy != null)
        {
            enemy.GitGud(medi);
        }
        if (enem != null)
        {
            enem.GitGud(medi);
        }
        Instantiate(impacto, transform.position, transform.rotation);
        Destroy(gameObject);
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
