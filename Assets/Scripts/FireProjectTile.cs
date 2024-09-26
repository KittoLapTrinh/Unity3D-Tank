using UnityEngine;

public class FireProjectile : MonoBehaviour
{
    public Rigidbody projectile; // Prefab đạn có Rigidbody
    public float speed = 4f; // Tốc độ đạn

    void Update()
    {
        if (Input.GetButtonDown("Fire1")) // Kiểm tra xem phím bắn đã được nhấn chưa
        {
            Fire(); // Gọi hàm bắn
        }
    }

    void Fire()
    {
        if (projectile != null) // Kiểm tra xem projectile đã được gán chưa
        {
            // Tạo một bản sao của projectile tại vị trí và góc nhìn hiện tại
            Rigidbody p = Instantiate(projectile, transform.position, transform.rotation);

            // Thiết lập tốc độ của đạn
            p.velocity = transform.forward * speed;

            Debug.Log("Projectile fired!"); // Thông báo khi đạn được bắn ra
        }
        else
        {
            Debug.LogError("Projectile prefab not assigned in the Inspector."); // Cảnh báo nếu prefab không được gán
        }
    }
}
