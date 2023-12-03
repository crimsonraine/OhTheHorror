using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{

    public bool canMove;

    public TextMeshProUGUI welcomeText;
    public TextMeshProUGUI storyText;
    public Button nextBtn;


    public TextMeshProUGUI instructionsTitle;
    public TextMeshProUGUI instruction1;
    public TextMeshProUGUI instruction2;
    public TextMeshProUGUI instruction3;
    public Button startBtn;

    // Start is called before the first frame update
    void Start()
    {
        // Cursor.visible = true;
        // Cursor.lockState = CursorLockMode.None;
        // canMove = false;
        
        // welcomeText.gameObject.SetActive(true);
        // storyText.gameObject.SetActive(true);
        // nextBtn.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // called by nextBtn
    // public void DisplayInstructions(){
    //     // removing previous UI Elements
    //     welcomeText.gameObject.SetActive(false);
    //     storyText.gameObject.SetActive(false);
    //     nextBtn.gameObject.SetActive(false);

    //     // adding new UI Elements
    //     instructionsTitle.gameObject.SetActive(true);
    //     instruction1.gameObject.SetActive(true);
    //     instruction2.gameObject.SetActive(true);
    //     instruction3.gameObject.SetActive(true);
    //     startBtn.gameObject.SetActive(true);
    // }

    // // called by startBtn
    // public void RemoveInstructions(){

    //     canMove = true;

    //     // removing previous UI Elements
    //     instructionsTitle.gameObject.SetActive(false);
    //     instruction1.gameObject.SetActive(false);
    //     instruction2.gameObject.SetActive(false);
    //     instruction3.gameObject.SetActive(false);
    //     startBtn.gameObject.SetActive(false);
    // }

    
}
