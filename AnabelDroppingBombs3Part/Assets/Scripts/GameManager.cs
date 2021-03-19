using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    //Private Spawner Object
    private Spawner spawner;
    //public GameObject title;
    //private Vector2 screenBounds;
    //public GameObject playerPrefab;
    //private GameObject player;
    //private bool gameStarted = false;
    //public GameObject splash;
    //public GameObject scoreSystem;
    //public Text scoreText;
    //public int pointsWorth = 1;
    //private int score;
    void Start()
    {
        spawner.active = false;
        //title.SetActive(true);
        //splash.SetActive(false);
    }
    void Awake()
    {
        spawner = GameObject.Find("Spawner").GetComponent<Spawner>();
        //screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        //player = playerPrefab;
        //scoreText.enabled = false;
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.anyKeyDown)
        {
            spawner.active = true;
            //title.SetActive(false);
        }
        //var nextBomb = GameObject.FindGameObjectsWithTag("Bomb");
        /*foreach(GameObject bombObject in nextBomb)
        {
            if(bombObject.transform.position.y < (-screenBounds.y) - 12 || !gameStarted)
            {
                Destroy(bombObject);
            } else if(bombObject.transform.position.y < (-SscreenBounds.y) && gameStarted)
            {
                scoreSystem.GetComponent<Score>().AddScore(pointsWorth);
                Destroy(bombObject);
            }
        }*/
        /*if(!gameStarted)
        {
            if(Input.anyKeyDown)
            {
                ResetGame();
            }
        } else
        {
            if(!player)
            {
                OnPlayerKilled();
            }
        }    */
    
    }
    /*void ResetGame()
    {
        spawner.active = true;
        //title.SetActive(false);
        //player = Instantiate(playerPrefab, new Vector3(0, 0, 0), playerPrefab.transform.rotation);
        gameStarted = true;
        splash.SetActive(false);
        scoreText.enabled = true;
        scoreSystem.GetComponent<Score>().score = 0;
        scoreSystem.GetComponent<Score>().Start();
    /*void OnPlayerKilled()
    {
        spawner.active = false;
        gameStarted = false;
        splash.SetActive(true);
    }*/
}
