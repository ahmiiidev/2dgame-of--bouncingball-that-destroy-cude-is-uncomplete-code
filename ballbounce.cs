using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ballbounce : MonoBehaviour
{
    [SerializeField] float speed;

    public Transform ballfalls;

    // Start is called before the first frame update
    void Start()
    {

        transform.position = (new Vector2(0, -3.71f));
     

        /*Rigidbody2D rb = GetComponent<Rigidbody2D>();

        rb.AddForce(new Vector2(1f,0.5f)* Time.deltaTime * speed );*/

        

    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump")) 
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();

            rb.AddForce(new Vector2(1f, 0.5f) * Time.deltaTime * speed);

        }
        

        if(transform.position.y < ballfalls.transform.position.y)
        {
            Application.LoadLevel(Application.loadedLevel);
        }



    }
}
