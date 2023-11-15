using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle : MonoBehaviour

{    
     float t;
     GameObject obj;
     int ctrl;
     Rigidbody2D rb;
     public int number_of_lifes;
          
     void OnCollisionEnter2D(Collision2D collision)     {
     
     obj = collision.gameObject; 
     if (obj.name == "Square") {
     
     obj.GetComponent<Renderer>().material.color = Color.red; 
     obj.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX; //avoid horizontal displacement of square after collision
     
     
    }
      }
    
      
     
     void OnCollisionExit2D(Collision2D collision)
    {
       obj = collision.gameObject; 
       if (obj.name == "Square") {
     
      
      obj.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;
      obj.GetComponent<Renderer>().material.color = Color.white;
    }
       }
       
       // Start is called before the first frame update
    void Start()
    {
              
        t = 0f; // FOR OPTIONS 1 & 2
        ctrl=1; // FOR OPTION 3
        this.gameObject.AddComponent<Rigidbody2D>();
        rb = this.gameObject.GetComponent<Rigidbody2D>();
        rb.isKinematic = true;
        number_of_lifes = 3;
        
       
    }

    // Update is called once per frame
    void Update()
    {

        // OPTION 1 (appear/disappear)

     /*   this.transform.position = new Vector2(-22f+t,-6f);
        t = t + 0.2f;
        if (this.transform.position.x > 22) t=0; */
        
        // OPTION 2 (forward/backward at constant velocity)
        
       /*  float pstn_x = this.transform.position.x;
        if (Mathf.Abs(this.transform.position.x) >= 22) ctrl=ctrl*(-1);
        this.transform.position = new Vector2(pstn_x + ctrl*0.25f,-6f);*/
                
        // OPTION 3 (forward/backward with a nice, smooth flow)
        
       /*  this.transform.position = new Vector2(-22f*Mathf.Cos(t),-6f); 
         t = t + 0.02f;  */
         
          
      /* // OPTION 4   
          
         if (transform.position.x >= 23 || transform.position.x <= (-23)) ctrl=(-1)*ctrl; 
         rb.velocity = new Vector2(15*ctrl,0);
         print(transform.position.x); */
         
       // OPTION 5
          
          if (transform.position.x >= 23) ctrl=-1;
          if (transform.position.x <= (-23)) ctrl= 1;
          rb.velocity = new Vector2(15*ctrl,0);
          
          
        
   } 
}
