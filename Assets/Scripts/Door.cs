using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameManager gameManager;
    private float baseRotation;
    public bool interactable;

    void Start()
    {
        baseRotation = transform.rotation.eulerAngles.y;
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            // gameManager.setDoorInstruction(true);
            interactable = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            // gameManager.setDoorInstruction(false);
            interactable = false;
        }
    }
    void Update()
    {
        if (interactable == true && Input.GetKeyDown(KeyCode.F))
        {
            if (transform.rotation.eulerAngles.y == baseRotation)
            {
                Debug.Log(transform.rotation.eulerAngles.y);
                Debug.Log(baseRotation);
                transform.Rotate(new Vector3(0, 90, 0));
            }
            else
            {
                transform.Rotate(new Vector3(0, -90, 0));
            }
        }
    }

}