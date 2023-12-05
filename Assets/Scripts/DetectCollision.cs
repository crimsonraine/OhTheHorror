using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DetectCollision : MonoBehaviour
{

    public GameManager gameManager;
    public BalloonSFX balloonSFX;
    public string won = "won";
    public string lost = "lost";
    public string game = "game";

    public delegate void ObjCollide();
    ObjCollide objCollide;


    void Start()
    {
        objCollide = null;
    }

    void Update()
    {

    }

    public void BalloonCollision(Collider other)
    {
        if (other.gameObject != null)
        {
            Destroy(other.gameObject);
        }

        gameManager.balloonCounter += 1;

        string msg = $"Balloons Found: {gameManager.balloonCounter}/5";
        gameManager.balloonsFound.SetText(msg);
        balloonSFX.playBalloonSFX();


        if (gameManager.balloonCounter == 5){
            Debug.Log("Game over; you won!");
            gameManager.isGameActive = false;
            objCollide += loadWonScreen;
            objCollide();
        }
        
    }

    public void ZombieCollision(Collider other)
    {
        Debug.Log("Game over; you lost");
        gameManager.isGameActive = false;

        // DELEGATE
        objCollide += loadLostScreen;
        objCollide();

    }

    void loadWonScreen()
    {
        SceneManager.LoadScene(won);
    }

    void loadLostScreen()
    {
        SceneManager.LoadScene(lost);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Debug.Log("zc detected");
            // collider = other;
            // collide += ZombieCollision;
            ZombieCollision(other);
        } 
        else if (other.CompareTag("Balloon"))
        {
            // collider = other;
            // collide += BalloonCollision;
            BalloonCollision(other);
        }
    }
}



