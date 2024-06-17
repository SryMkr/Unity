using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public GameObject particleEffect; // 粒子效果预制体
    public GameObject particleEffectPrefab;
    private GameObject particleEffectInstance; // 粒子效果实例

    float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = -30f;
        Invoke("SelfDestroy", 3f);
        // 在对象上创建粒子效果实例
        if (particleEffectPrefab != null)
        {
            particleEffectInstance = Instantiate(particleEffectPrefab, transform.position, Quaternion.identity, transform);
        }

    }

    // Update is called once per frame
    void Update()
    {
        // 更新粒子效果位置以跟随对象
        if (particleEffectInstance != null)
        {
            particleEffectInstance.transform.position = transform.position;
        }
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(1111);
        Destroy(gameObject);
        Destroy(other.gameObject);
        // 在触发点生成粒子效果
        if (particleEffect != null)
        {
            Instantiate(particleEffect, transform.position, Quaternion.identity);
        }
    }

    void SelfDestroy()
    {
        Destroy(gameObject);
    }
}
