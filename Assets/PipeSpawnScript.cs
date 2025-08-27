using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    private float _spawnRate = 2;
    private float _timer = 0;
    private float _heightOffset = 5;

    public GameObject pipe;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        if (this._timer < this._spawnRate)
        {
            this._timer = this._timer + Time.deltaTime;
        }
        else
        {
            Spawn();
            this._timer = 0;  
        }
    }

    void Spawn()
    {
        var lowestPoint = transform.position.y - this._heightOffset;
        var highestPoint = transform.position.y + this._heightOffset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
