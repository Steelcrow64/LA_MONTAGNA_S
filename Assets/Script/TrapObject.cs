using UnityEngine;

[RequireComponent(typeof(PolygonCollider2D))]
public class TrapObject : MonoBehaviour
{
    Rigidbody2D Rb;
    [SerializeField]

    // Start is called before the first frame update
    private void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<PlayerController>().Death();
        }
    }
}
