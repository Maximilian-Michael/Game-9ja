using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour
{
    public AnimationClip closeAnim;
    public Animation easyAnim;
    public GameObject mainMenu;
    public GameObject playMenu;
    

    
    public void Close()
    {
        StartCoroutine(CountDown());
       
    }
    private IEnumerator CountDown()
    {
        Animator animator = GetComponent<Animator>();

       
        
            animator.Play(closeAnim.name);

            yield return new WaitForSeconds(closeAnim.length);
            playMenu.gameObject.SetActive(false);
            mainMenu.gameObject.SetActive(true);
        
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
