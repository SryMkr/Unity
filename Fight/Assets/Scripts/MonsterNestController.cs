using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterNestController : MonoBehaviour
{
    public GameObject monsterPrefab;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnMonster", 2f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnMonster()
    {
        GameObject monster = Instantiate(monsterPrefab);
    }

  
}
