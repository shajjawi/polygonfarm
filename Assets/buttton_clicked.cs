using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class buttton_clicked : MonoBehaviour
{

  
      
    // Start is called before the first frame update
    void Start()
    {
         Button btn = this.GetComponent<Button>();
         btn.onClick.AddListener(TaskOnClick);
         
    }
    
     void TaskOnClick()
            {
               // Debug.Log("You have clicked the button!");
                SceneManager.LoadScene("SampleScene");
             }

   
}
