using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class text_script : MonoBehaviour

{

    
    float t;
    public TMP_Text txt;
    
    void Awake()
    {
        txt = GetComponent<TMP_Text>();
    }
    

    // Start is called before the first frame update
    void Start()
    {
         //txt = GetComponent<TMP_Text>();
         //txt.text="20:00";
         t=0;
         
        //Camera cmr = GameObject.Find("Main Camera").GetComponent<Camera>();
        //Vector3 vctr;
        //vctr= cmr.ViewportToWorldPoint(new Vector3(0.95f,0.85f,10f)); 
        //this.gameObject.transform.position = vctr;
        //this.gameObject.GetComponent<TextMeshPro>().fontSize = 15;
        //this.gameObject.GetComponent<TextMeshPro>().color = new Vector4(1,1,1,1);
        
    
        
    
    }

    // Update is called once per frame
    void Update()
    {
       
      t=t+Time.deltaTime;
      Mathf.Round((20-t)*100);
    
      int dlt_tm = (int)(20-t); float decimals = (20-t)-dlt_tm; 
      if (t <= 20.01) txt.text = dlt_tm.ToString("D2") + ":" + ((int)(decimals*100)).ToString("D2");
    
    }
}
