using UnityEngine;

public class CollisionTest : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // Gọi khi có va chạm vật lý (nhân vật bị chặn lại)
    private void OnCollisionEnter2D(Collision2D collision) {
        Debug.Log("Va chạm vật lý với: " + collision.gameObject.name);
    }

    // Gọi khi đi xuyên qua vật thể có check "Is Trigger"
    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("Đã đi vào vùng Trigger: " + other.gameObject.name);
    }
}
