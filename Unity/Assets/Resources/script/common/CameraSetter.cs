using UnityEngine;

public class CameraSetter : MonoBehaviour
{
	void Start ()
    {
        Camera.main.aspect = 1280f / 768f;
    }
}
