using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Kill : MonoBehaviour
{
    public static bool dead;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(dead)
        {
            StartCoroutine("isDead");
        }
        

        
    }

    IEnumerator isDead ()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("SimpleScene"); 

    }

    
    
   

}
