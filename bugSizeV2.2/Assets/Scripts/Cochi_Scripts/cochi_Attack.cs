using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cochi_Attack : MonoBehaviour
{
    public int damageGiven;
    public GameObject aCheck;
    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name.Equals("Player"))
        {
            player_Life player = col.GetComponent<player_Life>();
            cochi_Follow cochi_Rol = col.GetComponent<cochi_Follow>();
            if (player != null)
            {
                Debug.Log("Attack_true");

                anim.SetBool("isAttack", true);

                player.TakeDamage(damageGiven);

            }
        }

    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.name.Equals("Player"))
        {
            Debug.Log("Attack_false");
            anim.SetBool("isAttack", false);
        }
    }
}
