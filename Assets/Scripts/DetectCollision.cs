using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DetectCollision : MonoBehaviour
{

    public GameManager gameManager;
    public string won = "won";
    public string lost = "lost";
    public string game = "game";

    void Start()
    {

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


        if (gameManager.balloonCounter == 5){
            Debug.Log("Game over; you won!");
            gameManager.isGameActive = false;
            SceneManager.LoadScene(won);
        }
    }

    public void ZombieCollision(Collider other)
    {
        Debug.Log("Game over; you lost");
        gameManager.isGameActive = false;

        SceneManager.LoadScene(lost);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            ZombieCollision(other);
        } 
        else if (other.CompareTag("Balloon"))
        {
            BalloonCollision(other);
        }
    }
}



