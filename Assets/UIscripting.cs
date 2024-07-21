using Cinemachine;
using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UIscripting : MonoBehaviour
{
    public CinemachineFreeLook cam25
        ;
    public CinemachineFreeLook cam3;

    private CinemachineFreeLook activeCamera;

    [SerializeField] Canvas gameOverCanvas;
    public Camera main;
    // Start is called before the first frame update
    void Start()
    {
        if(Camera.main != null)
        {
            main.enabled = false;
            main.enabled = true;

        }

        // Initially set camera1 as the active camera
        activeCamera = cam25;
        cam25.Priority = 3;
        cam3.Priority = 2;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Try()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void GoBack()
    {
        SceneManager.LoadScene(0);
    }

    public void SetCam25()
    {
        cam25.Priority = 1;
        cam3.Priority = 0;
        cam3.enabled = false;
        gameOverCanvas.enabled = false;
    }

    public void SetCam3()
    {

        cam25.Priority = 0;
        cam3.Priority = 1;
        cam25.enabled = false;  
        gameOverCanvas.enabled = false;
    }

    public void quit()
    {
        Application.Quit();
    }
}
