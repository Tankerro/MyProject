using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resources : MonoBehaviour
{
    public GameObject player;
    public int health = 100;

    //public Animator PlayerAnim;
    public Animator SelfAnim;

    public string nameOfRes = "";

    void Start()
    {
        player = GameObject.Find("Player");
        //PlayerAnim = player.GetComponent<Animator>();
        SelfAnim = gameObject.GetComponent<Animator>();
    }


    void Update()
    {
        
        float distToPlayer = Vector3.Distance(player.transform.position, transform.position);
        if (distToPlayer <= 2.8f && Input.GetMouseButtonDown(0) && health > 0)
        {
            health -= 10;
            //PlayerAnim.Play("Attack_player");
            SelfAnim.Play("GetDamage");
            SelfAnim.SetInteger("health", health);
        }
        else if(health == 0)
        {
            SelfAnim.Play("Destoyed");
            if(nameOfRes == "wood")
            {
               
                player.GetComponent<PlayerContr>().wood += 10;
                player.GetComponent<PlayerContr>().WoodText.text = "WOOD : " + player.GetComponent<PlayerContr>().wood;
            }
            else if (nameOfRes == "iron")
            {
                player.GetComponent<PlayerContr>().iron += 10;
                player.GetComponent<PlayerContr>().IronText.text = "IRON : " + player.GetComponent<PlayerContr>().iron;
            }

            health -= 1;
            Destroy(gameObject, 5f);
        }
    }
}
