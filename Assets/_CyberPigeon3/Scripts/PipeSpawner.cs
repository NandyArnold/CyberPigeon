using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    [SerializeField]
    private GameObject pipe;
    [SerializeField]
    private float spawnRate = 1;

    [SerializeField]
    private float heightOffset;

    private float timer = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer<spawnRate)
        {
            timer += Time.deltaTime;
        }
        else 
        {
            SpawnPipe();
            timer = 0;
        }
    }

    void SpawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Vector3 randomPosition = new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint),transform.position.z);
            

        Instantiate(pipe, randomPosition, Quaternion.identity);
    }
}
