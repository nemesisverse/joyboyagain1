using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UIscripting : MonoBehaviour
{
    public GameObject cam25;
    public GameObject cam3;
    [SerializeField] Canvas gameOverCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Try()
    {
        SceneManager.LoadScene(1);
    }
    public void GoBack()
    {
        SceneManager.LoadScene(0);
    }

    public void SetCam25()
    {
       cam3.SetActive(false);
        cam25.SetActive(true);
        gameOverCanvas.enabled = false;
    }

    public void SetCam3()
    {

        cam25.SetActive(false);
        cam3.SetActive(true);
        gameOverCanvas.enabled = false;
    }
}
