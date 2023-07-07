using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rock2spawn : MonoBehaviour
{
    public GameObject rocksPrefab;
    public float respawnTime = 1.0f;
    private Vector2 screenBounds;

    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(-Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(asteroidWave());
    }

    private void spawnEnemy()
    {
        GameObject a = Instantiate(rocksPrefab) as GameObject;
        a.transform.position = new Vector2(-screenBounds.x , Random.Range(-screenBounds.y, screenBounds.y));

    }


    IEnumerator asteroidWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
        }
    }

}
