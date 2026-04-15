using UnityEngine;

public class GoalTrigger : MonoBehaviour
{
    public GameObject goalText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (goalText != null)
            {
                goalText.SetActive(true);

                GoalTextFade fadeScript = goalText.GetComponent<GoalTextFade>();
                if (fadeScript != null)
                {
                    fadeScript.ShowText();
                }
            }

            CarController car = other.GetComponent<CarController>();
            if (car != null)
            {
                car.canDrive = false;
            }
        }
    }
}