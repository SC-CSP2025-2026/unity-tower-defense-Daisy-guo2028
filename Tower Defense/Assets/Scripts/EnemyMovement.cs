using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [field: SerializeField]
    public float Speed {get; private set;} = 1f;

    void Start()
    {
        
    }

    void Update()
    {
        transform.position += new Vector3(Speed, 0, 0) * Time.deltaTime;
    }
}