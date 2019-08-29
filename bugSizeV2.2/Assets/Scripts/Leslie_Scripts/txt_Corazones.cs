using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class txt_Corazones : MonoBehaviour
{
    public int corazonTaken;

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
                Debug.Log("Healed");
                player.TakeCorazon(corazonTaken);
                Destroy(gameObject);

            }
        }

    }

}
