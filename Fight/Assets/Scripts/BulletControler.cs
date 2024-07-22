using UnityEngine; //引用命名空间

public class BulletControler : MonoBehaviour
{
    // Start is called before the first frame update
    // 初始化变量和加载一些资源，只执行一次
    public float speed = 10f; 

    void Start()
    {
        Invoke("DestroySelf", 5f);
    }

    // Update is called once per frame
    // 游戏每一帧都会调用
    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);
    }

    // 触发器
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        
    }

    private void DestroySelf()
    {
        Destroy(this.gameObject);
    }
}
