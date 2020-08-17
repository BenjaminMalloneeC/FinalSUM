using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Transform tf;
    public float turnSpeed = 175f;
    public float moveSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        GameManager.instance.player = this.gameObject;
        tf = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            tf.Rotate(0, 0, turnSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            tf.Rotate(0, 0, -turnSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            tf.position += tf.right * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            tf.position += -tf.right * moveSpeed * Time.deltaTime;
        }
    }

    void OncollisionEneter2D (Collision2D col)
    {
        if(col.gameObject.tag == "Bullet")
        {
            Destroy(this.gameObject);

            Debug.Log("Collided with Bullet");
        }
    }
}
