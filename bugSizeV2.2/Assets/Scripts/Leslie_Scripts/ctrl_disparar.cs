using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ctrl_disparar : MonoBehaviour
{
    
    
    private float tempoEntreDisparo;
    private Vector3 target;
    public Transform bulletPoint;

    public GameObject mirilla;
    public GameObject weapon;
    public GameObject bullet4Cure;
    public GameObject bullet4Kill;
    public float bulletSpeed;
    public float iniTempoEntreDisparo;
    /*___________Start________*/
    void Start()
    {
        Cursor.visible = false;
    }/*___________Start________*/

    /*_______Update___________*/
    void Update()
    {
        //Mirilla
        target = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z));
        mirilla.transform.position = new Vector2(target.x, target.y);
        //Rotacion
        Vector3 difference = target - weapon.transform.position;
        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        weapon.transform.rotation = Quaternion.Euler(0f, 0f, rotationZ);
        //Dispara
        if (Input.GetMouseButtonDown(0))
        {
            if (tempoEntreDisparo <= 0)
            {
                float distance = difference.magnitude;
                Vector2 direction = difference / distance;
                direction.Normalize();
                fireb2Kill(direction, rotationZ);
                tempoEntreDisparo = iniTempoEntreDisparo;
            }
            
        }
        else
        {
            tempoEntreDisparo -= Time.deltaTime;
        }
        if (Input.GetMouseButtonDown(1))
        {
            float distance = difference.magnitude;
            Vector2 direction = difference / distance;
            direction.Normalize();
            fireb2Heal(direction, rotationZ);
        }

    }/*_______Update___________*/

    /*________Disparar_________*/
    void fireb2Kill(Vector2 direction, float rotationZ)
    {
        if (txt_kill_Mun.noMunicion > 0)
        {
            txt_kill_Mun.noMunicion -= 1;
            GameObject b = Instantiate(bullet4Kill) as GameObject;
            b.transform.position = bulletPoint.transform.position;
            b.transform.rotation = Quaternion.Euler(0f, 0f, rotationZ);
            b.GetComponent<Rigidbody2D>().velocity = direction * bulletSpeed;
        }
    }
    void fireb2Heal(Vector2 direction, float rotationZ)
    {
        if (txt_cura_Mun.noMunicion > 0)
        {
            txt_cura_Mun.noMunicion -= 1;
            GameObject b = Instantiate(bullet4Cure) as GameObject;
            b.transform.position = bulletPoint.transform.position;
            b.transform.rotation = Quaternion.Euler(0f, 0f, rotationZ);
            b.GetComponent<Rigidbody2D>().velocity = direction * bulletSpeed;
        }
    }/*________Disparar_________*/
}
