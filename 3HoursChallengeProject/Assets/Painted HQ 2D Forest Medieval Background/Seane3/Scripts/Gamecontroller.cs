using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamecontroller : MonoBehaviour
{

    public GameObject Num;
    public GameObject Num2;
    public GameObject Num3;
    public GameObject Num4;
    public Vector3 spawn;
    public float spawnWait;

    // Use this for initialization
    void Start()
    {
        StartCoroutine("spawnWave");
        StartCoroutine("spawnWave2");
        StartCoroutine("spawnWave3");
        StartCoroutine("spawnWave4");
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator spawnWave()
    {
        while (true)
        {
            Vector3 spawnPosition = new Vector3(
                Random.Range(-spawn.x, spawn.x),
                spawn.y,
                Random.Range(-spawn.z, spawn.z)
            );
            Instantiate(Num, spawnPosition, Quaternion.identity);
            yield return new WaitForSeconds(spawnWait);
        }
    }
    IEnumerator spawnWave2()
    {
        while (true)
        {
            Vector3 spawnPosition2 = new Vector3(
                Random.Range(-spawn.x, spawn.x),
                spawn.y,
                Random.Range(-spawn.z, spawn.z)
            );
            Instantiate(Num2, spawnPosition2, Quaternion.identity);
            yield return new WaitForSeconds(spawnWait);
        }
    }
    IEnumerator spawnWave3()
    {
        while (true)
        {
            Vector3 spawnPosition3 = new Vector3(
                Random.Range(-spawn.x, spawn.x),
                spawn.y,
                Random.Range(-spawn.z, spawn.z)
            );
            Instantiate(Num3, spawnPosition3, Quaternion.identity);
            yield return new WaitForSeconds(spawnWait);
        }
    }
    IEnumerator spawnWave4()
    {
        while (true)
        {
            Vector3 spawnPosition4 = new Vector3(
                Random.Range(-spawn.x, spawn.x),
                spawn.y,
                Random.Range(-spawn.z, spawn.z)
            );
            Instantiate(Num4, spawnPosition4, Quaternion.identity);
            yield return new WaitForSeconds(spawnWait);
        }
    }
}