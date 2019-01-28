using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    void Start() {

    }
    
    public void NextScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
