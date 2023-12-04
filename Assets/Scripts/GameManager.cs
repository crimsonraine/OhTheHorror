using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{

    public int balloonCounter = 0;
    public GameObject enemy;
    public GameObject player;

    public int proximityMeterFill;
    public float dist;
    private float teleportRate = 20.0f;
    public float teleportDist = 10f;
    public bool canMove;


    
    public bool isGameActive;
    public bool isTeleporting = false;

    public TextMeshProUGUI welcomeText;
    public TextMeshProUGUI storyText;
    public Button nextBtn;


    public TextMeshProUGUI instructionsTitle;
    public TextMeshProUGUI instruction1;
    public TextMeshProUGUI instruction2;
    public TextMeshProUGUI instruction3;
    public TextMeshProUGUI instruction4;
    public Button startBtn;

    public TextMeshProUGUI balloonsFound;
    public TextMeshProUGUI sanityLevel;

    // public DetectCollision detectCollision;

    public bool zombieCollide;
    public bool balloonCollide;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        canMove = false;

        welcomeText.gameObject.SetActive(true);
        storyText.gameObject.SetActive(true);
        nextBtn.gameObject.SetActive(true);

        dist = Vector3.Distance(player.transform.position, enemy.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        dist = Vector3.Distance(player.transform.position, enemy.transform.position);
        sanityLevel.SetText($"Sanity Level: {dist}");
    }

    void StartTeleporting()
    {
        StartCoroutine(TeleportEnemy());
        // balances the game in case player gets caught in room
    }

    IEnumerator TeleportEnemy()
    {
        while (true)
        {
            yield return new WaitForSeconds(teleportRate);

            // Vector3 teleportPosition = new Vector3(
            //     player.transform.position.x + Random.Range(-teleportDist, teleportDist),
            //     player.transform.position.y,
            //     player.transform.position.z + Random.Range(-teleportDist, teleportDist)
            // );
            
            enemy.transform.position = new Vector3(0f, 4f, 12f);
        }
    }

    // called by nextBtn
    public void DisplayInstructions()
    {
        // removing previous UI Elements
        welcomeText.gameObject.SetActive(false);
        storyText.gameObject.SetActive(false);
        nextBtn.gameObject.SetActive(false);

        // adding new UI Elements
        instructionsTitle.gameObject.SetActive(true);
        instruction1.gameObject.SetActive(true);
        instruction2.gameObject.SetActive(true);
        instruction3.gameObject.SetActive(true);
        instruction4.gameObject.SetActive(true);
        startBtn.gameObject.SetActive(true);
    }

    // called by startBtn
    public void RemoveInstructions()
    {

        canMove = true;

        // removing previous UI Elements
        instructionsTitle.gameObject.SetActive(false);
        instruction1.gameObject.SetActive(false);
        instruction2.gameObject.SetActive(false);
        instruction3.gameObject.SetActive(false);
        instruction4.gameObject.SetActive(false);
        startBtn.gameObject.SetActive(false);

        // adding new UI Elements
        balloonsFound.gameObject.SetActive(true);
        sanityLevel.gameObject.SetActive(true);

        isGameActive = true;
        Invoke("StartTeleporting", 10.0f);
    }


}
