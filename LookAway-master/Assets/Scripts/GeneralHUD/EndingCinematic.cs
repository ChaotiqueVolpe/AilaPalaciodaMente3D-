using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingCinematic : MonoBehaviour
{
    public GameObject creditCanvas;
    public float cinematicTime;
    private float waitTime; //tempo a esperar para tornar o canvas ativo.

    // Start is called before the first frame update
    void Start()
    {
        creditCanvas.SetActive(false);
        waitTime = cinematicTime;
    }

    // Update is called once per frame
    void Update()
    {
        if(waitTime >= 0)
        {
            waitTime -= Time.deltaTime;
        }
        else
        {
            creditCanvas.SetActive(true);
        }

    }
}
