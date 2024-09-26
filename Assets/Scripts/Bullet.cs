using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float lifetime = 3f; // Thời gian sống của đạn

    void Start()
    {
        // Hủy đạn sau thời gian chỉ định
        Destroy(gameObject, lifetime);
    }

    void OnCollisionEnter(Collision collision)
    {
        // Hủy đạn khi va chạm
        Destroy(gameObject);
    }
}
