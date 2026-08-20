using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
 public void PlayGame()
    {
        int SelectedCharacter =
         int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);

        GameManager.instance.CharIndex = SelectedCharacter;

        SceneManager.LoadScene("gameplay");
    }
}