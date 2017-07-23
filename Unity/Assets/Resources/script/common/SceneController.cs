using UnityEngine.SceneManagement;

public enum SceneType
{
    MAIN,
    GAME,
    HERO,
    ARTEFACT,
    OPTION
}

public class SceneController
{
    public static void LoadScene(SceneType type)
    {
        switch (type)
        {
            case SceneType.MAIN:
                SceneManager.LoadScene("Main");
                break;

            case SceneType.HERO:
                SceneManager.LoadScene("Hero");
                break;
        }
    }
}
