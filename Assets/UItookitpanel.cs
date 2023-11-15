using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;


public class UItookitpanel : MonoBehaviour
{


[SerializeField]

   private UIDocument m_UIDocument;

   // private Label m_Label;

   private int m_ButtonClickCount = 0;

  // private Toggle m_Toggle;

   private Button m_Button;
   
   private Button m_Veamos;

   private VisualElement m_VE;

   public void Start()

   {
   
       

       var rootElement = m_UIDocument.rootVisualElement;

        // This searches for the VisualElement Button named “EventButton”

       // rootElement.Query<> and rootElement.Q<> can both be used

       m_Button = rootElement.Q<Button>("bttn_1");
       
       m_VE = rootElement.Q<VisualElement>("BACKGROUND");
       
       
       m_Veamos = rootElement.Q<VisualElement>("BACKGROUND").Q<Button>("veamos"); //altenativelly: m_Veamos = rootElement.Q<Button>("veamos");

 

       // Elements with no values like Buttons can register callBacks

// with clickable.clicked

       m_Button.clickable.clicked += OnButtonClicked;
       
       //m_Veamos.clickable.clicked += OnButtonClicked;
       
       m_Veamos.clickable.clicked += VeamosButtonClicked;

       // Cache the reference to the Label since we will access it repeatedly.

       // This avoids the relatively costly VisualElement search each time we update

       // the label.

    //   m_Label = rootElement.Q<Label>("IncrementLabel");

    //   m_Label.text = m_ButtonClickCount.ToString();

   }

 

   private void OnDestroy()

   {

    //   m_Button.clickable.clicked -= OnClicked;

    //   m_Toggle.UnregisterValueChangedCallback(OnToggleValueChanged);

   }

 

   private void OnButtonClicked()

   {

       m_ButtonClickCount++;

    //   m_Label.text = m_ButtonClickCount.ToString();
       
       print("I've been clicked");

   }

 
   private void VeamosButtonClicked()

   {
  
  SceneManager.LoadScene("SampleScene");
 
  }

     // Update is called once per frame
    void Update()
    {
       //OnButtonClicked();
    }
}
