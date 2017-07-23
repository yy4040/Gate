using UnityEngine;

public class MainScene : MonoBehaviour
{
    public void OnClickHero()
    {
        SceneController.LoadScene(SceneType.HERO);
    }
}
