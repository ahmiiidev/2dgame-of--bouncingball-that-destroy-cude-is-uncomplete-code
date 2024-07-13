using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementscripts : MonoBehaviour
{
    Vector2 move;

    [SerializeField] float speed;

    // Start is called before the first frame update
    void Start()
    {
        move = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
       


        //move.x += 0.05f;

        float controlside = Input.GetAxis("Horizontal");

        move.x += controlside * Time.deltaTime * speed;

        move.x =  Mathf.Clamp(move.x,-9.7f,+9.7f);

        transform.position = move;

      /*  float x = Input.GetAxis("Horizontal");
        transform.Translate(x,0,0);*/






    }
}
