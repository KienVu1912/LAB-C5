using UnityEngine;

public class PhysicsDetector : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // 1. Dành cho va chạm vật lý (Collision)
    private void OnCollisionEnter(Collision collision) {
        Debug.Log("COLLISION: Đâm vào vật cứng: " + collision.gameObject.name);
    }

    // 2. Dành cho vùng cảm biến (Trigger)
    private void OnTriggerEnter(Collider other) {
        Debug.Log("TRIGGER: Đã đi xuyên vào vùng: " + other.gameObject.name);
    }
}
