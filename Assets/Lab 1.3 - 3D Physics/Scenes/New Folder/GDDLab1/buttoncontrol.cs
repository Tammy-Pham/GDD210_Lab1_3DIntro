using UnityEngine;
using UnityEngine.SceneManagement; 

public class buttoncontrol : MonoBehaviour
{
    public void Restart()
    {

        SceneManager.LoadScene(0);
        Debug.Log("restarts");
    }

}
