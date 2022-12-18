using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContr : MonoBehaviour
{
    public CharacterController controller;
    public Transform PlayerBody;
    public float speed = 12f;
    
    public Animator anim;
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float z = Input.GetAxis("Horizontal") * -1;
        float x = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * z;

        //if (Input.GetButton("Fire1"))
        //{
        //    anim.Play("attack_player");
        //}

        if (z < 0 && x == 0)
        {
            PlayerBody.localRotation = Quaternion.Euler(x, 90f, z);

        }

        else if(z > 0 && x == 0)
        {
            PlayerBody.localRotation = Quaternion.Euler(x, -90f, z);

        }
        else if (x < 0 && z == 0)
        {
            PlayerBody.localRotation = Quaternion.Euler(x, 180f, z);

        }
        else if (x > 0 && z == 0)
        {
            PlayerBody.localRotation = Quaternion.Euler(x, 0f, z);

        }

        else if (z > 0 && x > 0)
        {
            PlayerBody.localRotation = Quaternion.Euler(x, -45f, z);

        }

        else if (z < 0 && x > 0)
        {
            PlayerBody.localRotation = Quaternion.Euler(x, 45f, z);

        }

        else if (z < 0 && x < 0)
        {
            PlayerBody.localRotation = Quaternion.Euler(x, 135f, z);

        }

        else if (z > 0 && x < 0)
        {
            PlayerBody.localRotation = Quaternion.Euler(x, -135f, z);

        }

        if (z != 0f || x != 0f)
        {
            anim.SetBool("walk", true);
        }
        else
        {
            anim.SetBool("walk", false);
        }
        controller.Move(move * speed * Time.deltaTime);
    }
}
