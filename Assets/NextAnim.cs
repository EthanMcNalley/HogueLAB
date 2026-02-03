using Unity.Cinemachine;
using UnityEngine;

public class NextAnim : MonoBehaviour
{
    int cam_anim = 0;
    int priority = 0;
    public CinemachineCamera[] cams;
    void Start()
    {
        for (int i = 1; i < cams.Length; i++)
        {
            cams[i].Priority = 0;
            cams[i].gameObject.GetComponent<Animator>().enabled = false;
        }
    }


    public void NextAnimation()
    {
        cams[0].gameObject.GetComponent<Animator>().enabled = true;
        priority += 100;
        cams[0].Priority = priority;
        cam_anim += 1;
    }
}
