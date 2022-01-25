using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Player : MonoBehaviour
{
    public float speed = 100.0f;
    public Rigidbody2D rb;

    PhotonView view;

    // Start is called before the first frame update
    void Start()
    {
        view = GetComponent<PhotonView>();
    }

    // Update is called once per frame
    void Update()
    {
        if(view.IsMine)
        {
            Movement();
        }

    }

    void Movement()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 tempVect = new Vector3(horizontal, vertical, 0);
        tempVect = tempVect * speed * Time.deltaTime;
        rb.MovePosition(rb.transform.position + tempVect);
    }
}
