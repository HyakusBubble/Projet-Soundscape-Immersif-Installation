using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class door_switch : MonoBehaviour
{
    [SerializeField]
    bool is_Inside;
    [SerializeField]
    bool is_Out;
    bool stop;
    [SerializeField]
    public Object[] SceneArray;
    [SerializeField]
    public static string ChosenScene;
    public Object BufferScene;

    public static int RdmValue;

    // Use this for initialization
    private void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("switch");

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }

    void Start()
    {

    }



    IEnumerator PorteFerme()
    {
        
        if (is_Inside == true && is_Out == true )
        {
            is_Out = false;
            yield break;
        }
        if (is_Inside == true && is_Out == false)
        {
            RandomScene();
            SceneManager.LoadScene(BufferScene.name);
            is_Inside = false;
            is_Out = true;
            yield break;
            //Gets out
        }


    }

    // Use this for initialization


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.LeftArrow) && is_Inside == false && is_Out == true)
        {
            SceneManager.LoadScene(ChosenScene);
            is_Inside = true;
            // open the doors from outside
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            StartCoroutine(PorteFerme());
        }


    }

    void RandomScene()
    {
        int oldRdm = RdmValue;
        RdmValue = Random.Range(0, SceneArray.Length);
        while (RdmValue == oldRdm)
        {
            RdmValue = Random.Range(0, SceneArray.Length);
        }


        ChosenScene = SceneArray[RdmValue].name;
        Debug.Log(SceneArray[RdmValue].name);

    }
    void SceneLoader(string strn)
    {
        SceneManager.LoadScene(strn);
    }
}

    