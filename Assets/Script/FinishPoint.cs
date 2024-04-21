using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishPoint : MonoBehaviour
{
    [SerializeField] GameObject Victory;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Victory.SetActive(true);
            Time.timeScale = 0;
        }
        /*
        else if (collision.tag == "Enemy")
        {
            collision.gameObject.GetComponent<PlayerController>().Death();
        }
        */
    }
}
