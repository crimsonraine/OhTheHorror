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
            interactable = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            interactable = false;
        }
    }

    void Open() {
        transform.Rotate(new Vector3(0, 90, 0));
    }

    void Close() {
        transform.Rotate(new Vector3(0, -90, 0));
    }

    void Update()
    {
        if (interactable == true && Input.GetKeyDown(KeyCode.F))
        {
            if (transform.rotation.eulerAngles.y == baseRotation)
            {
                Open();
            }
            else
            {
                Close();
            }
        }
    }

}