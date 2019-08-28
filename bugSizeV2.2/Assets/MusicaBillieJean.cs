using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicaBillieJean : MonoBehaviour
{

    public AkEvent BillieJean;


    // Start is called before the first frame update
    void Start()
    {
        Wwise_BillieJean();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Wwise_BillieJean()
    {
        if (BillieJean != null)
        {
            BillieJean.HandleEvent(gameObject);
        }
    }
}
