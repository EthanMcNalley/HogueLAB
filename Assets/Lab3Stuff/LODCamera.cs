using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class LODCamera : MonoBehaviour
{
    float distance_to_unrender = 25.0f;
    [SerializeField] Camera portal_cam;

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, Camera.main.transform.position) > distance_to_unrender)
        {
            portal_cam.enabled = false;
        }

        else
        {
            portal_cam.enabled = true;
        }


    }
}
