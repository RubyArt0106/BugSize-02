using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_Attack : MonoBehaviour
{
    public int damageGiven;
    public GameObject aCheck;
    private Animator anim;

    public AkEvent AtaqueH;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name.Equals("Player"))
        {
            player_Life player = col.GetComponent<player_Life>();
            if (player != null)
            {
                Debug.Log("Attack_true");
                anim.SetBool("isAttack", true);
                player.TakeDamage(damageGiven);
                Wwise_AtaqueH();
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

    void Wwise_AtaqueH()
    {
        if(AtaqueH != null)
        {
            AtaqueH.HandleEvent(gameObject);
        }
    }
}
