using UnityEngine;

public class GoalTrigger : MonoBehaviour
{
    public GameObject goalText; // 👈 THIS is what creates the drag field

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("You made it to the lighthouse!");

            if (goalText != null)
            {
                goalText.SetActive(true);
            }
        }
    }
}