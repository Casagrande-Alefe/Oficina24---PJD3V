using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextlevel : MonoBehaviour
{
    // Start is called before the first frame update
    public string lvlName;
    
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        
        if(GameController.instance.apples == 0 && collision.gameObject.tag == "Player") 
        {
            SceneManager.LoadScene(lvlName);
        }
    }

}
