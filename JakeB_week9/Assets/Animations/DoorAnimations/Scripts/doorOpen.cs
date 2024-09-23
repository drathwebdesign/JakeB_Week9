using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorOpen : MonoBehaviour {
    public Transform player;
    private Animator anim;
    public GameObject doorTooltip;
    public float triggerDistance = 3;


    void Start() {
        anim = GetComponent<Animator>();
    }


    void Update() {
        DoorOpen();
    }

    void DoorOpen() {
        if (Vector3.Distance(transform.position, player.position) < triggerDistance) {
            doorTooltip.SetActive(true);
            if (Input.GetKeyDown(KeyCode.F)) {
                anim.SetBool("IsOpen", true);
                doorTooltip.SetActive(false);
            }
        } else {
            // Hides tooltip and close door
            anim.SetBool("IsOpen", false);
            doorTooltip.SetActive(false);
        }
    }
}