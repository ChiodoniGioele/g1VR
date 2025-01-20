using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public GameObject door;
    private Rigidbody doorRigidbody;

    void Start()
    {
        doorRigidbody = door.GetComponent<Rigidbody>();

        doorRigidbody.constraints = RigidbodyConstraints.FreezeAll;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("openDoor"))
        {
            doorRigidbody.constraints = RigidbodyConstraints.None;

            door.SetActive(true);
        }
    }

    void Update()
    {

    }
}
