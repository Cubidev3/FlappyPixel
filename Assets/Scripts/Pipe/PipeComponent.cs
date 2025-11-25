using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class PipeComponent : MonoBehaviour
{
    [SerializeField] private float positionOffsetRange = 5f;
    [SerializeField] private float initialImpulse = 10f;

    void Awake()
    {
        transform.position += Vector3.up * Random.Range(-positionOffsetRange, positionOffsetRange);

        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.AddForceX(-initialImpulse, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("PipeKiller"))
        {
            Destroy(this.gameObject);
        }
    }
}
