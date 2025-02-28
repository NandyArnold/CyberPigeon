using UnityEngine;

public class MovePipe : MonoBehaviour
{

    [SerializeField]
    private float moveSpeed;

    [SerializeField]
    private float deadZone = 0;

    private GameManager gameManager;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * (Time.deltaTime * moveSpeed);
        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
 
    }

    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //i want to call a function on my game Manager to add points to my score
        gameManager.AddPoints();
    }


}
