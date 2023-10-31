using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField]
    float speed = 6;

    //Força
    [SerializeField]
    public float force = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Inicialitzem la física del jugador
        Rigidbody2D player = GetComponent<Rigidbody2D>();

        //Si fem clic a l'espai
        if (Input.GetKey(KeyCode.Space))
        {
            Jump(); //Funció Jump

        }
        // Si fem clic a la fletxa dreta
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            player.velocity = Vector2.right * speed; //Mou el player cap a la dreta
            transform.localScale = new Vector3(5, 5, 5);//l'Sprite del player girara cap a la dreta
        }
        // Si fem clic a la fletxa esquerra
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            player.velocity = Vector2.left * speed; //Mou el player cap a l'esquerra
            transform.localScale = new Vector3(-5, 5, 5);//l'Sprite del player girara cap a l'esquerra
        }

    }
    public void Jump()
    {
        //El jugador salta
        Rigidbody2D player = GetComponent<Rigidbody2D>();
        player.velocity = new Vector2(player.velocity.x, force);
    }
}
