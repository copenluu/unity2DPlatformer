using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFireball : MonoBehaviour
{
    [SerializeField] private GameObject fireballPrefab;
    [SerializeField] private GameObject fireballPrefabRight;
    [SerializeField] float respawnTime = 3f;
    [SerializeField] float respawnTime2 = 1.5f;
    [SerializeField] float respawnTime3 = 2f;

    private void Start()
    {
        StartCoroutine(FireballRate());
        StartCoroutine(FireballRapid1());
        StartCoroutine(FireballRapid2());
    }

    #region SpawnFireballs
    private void SpawnFireBallLeft()
    {
        GameObject spawn = Instantiate(fireballPrefab) as GameObject;
        spawn.transform.position = new Vector2(-10, 21);
        
    }
    private void SpawnFireBallLeft1()
    {
        GameObject spawn = Instantiate(fireballPrefab) as GameObject;
        spawn.transform.position = new Vector2(-10, 24.5f);
    }

    private void SpawnFireBallRight()
    {
        GameObject spawn = Instantiate(fireballPrefabRight) as GameObject;
        spawn.transform.position = new Vector2(-56, 17);
    }
    private void SpawnFireBallRight1()
    {
        GameObject spawn = Instantiate(fireballPrefabRight) as GameObject;
        spawn.transform.position = new Vector2(-15.5f, 19);
    }
    private void SpawnFireBallLeft2()
    {
        GameObject spawn = Instantiate(fireballPrefab) as GameObject;
        spawn.transform.position = new Vector2(22, 16);
    }

    private void SpawnFireBallLeft3()
    {
        GameObject spawn = Instantiate(fireballPrefab) as GameObject;
        spawn.transform.position = new Vector2(43, 32.5f);
    }

    private void SpawnFireBallLeft4()
    {
        GameObject spawn = Instantiate(fireballPrefab) as GameObject;
        spawn.transform.position = new Vector2(48.3f, 56);
    }

    private void SpawnFireBallRight2()
    {
        GameObject spawn = Instantiate(fireballPrefabRight) as GameObject;
        spawn.transform.position = new Vector2(31.5f, 54);
    }

    private void SpawnFireBallRight3()
    {
        GameObject spawn = Instantiate(fireballPrefabRight) as GameObject;
        spawn.transform.position = new Vector2(-20.5f, 53.3f);
    }

    private void SpawnFireBallLeft5()
    {
        GameObject spawn = Instantiate(fireballPrefab) as GameObject;
        spawn.transform.position = new Vector2(28, -63.25f);
    }

    private void SpawnFireBallLeft6()
    {
        GameObject spawn = Instantiate(fireballPrefab) as GameObject;
        spawn.transform.position = new Vector2(28, -66f);
    }
    private void SpawnFireBallLeft7()
    {
        GameObject spawn = Instantiate(fireballPrefab) as GameObject;
        spawn.transform.position = new Vector2(40, -24.75f);
    }

    private void SpawnFireBallRight4()
    {
        GameObject spawn = Instantiate(fireballPrefabRight) as GameObject;
        spawn.transform.position = new Vector2(27, -66.75f);
    }
    private void SpawnFireBallRight5()
    {
        GameObject spawn = Instantiate(fireballPrefabRight) as GameObject;
        spawn.transform.position = new Vector2(27, -71.5f);
    }


    #endregion


    #region InbetweenFireballs1

    private void SpawnFireBallLeftRapid2()
    {
        GameObject spawn = Instantiate(fireballPrefab) as GameObject;
        spawn.transform.position = new Vector2(28, -56f);
    }

    private void SpawnFireBallLeftRapid3()
    {
        GameObject spawn = Instantiate(fireballPrefab) as GameObject;
        spawn.transform.position = new Vector2(28, -53f);
    }

    private void SpawnFireBallLeftRapid4()
    {
        GameObject spawn = Instantiate(fireballPrefab) as GameObject;
        spawn.transform.position = new Vector2(28, -50f);
    }

    private void SpawnFireBallLeftRapid5()
    {
        GameObject spawn = Instantiate(fireballPrefab) as GameObject;
        spawn.transform.position = new Vector2(28, -47f);
    }

    private void SpawnFireBallLeftRapid6()
    {
        GameObject spawn = Instantiate(fireballPrefab) as GameObject;
        spawn.transform.position = new Vector2(28, -44f);
    }

    private void SpawnFireBallLeftRapid7()
    {
        GameObject spawn = Instantiate(fireballPrefab) as GameObject;
        spawn.transform.position = new Vector2(28, -41f);
    }
    private void SpawnFireBallLeftRapid8()
    {
        GameObject spawn = Instantiate(fireballPrefab) as GameObject;
        spawn.transform.position = new Vector2(28, -38f);
    }
    private void SpawnFireBallLeftRapid9()
    {
        GameObject spawn = Instantiate(fireballPrefab) as GameObject;
        spawn.transform.position = new Vector2(28, -35f);
    }
    private void SpawnFireBallLeftRapid10()
    {
        GameObject spawn = Instantiate(fireballPrefab) as GameObject;
        spawn.transform.position = new Vector2(28, -32f);
    }

    private void SpawnFireBallRightRapid1()
    {
        GameObject spawn = Instantiate(fireballPrefabRight) as GameObject;
        spawn.transform.position = new Vector2(57, -40f);
    }



    #endregion

    #region InbetweenFireballs2
    private void SpawnFireBallLeftInbetween1()
    {
        GameObject spawn = Instantiate(fireballPrefab) as GameObject;
        spawn.transform.position = new Vector2(28, -54.5f);
    }
    private void SpawnFireBallLeftInbetween2()
    {
        GameObject spawn = Instantiate(fireballPrefab) as GameObject;
        spawn.transform.position = new Vector2(28, -51.5f);
    }
    private void SpawnFireBallLeftInbetween3()
    {
        GameObject spawn = Instantiate(fireballPrefab) as GameObject;
        spawn.transform.position = new Vector2(28, -48.5f);
    }
    private void SpawnFireBallLeftInbetween4()
    {
        GameObject spawn = Instantiate(fireballPrefab) as GameObject;
        spawn.transform.position = new Vector2(28, -45.5f);
    }
    private void SpawnFireBallLeftInbetween5()
    {
        GameObject spawn = Instantiate(fireballPrefab) as GameObject;
        spawn.transform.position = new Vector2(28, -42.5f);
    }
    private void SpawnFireBallLeftInbetween6()
    {
        GameObject spawn = Instantiate(fireballPrefab) as GameObject;
        spawn.transform.position = new Vector2(28, -39.5f);
    }
    private void SpawnFireBallLeftInbetween7()
    {
        GameObject spawn = Instantiate(fireballPrefab) as GameObject;
        spawn.transform.position = new Vector2(28, -36.5f);
    }
    private void SpawnFireBallLeftInbetween8()
    {
        GameObject spawn = Instantiate(fireballPrefab) as GameObject;
        spawn.transform.position = new Vector2(28, -33.5f);
    }
    private void SpawnFireBallLeftInbetween9()
    {
        GameObject spawn = Instantiate(fireballPrefab) as GameObject;
        spawn.transform.position = new Vector2(28, -30.5f);
    }

    private void SpawnFireBallRightInbetween1()
    {
        GameObject spawn = Instantiate(fireballPrefabRight) as GameObject;
        spawn.transform.position = new Vector2(57, -37f);
    }






    #endregion


    IEnumerator FireballRate()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            SpawnFireBallLeft1();
            SpawnFireBallLeft();
            SpawnFireBallLeft2();
            SpawnFireBallRight();
            SpawnFireBallRight1();
            SpawnFireBallLeft3();
            SpawnFireBallLeft4();
            SpawnFireBallRight2();
            SpawnFireBallRight3();
            SpawnFireBallLeft6();
            SpawnFireBallLeft5();
            SpawnFireBallLeft7();
            SpawnFireBallRight4();
            SpawnFireBallRight5();

        }
    }

    IEnumerator FireballRapid1()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime2);          
            SpawnFireBallLeftRapid2();
            SpawnFireBallLeftRapid3();
            SpawnFireBallLeftRapid4();
            SpawnFireBallLeftRapid5();
            SpawnFireBallLeftRapid6();
            SpawnFireBallLeftRapid7();
            SpawnFireBallLeftRapid8();
            SpawnFireBallLeftRapid9();
            SpawnFireBallLeftRapid10();
            SpawnFireBallRightRapid1();



        }
    }

    IEnumerator FireballRapid2()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime3);
            respawnTime3 = respawnTime2;
            SpawnFireBallLeftInbetween1();
            SpawnFireBallLeftInbetween2();
            SpawnFireBallLeftInbetween3();
            SpawnFireBallLeftInbetween4();
            SpawnFireBallLeftInbetween5();
            SpawnFireBallLeftInbetween6();
            SpawnFireBallLeftInbetween7();
            SpawnFireBallLeftInbetween8();
            SpawnFireBallLeftInbetween9();
            SpawnFireBallRightInbetween1();

        }
    }

}
