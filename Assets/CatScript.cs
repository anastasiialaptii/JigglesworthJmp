using UnityEngine;

public class CatScript : MonoBehaviour
{
    private float _flapStreight = 20;
    private bool _isCatAlive = true;

    public Rigidbody2D myRigidBody;
    public LogicScript logic;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Score").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && this._isCatAlive)
        {
            myRigidBody.linearVelocity = Vector2.up * this._flapStreight;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        this._isCatAlive = false;
    }
}
