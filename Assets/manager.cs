using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class manager : MonoBehaviour
{
      bool gameHasEnded = false;

    public void CompleteLevel()
    {
        Debug.Log("LEVEL COMPLETED, CONGRASS!"); 
    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("game over");
            Invoke("Restart",3f);    //restart after 3 seconds 
        }
    }
    // Start is called before the first frame update
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
