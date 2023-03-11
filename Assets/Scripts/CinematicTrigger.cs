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

        // disable fps controller
        fpsController.SetActive(false);

        // enable cutscene object and cinematic camera
        cinematicCamera.SetActive(true);
        cutscene.SetActive(true);
    }
}
