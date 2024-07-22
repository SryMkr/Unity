using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterControler : MonoBehaviour
{
    public float xSpeed = 10;
    public float zSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroySelf", 5);
        InvokeRepeating("MonsterMove", 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(xSpeed * Time.deltaTime, 0, zSpeed * Time.deltaTime);
    }

    void MonsterMove()
    {

        xSpeed *= -1;
    }

    void DestroySelf()
    {
        Destroy(this.gameObject);
    }

}
