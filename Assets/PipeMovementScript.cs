using UnityEngine;

public class PipeMovementScript : MonoBehaviour
{
    private float _moveSpeed = 10;
    private float _deadZone = -30;

    void Start()
    {
        
    }

    void Update()
    {
        transform.position = transform.position + (Vector3.left * this._moveSpeed) * Time.deltaTime;

        if (transform.position.x < this._deadZone)
        {
            Destroy(gameObject);
        }
    }
}
