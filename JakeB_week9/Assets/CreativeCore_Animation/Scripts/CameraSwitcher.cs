using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public CinemachineVirtualCamera vm1, vm2, vm3;
    void Start()
    {
    }

    void Update()
    {
       // CameraSwap();
    }

    void CameraSwap() {
        if (Input.GetKeyDown(KeyCode.Q)) {
            vm1.Priority = 10;
            vm2.Priority = 9;
            vm3.Priority = 9;
        }

        if (Input.GetKeyDown(KeyCode.W)) {
            vm1.Priority = 9;
            vm2.Priority = 10;
            vm3.Priority = 9;
        }

        if (Input.GetKeyDown(KeyCode.E)) {
            vm1.Priority = 9;
            vm2.Priority = 9;
            vm3.Priority = 10;
        }
    }
}