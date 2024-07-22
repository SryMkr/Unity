using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnControler : MonoBehaviour
{
    public GameObject MonsterProfab;
    // Start is called before the first frame update
    void Start()
    {
       
        InvokeRepeating("Spawn", 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    void Spawn()
    {
        GameObject newMonster = Instantiate(MonsterProfab);
        float randomX = Random.Range(-50f, 50f);
        newMonster.transform.Translate(randomX, 0, 0);
    }
}
