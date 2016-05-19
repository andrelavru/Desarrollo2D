using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Runner.Utils;

public class GameOverPanel : MonoBehaviour {

    // Use this for initialization
    [SerializeField]
    private Button start, quit;
    public static GameOverPanel instance;
    float posY;

    void Awake()
    {
        instance = this;
    }
    void Start() {
        start.onClick.AddListener(() => restartGame());
        quit.onClick.AddListener(() => quitApp());
        posY = transform.position.y;
        transform.position = new Vector3(transform.position.x, transform.position.y +10f,transform.position.z);
	}

    void restartGame()
    {
        SceneManager.LoadScene(Global.GAME);
    }

    void quitApp()
    {
        Application.Quit();
    }

    public void show()
    {
        iTween.MoveTo(gameObject, iTween.Hash("y", posY));
    }
}
