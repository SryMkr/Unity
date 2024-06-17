using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.UI.Image;

public class BirdController : MonoBehaviour
{
    public GameObject bulletPrefab; // 子弹预制体
    public float speed;
    public GameObject beak;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Fire", 2f, 1f);
        speed = 20f;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.A)){
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }

    void Fire()
    {
        GameObject bullet = Instantiate(bulletPrefab);

        bullet.transform.position = beak.transform.position;
    }
}
