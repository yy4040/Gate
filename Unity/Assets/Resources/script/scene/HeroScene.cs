using UnityEngine;

public class HeroScene : MonoBehaviour
{
    public void OnClickExit()
    {
        SceneController.LoadScene(SceneType.MAIN);
    }
}
