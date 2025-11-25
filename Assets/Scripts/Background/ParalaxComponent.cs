using UnityEngine;

public class ParalaxComponent : MonoBehaviour
{
    public float speed = 6f;
    public float distanceToLoop = 10f;

    void Start()
    {
        transform.position = Vector3.right * distanceToLoop / 2f;
    }

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        if (transform.position.x < -distanceToLoop / 2f)
        {
            transform.position += Vector3.right * distanceToLoop;
        }
    }
}
