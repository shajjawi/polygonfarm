using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class audio_background : MonoBehaviour
{

    AudioSource audio_data; float t;
    
    // Start is called before the first frame update
    void Start()
    {
     audio_data = this.gameObject.GetComponent<AudioSource>();
     audio_data.volume = 0.1f;
     audio_data.PlayDelayed(0);
     
    }

    // Update is called once per frame
    void Update()
    {
        if (audio_data.isPlaying == false) audio_data.PlayDelayed(0.5f);
        
      }
}
