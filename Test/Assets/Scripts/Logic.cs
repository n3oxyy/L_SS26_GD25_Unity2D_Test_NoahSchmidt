using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TestManager : MonoBehaviour
{
    
    public TextMeshProUGUI valueText;
    public GameObject screen1;
    public GameObject screen2;
    public AudioSource audioSource;
    public AudioClip correctSound;
    

    private int value = 0;
    private int dynamicAddAmount = 1;
    

   
   

   //knopf für nachricht an console
    public void Button1_MessageToConsole()
    {
        Debug.Log("Test_1_Button_1_pressed");
    }

  // der geht irgendwie nich, nochmal ändern mit anderem tutorial
    public void Button2_PlaySound()
    {
        audioSource.PlayOneShot(correctSound);
    }

    //der machtt
    public void Button3_OpenScreen1()
    {
        screen1.SetActive(true);
    }

    
    public void Button4_OpenScreen2()
    {
        screen2.SetActive(true);
    }

    
    public void BackButton_CloseScreen1()
    {
        screen1.SetActive(false);
    }

    
    public void BackButton_CloseScreen2()
    {
        screen2.SetActive(false);
    }

    public void BackButton()
    {
        screen1.SetActive(false);
    }

    public void BackButton2()
    {
        screen2.SetActive(false);
    }
}