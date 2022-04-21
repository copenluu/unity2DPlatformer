using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingBall : MonoBehaviour
{
    [SerializeField] private GameObject rollingBallPrefab;
    [SerializeField] private float respawnTime;

    private void Start()
    {
        StartCoroutine(RollingBallSpawn());
        StartCoroutine(RollingBallSpawnFast());
    }

    private void SpawnRollingBall()
    {
        GameObject spawnball = Instantiate(rollingBallPrefab) as GameObject;
        spawnball.transform.position = new Vector2(50.2f, 59);
    }

    private void SpawnRollingBall2()
    {
        GameObject spawnball = Instantiate(rollingBallPrefab) as GameObject;
        spawnball.transform.position = new Vector2(-30.2f, 76);
    }

    private void SpawnRollingBall3()
    {
        GameObject spawnball = Instantiate(rollingBallPrefab) as GameObject;
        spawnball.transform.position = new Vector2(76, -25);
    }



    IEnumerator RollingBallSpawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            SpawnRollingBall();
            SpawnRollingBall2();
            
        }
    }
    IEnumerator RollingBallSpawnFast()
    {
        while (true)
        {
            yield return new WaitForSeconds(1.6f);
            SpawnRollingBall3();
        }
    }

}
