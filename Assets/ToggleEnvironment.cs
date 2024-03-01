using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleEnvironment : MonoBehaviour
{
    public GameObject Postprocess;
    public GameObject Camera2;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            if(Camera2.activeSelf == true)
            {
                Camera2.SetActive(false);
            }
            else
            {
                Camera2.SetActive(true);
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (Postprocess.activeSelf == true)
            {
                Postprocess.SetActive(false);
            }
            else
            {
                Postprocess.SetActive(true);
            }
        }
    }
}
