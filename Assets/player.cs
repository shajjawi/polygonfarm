using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class player : MonoBehaviour
{


     Rigidbody2D rb;
     float move_x;
     float move_y;
     public float[] rry= new float[3];  //alternatively you can use rry = new float[] {value_1,value_2,value_3};
     int count;
     AudioSource audio_data;
     float t;
     public int number_of_lifes;
     public TMP_Text txt;
     Color clr;
     
    
     //GameObject obj = GameObject.Find("Square");
     
       
     
     void OnCollisionEnter2D(Collision2D collision)     {
       
     float t_aux=t; //auxiliar in case of multiple collision opportunity
     if (collision.gameObject.name != "floor") t=0; 
    
       }
     
     
     Color gen_rndm_color() { //generate random color
     
      
     Color clr = new Vector4(Random.Range(0f,1f),Random.Range(0f,1f),Random.Range(0f,1f),1);
     
     return clr;
     
     }
     
     float[] rtrn_array(float[] myarray) { //devuelve los valores de un array tipo float multiplicados por 2
     
     float[] s = new float[myarray.Length];
     int i;
     for (i=0; i < myarray.Length; i++) s[i]=myarray[i]*2;
     
     return s;
     
     }
     
     void print_array(float[] myarray) { // on-screen array printing in one single line
          
      int i;
      string str="";
      for (i=0; i <  rry.Length; i++) str=str + rry[i].ToString()+ "  "; //output array values into a single line
      print(str);
     
     }
     
   
    // Start is called before the first frame update
    void Start()
    
        
       {
         
             
         //AudioSource audioData;
         //audioData = GetComponent<AudioSource>();
         //audioData.Play(0);
    
	 rb = GetComponent<Rigidbody2D>();
	
	 	 
         //this.transform.Rotate(0,0,45);
         rb.angularVelocity = 0f; 
         
         //this.GetComponent<Renderer>().material.color = gen_rndm_color();
         count=0;  
         
         //manolo = Instantiate(this.gameObject); // ojo: esto genera infinitos clones de square;
         
        // this.gameObject.GetComponent<Transform>().rotation = new Quaternion(0,0,0.38f,0.92f);
         //this.gameObject.transform.Rotate(0.0f, 0.0f,45.0f, Space.Self);
         
        // audio_data = GetComponent<AudioSource>();
        // audio_data.volume = 0.1f;
        // audio_data.PlayDelayed(0);
        t=3f; // set inital t value to be higher than stunning time (2s)
        clr = this.gameObject.GetComponent<Renderer>().material.color;
        
         
        GameObject crono = GameObject.Find("cronometro");
        txt = crono.GetComponent<text_script>().txt;
        txt.text = "20:00";
        Vector3 vctr= GameObject.Find("Main Camera").GetComponent<Camera>().ViewportToWorldPoint(new Vector3(0.95f,0.85f,10f)); 
        crono.transform.position = vctr;
        crono.GetComponent<TextMeshPro>().fontSize = 15;
        crono.GetComponent<TextMeshPro>().color = new Vector4(1,1,1,1);
       
                      
                } 
        
        
    // Update is called once per frame
    void Update()
    {
        
        
        t=t+Time.deltaTime;
        
        // after a collision player will stay changing it's sprite color at rate 1fps for 2 seconds
        
        if (t <= 2) {gameObject.GetComponent<Renderer>().material.color = gen_rndm_color();} else {gameObject.GetComponent<Renderer>().material.color = clr;}
        
        rb.mass = 8; rb.gravityScale = 8; 
        this.gameObject.transform.rotation = new Quaternion(0f,0f,0f,1f); 
        //this.transform.Rotate(0,0,0); rb.angularVelocity=0; rb.freezeRotation = true;
        
        move_x = Input.GetAxis("Horizontal");
        move_y = Input.GetAxis("Vertical");
        if (Mathf.Abs(move_x) > 0) rb.velocity = new Vector2(10*move_x,Mathf.Abs(10*move_x));
        if (Mathf.Abs(move_y) > 0) rb.velocity = new Vector2(0,15*move_y); 
        if (Input.GetKeyDown(KeyCode.Space)) rb.velocity = new Vector2(0,50); 
            
        
        if (txt.text == "00:00") StartCoroutine(Fade());
           
        //if (audio_data.isPlaying == false) audio_data.PlayDelayed(0.1f); 
        
        }
        
         
        void FixedUpdate() //changes background filter-color each 5 seconds (provided fixedDeltaTime is set to it's default value (0.02s)
        {
        
           count = count+1;
           if (count > 0 && (count % 250) == 0) {
           GameObject.Find("background").GetComponent<SpriteRenderer>().color = gen_rndm_color();
           clr = gen_rndm_color(); //setting player color for next 5 seconds
              
              }
              
          }
          
               
        IEnumerator Fade() // after 20s of gameplay player's gameobject will fade and update() methods stop executing
        {
          Color c = this.gameObject.GetComponent<Renderer>().material.color;
          for (float alpha = 1f; alpha >= 0; alpha -= 0.1f)
            {
              c.a = alpha;
              this.gameObject.GetComponent<Renderer>().material.color = c;
              yield return null;
            }
            Time.timeScale = 0;
        }
      
 } //end of class player       
         
         
         
         
        
         

