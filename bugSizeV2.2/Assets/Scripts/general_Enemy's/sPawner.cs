using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sPawner : MonoBehaviour
{
    public GameObject enemy;
    float random;
    Vector2 wheretoSpawn;
    public float right;
    public float left;
    public float spawnRate = 2f;
    float nextSpawn = 0f;
    bool encendido;
    void Update()
    {
        if (encendido == true)
        {
            if (Time.time > nextSpawn)
            {
                nextSpawn = Time.time + spawnRate;
                random = Random.Range(right, left);
                wheretoSpawn = new Vector2(random, transform.position.y);
                Instantiate(enemy, wheretoSpawn, Quaternion.identity);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name.Equals("Player"))
        {
            encendido = true;
        Debug.Log("Status " + encendido);
        }
    }
    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.name.Equals("Player"))
         {
        Debug.Log("Status " + encendido);
        encendido = false;
       }
    }
    void Start()
    {

    }
}
