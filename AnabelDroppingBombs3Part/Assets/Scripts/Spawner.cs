using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    //Bomb Prefab Game Object
    public GameObject bombPrefab;
    //This variable is the delay of how long it takes to spawn the bomb. The value of the delay variable given here is the default.
    public float delay = 2.0f;
    //Checks if spawner is active
    public bool active = true;
    //Delay range
    public Vector2 delayRange = new Vector2(1, 2);
    //The private variable for the screen boundaries.
    private Vector2 screenBounds;
    //The private variables for the bombPrefab object's height and width
    private float objectWidth;
    private float objectHeight;
    void Start()
    {
        ResetDelay();
        StartCoroutine(EnemyGenerator());
    }
    IEnumerator EnemyGenerator() {
        yield return new WaitForSeconds(delay);
        //Random X is the random x coordinate value. Spawn Y is the y value that the object will spawn at. Reset Delay is pretty self explanatory. It basically resets the delay to a random range of the delay range x coordinate as well as y
        if(active)
        {
            float randomX = Random.Range(screenBounds.x - objectWidth, screenBounds.x * -1 + objectWidth);
            float spawnY = (screenBounds.y + objectHeight) + 5;
            Instantiate(bombPrefab, new Vector3(randomX, spawnY, 0), bombPrefab.transform.rotation);
            ResetDelay();
            screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
            objectWidth = bombPrefab.GetComponent<MeshRenderer>().bounds.size.x / 2;
            objectHeight = bombPrefab.GetComponent<MeshRenderer>().bounds.size.y / 2;

        }
        StartCoroutine(EnemyGenerator());
    }
    void ResetDelay()
    {
        delay = Random.Range(delayRange.x, delayRange.y);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
