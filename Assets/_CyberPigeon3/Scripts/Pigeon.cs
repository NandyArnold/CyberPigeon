using UnityEngine;

public class Pigeon : MonoBehaviour
{
    [SerializeField]

    private Rigidbody2D rb;

    [SerializeField]
    private float jumpForce = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private GameManager gameManager;
   
    void Start()
    {
        Debug.Log("main branch");
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = Vector2.up * jumpForce;
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        gameManager.GameOver();
    }
}
