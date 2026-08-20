using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class monsterSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] monsterReferences;
    private GameObject spawnedMonster;
    [SerializeField]
    private Transform leftPos, rightPos;

    private int randomIndex;
    private int randomSide;
 

    void Start()
    {
        StartCoroutine(SpawnMonsters());
    }
    IEnumerator SpawnMonsters()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(1, 3));
            randomIndex = Random.Range(0, monsterReferences.Length);
            randomSide = Random.Range(0, 2);
            spawnedMonster = Instantiate(monsterReferences[randomIndex]);
            //left side 
            if (randomSide == 0)
            {
                spawnedMonster.transform.position = leftPos.position;
                spawnedMonster.GetComponent<monster>().speed = Random.Range(4, 10);
            }
            else //right side
            {
                spawnedMonster.transform.position = rightPos.position;
                spawnedMonster.GetComponent<monster>().speed = Random.Range(-10, -4);
                spawnedMonster.transform.localScale = new Vector3(-1, 1, 1);
            }
        }
    }

    void Update()
    {
        
    }
}
