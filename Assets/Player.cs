using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 100.0f;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
           
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 tempVect = new Vector3(horizontal, vertical, 0);
        tempVect = tempVect * speed * Time.deltaTime;
        rb.MovePosition(rb.transform.position + tempVect);

    }
}
