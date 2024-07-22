using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public GameObject BulletPrefabs;
    public GameObject Beak;
    public float MoveSpeed = 20f;
    void Start()
    {
        InvokeRepeating("Fire", 2f, 1f);
    }

 
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-MoveSpeed * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(MoveSpeed * Time.deltaTime, 0, 0);
        }
    }

    void Fire()
    {
        GameObject newBullet = Instantiate(BulletPrefabs);
        newBullet.transform.position = Beak.transform.position;
    }
}
