using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingCinematic : MonoBehaviour
{
    public GameObject creditCanvas;
    public float cinematicTime;
    private float waitTime; //tempo a esperar para tornar o canvas ativo.

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        creditCanvas.SetActive(false);
        waitTime = cinematicTime;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(waitTime >= 0)
        {
            waitTime -= Time.deltaTime;
        }
        else
        {
            creditCanvas.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.lockState = CursorLockMode.Confined;

            if(Input.GetKeyDown(KeyCode.E))
            {
                SceneManager.LoadScene("Menu");

            }
        }
    }
}
