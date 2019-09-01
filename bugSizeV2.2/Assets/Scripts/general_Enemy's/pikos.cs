using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pikos : MonoBehaviour
{
    public int damageGiven;

    void Start()
    {
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name.Equals("Player"))
        {
            player_Life player = col.GetComponent<player_Life>();
            if (player != null)
            {
                Debug.Log("Attack_true");
                player.TakeDamage(damageGiven);

            }
        }

    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.name.Equals("Player"))
        {
            Debug.Log("Attack_false");
        }
    }

}
