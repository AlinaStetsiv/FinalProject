using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Rigidbody2D rigidb;
    public int speedNum = 5;
    // Start is called before the first frame update
    void Start()
    {
        rigidb = GetComponent<Rigidbody2D>();
       
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        rigidb.velocity = new Vector2(xInput * speedNum, rigidb.velocity.y );
        if (Input.GetKeyDown(KeyCode.A)) {
            rigidb.velocity = new Vector3(-1, rigidb.velocity.y);
        }
        if (Input.GetKeyDown(KeyCode.D)) {
            transform.position = new Vector3(1, rigidb.velocity.y);
        }
    }
}
