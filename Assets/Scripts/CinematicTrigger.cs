using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CinematicTrigger : MonoBehaviour
{
    [SerializeField] GameObject fpsController;
    [SerializeField] GameObject cinematicCamera;
    [SerializeField] GameObject cutscene;

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Trigger");

        // Disable FPS Controller
        fpsController.SetActive(false);

        // Enable Cutscene object and CinematicCamera
        cinematicCamera.SetActive(true);
        cutscene.SetActive(true);
    }
}
