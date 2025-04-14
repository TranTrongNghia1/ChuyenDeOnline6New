using Fusion;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public NetworkRunner _runner;
    public NetworkSceneManagerDefault _sceneManager;
    [SerializeField] TMP_Text enemiesLeftText;
    [SerializeField] GameObject youWinText;

    int enemiesLeft = 0;

    const string ENEMIES_LEFT_STRING = "Enemies Left: ";

    public void AdjustEnemiesLeft(int amount)
    {
        enemiesLeft += amount;
        enemiesLeftText.text = ENEMIES_LEFT_STRING + enemiesLeft.ToString();

        if (enemiesLeft <= 0)
        {
            youWinText.SetActive(true);
        }
    }

    public void RestartLevelButton()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene);
    }

    public void QuitButton()
    {
        Debug.LogWarning("Does not work in the Unity Editor!  You silly goose!");
        Application.Quit();
    }
    //private void Awake()
    //{
    //    if (_runner == null)
    //    {
    //        GameObject runnerObj = new GameObject("NetworkRunner");
    //        _runner = runnerObj.AddComponent<NetworkRunner>();
    //        _runner.AddCallbacks(this);
    //        _sceneManager = runnerObj.AddComponent<NetworkSceneManagerDefault>();
    //    }
    //}
    //public void OnPlayerJoined(NetworkRunner runner, PlayerRef player)
    //{
    //    Debug.Log("A Player has joined:" + player);
    //    if (_runner.LocalPlayer != player) return;

    //    //spawn nguoi choi
    //    _runner.Spawn(
    //        prefab,
    //        position,
    //        Quaternion.identity,
    //        player,
    //        (r, o) =>
    //        {

    //        });
    //}
}
