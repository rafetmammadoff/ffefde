using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CASP.CameraManager;

public class TestScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)) {
            // CameraManager.instance.OpenCamera("CM_ExtraCamera");
            CameraManager.instance.OpenCamera("CM_ExtraCamera", 2, CameraEaseStates.Linear);
        }
        if (Input.GetKeyDown(KeyCode.W)) {
            // CameraManager.instance.OpenCamera("CM_MainCamera");
            CameraManager.instance.OpenCamera("CM_MainCamera", 0.5f, CameraEaseStates.EaseInOut);
        }
    }
}
