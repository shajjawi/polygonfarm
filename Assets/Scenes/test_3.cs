using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class test_3 : MonoBehaviour
{

Button  bttn;
    // Start is called before the first frame update
    void Start()
    {
        UIDocument uid = gameObject.GetComponent<UIDocument>();
        var root = uid.rootVisualElement;
        bttn = root.Q<Button>("button_1");
        bttn.clicked += () => print_message(bttn); // assing an Action to perform when clicking a button
       
      
    }

    // Update is called once per frame
    void Update()
    {
   
    } //end of update

    void print_message(Button bttn) {SceneManager.LoadScene(bttn.text);} // define the action to perform: load appropiate scene


}

/* assets store --> leantween --> add to my assets --> window --> package manager --> my assets --> import */
