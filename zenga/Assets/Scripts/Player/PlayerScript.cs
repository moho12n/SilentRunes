using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {
    // Player Input 
   
    GameObject obstacle;
    bool isRunning;
    bool flip;
    [HideInInspector]
    public float horizontalMove;
     [SerializeField]
    float jump;
     [SerializeField]
    float y;
       [SerializeField]
    public float speed;
    bool isGrounded;
    bool isCanPushed;
    Rigidbody rb;
    Animator anim;
    public float speedRun,x;
    float heightWhenJumped;
    [SerializeField]
    LayerMask layer;
    [SerializeField]
    float i;
    public float gTimer,gRTimer;

    

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        isGrounded=true;
        isRunning = false;
        flip = true;
        isCanPushed = false;
        obstacle = null;

	}
	
	// Update is called once per frame
	void Update () {
		Animation();
	}
    void FixedUpdate()
    {
        mouvement();
    }
    void mouvement()
    {
        /**Jump  Physics */
        isGrounded=Physics.Raycast(transform.position,Vector3.down,1f,layer);
        gRTimer -= Time.deltaTime;
        if(isGrounded){gRTimer = gTimer;}


        horizontalMove= Input.GetAxis("Horizontal");//Horzionatal

                /* Handler Horizontal Movement  and Vertical */
               
                if(Mathf.Abs(horizontalMove)>0)
                   {
                rb.transform.Translate(Vector3.forward * Mathf.Abs(horizontalMove)  * Time.deltaTime * speed);

                    }

                    /**Jump */
                    
               if(Input.GetKeyDown(KeyCode.Space) && gRTimer > 0)
               {
                   gRTimer = 0;
                   
                   rb.velocity=Vector3.up*jump;
                   heightWhenJumped = rb.position.y;
               }

               /** flip to direction of walk */

               if(horizontalMove < 0 && flip)
                   {
                      transform.Rotate(0,180,0);
                     flip=!flip;
                   }

               if(horizontalMove > 0 && !flip)
                   {
                     transform.Rotate(0,-180,0);
                     flip=!flip;
                   }

               


                 }
             
            
                  

    void Animation()
    {
            anim.SetFloat("Horizontal",Mathf.Abs(horizontalMove),y,Time.deltaTime);
           
            if(isGrounded && Mathf.Abs(horizontalMove) > 0 && Input.GetKeyDown(KeyCode.LeftShift))
               {
                 isRunning = true;
                 anim.SetBool("run",true);
                 x=speed;
                 speed=speedRun;
               }

            if(isRunning && Input.GetKeyUp(KeyCode.LeftShift))
               {
                 isRunning = false;
                 anim.SetBool("run",false);
                 speed=x;
               }

            if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
                {
                    anim.SetTrigger("jump");
                    isGrounded=false;
                }

            if(heightWhenJumped - rb.position.y > 5f && !isGrounded){anim.SetTrigger("roll");}

            if(isCanPushed && Input.GetKeyDown(KeyCode.R)){ anim.SetBool("push",true); }
            if(Input.GetKeyUp(KeyCode.R)){anim.SetBool("push",false);}
    }

  void OnCollisionStay(Collision cool)
  {
       if(cool.gameObject.CompareTag("Obstacle"))
        {
          if(anim.GetBool("push")){obstacle.GetComponent<Rigidbody>().isKinematic = false;}
          else{obstacle.GetComponent<Rigidbody>().isKinematic = true;}
        }
  }

  void OnCollisionExit(Collision cool)
    {
         if(cool.gameObject.CompareTag("Obstacle"))
        {
          isCanPushed=false;
          obstacle.GetComponent<Rigidbody>().isKinematic = false;
          obstacle = null;
        }
    }
}
