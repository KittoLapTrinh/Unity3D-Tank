# Unity3D-Tank
# Prefabs
![image](https://github.com/user-attachments/assets/c175dd2d-42be-4bc2-a54a-6810c42f95be)
# Bullet
![image](https://github.com/user-attachments/assets/b3464611-fa37-4634-a1b0-7227ae6cfebd)
# Gun
![image](https://github.com/user-attachments/assets/8188d935-859a-4535-a788-01e87b89e224)
# Đầu nòng
![image](https://github.com/user-attachments/assets/9b7f3e6c-28dd-4bd5-8894-9e3be9498f2c)

# FireProjectile
~~~
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


~~~



