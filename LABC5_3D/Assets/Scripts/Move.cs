using UnityEngine;

public class Move : MonoBehaviour
{
    CharacterController controller;
    public float speed = 5.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        // Lấy input từ phím mũi tên hoặc WASD
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 move = transform.forward * moveVertical + transform.right * moveHorizontal;
        
        // Di chuyển nhân vật
        controller.SimpleMove(move * speed);
    }
}
