using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject mainMenuCanvas;
    [SerializeField] private GameObject mainGameCanvas;
    [SerializeField] private GameObject gameOverCanvas;

    private GameObject actualCanvas;  
    private GameObject previousCanvas;       
  
    // Start is called before the first frame update
    void Start()
    {
        SetMainMenuCanvas();
    }

    public void SetMainMenuCanvas() {
        SetActualCanvasAndActivate(mainMenuCanvas);
    }

    public void SetMainGameCanvas() {
        SetActualCanvasAndActivate(mainGameCanvas);
    }

    public void SetGameOverCanvas() {
        SetActualCanvasAndActivate(gameOverCanvas);
    }

    private void SetActualCanvasAndActivate(GameObject canvas) {
        SetPreviousCanvasAndSetInactive();
        actualCanvas = canvas;
        actualCanvas.SetActive(true);
    }

    private void SetPreviousCanvasAndSetInactive() {
        if(actualCanvas != null){
            previousCanvas = actualCanvas;
            previousCanvas.SetActive(false);
        }
    }    
}
