using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManagerScript : MonoBehaviour
{
    public Text counterText;

    private void Start()
    {
        counterText.text = PersistentManagerScript.Instance.counter.ToString();
    }

    public void GoToSc1()
    {
        SceneManager.LoadScene("Scene1");
        PersistentManagerScript.Instance.counter++;
    }

    public void GoToSc2()
    {
        SceneManager.LoadScene("Scene2");
        PersistentManagerScript.Instance.counter++;
    }
}
