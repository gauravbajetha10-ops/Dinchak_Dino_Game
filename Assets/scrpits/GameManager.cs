using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;  
    [SerializeField]
    private GameObject[] characters;
    
    private int _charIndex;
    public int CharIndex
    {
        get { return _charIndex; }
        set { _charIndex = value; }
    }
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnlevelFinishedloading;
    }
    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnlevelFinishedloading;
    }

   void OnlevelFinishedloading(Scene scene, LoadSceneMode mode) {
        if (scene.name == "gameplay") {
            Instantiate(characters[CharIndex]);
        }
    }
 
}
