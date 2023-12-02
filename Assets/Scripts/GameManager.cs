using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI titleText;
    public Button beginBtn;

    public TextMeshProUGUI welcomeText;
    public TextMeshProUGUI storyText;
    public Button nextBtn;


    public Button startGameBtn;

    // Start is called before the first frame update
    void Start()
    {
        titleText.gameObject.SetActive(true);
        beginBtn.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // called by startBtn
    public void DisplayStory(){
        // removing previous UI Elements
        titleText.gameObject.SetActive(false);
        beginBtn.gameObject.SetActive(false);

        // adding new UI Elements
        welcomeText.gameObject.SetActive(true);
        storyText.gameObject.SetActive(true);
        nextBtn.gameObject.SetActive(true);
    }

    // called by nextBtn
    public void DisplayInstructions(){
        // removing previous UI Elements
        welcomeText.gameObject.SetActive(true);
        storyText.gameObject.SetActive(true);
        nextBtn.gameObject.SetActive(true);

        // adding new UI Elements
    }

    
}
