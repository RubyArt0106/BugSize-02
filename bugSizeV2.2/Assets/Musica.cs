using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musica : MonoBehaviour
{

    public AkEvent Billie;

    // Start is called before the first frame update
    void Start()
    {
        Wwise_Billie();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Wwise_Billie()
    {
        if (Billie != null)
        {
            Billie.HandleEvent(gameObject);
        }
    }

}
