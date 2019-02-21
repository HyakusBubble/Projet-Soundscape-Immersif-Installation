using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class door_switch : MonoBehaviour {

    bool is_Inside;
    bool got_Out;
    string sceneName;
    Scene act_Scene;
    // Use this for initialization
    void Start () {
        
        is_Inside = false;
        got_Out = false;

        act_Scene = SceneManager.GetActiveScene();
        sceneName = act_Scene.name;
    
    }
	
	// Update is called once per frame
	void Update () {
        //quand la porte s'ouvre
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (is_Inside == false)
            { is_Inside = true;
                Debug.Log("GET IN");
                Debug.Log("Inside" + is_Inside);
                Debug.Log("Out" + got_Out);
            }
            //le joueur est dedans et y'a une scène jouée
            
           else if (is_Inside == true && got_Out == false)
            {
                is_Inside = false;
                got_Out = true;
                Debug.Log("Get Out");
                Debug.Log("Inside" + is_Inside);
                Debug.Log("Out" + got_Out);
                //le joueur sort 
            }
            if (sceneName == "jungle" && is_Inside == false && got_Out == true) 
            {//si le joueur n'est plus dedans & est sorti
                SceneManager.LoadScene("neon");
                got_Out = false;
                Debug.Log("Switch");
                Debug.Log("Inside" + is_Inside);
                Debug.Log("Out" + got_Out);
            }   
        }
    }
}
