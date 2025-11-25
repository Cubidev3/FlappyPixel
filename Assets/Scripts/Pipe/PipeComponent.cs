using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class PipeComponent : MonoBehaviour
{
    [SerializeField] private float positionOffsetRange = 5f;
    [SerializeField] private float initialImpulse = 10f;

    private Rigidbody2D rigidbody;
    
    void Awake()
    {
        transform.position += Vector3.up * Random.Range(-positionOffsetRange, positionOffsetRange);
        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.AddForceX(-initialImpulse, ForceMode2D.Impulse);
        
        GameStateManager.OnGameOver.AddListener(() => rigidbody.simulated = false);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("PipeKiller"))
        {
            Destroy(this.gameObject);
        }
    }
}
