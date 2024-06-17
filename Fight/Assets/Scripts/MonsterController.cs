using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController : MonoBehaviour
{
    public float forwardSpeed = 10f;
    public float sideSpeed = 2f; // 左右偏移的速度
    public float changeDirectionInterval = 1f;
    public float randomFactor = 1f; // 随机因子，用于调整随机性

    private Vector3 moveDirection;

    // Start is called before the first frame update
    void Start()
    {
        // 初始化移动方向
        moveDirection = transform.forward;
        InvokeRepeating("ChangeDirection", changeDirectionInterval, changeDirectionInterval);
    }

    // Update is called once per frame
    void Update()
    {
        // 持续向前移动
        transform.Translate(moveDirection * forwardSpeed * Time.deltaTime);
    }

    void ChangeDirection()
    {
        // 在左右方向上添加随机偏移
        float randomSideOffset = Random.Range(-1f, 1f) * randomFactor;
        moveDirection = transform.forward + transform.right * randomSideOffset * sideSpeed;
        moveDirection.Normalize(); // 归一化方向
    }
}
