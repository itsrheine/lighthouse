using UnityEngine;

public class StartGameManager : MonoBehaviour
{
    public GameObject startPanel;
    public CarController carController;

    private bool gameStarted = false; // 👈 MUST be here (outside Update)

    void Update()
    {
        if (!gameStarted && Input.GetKeyDown(KeyCode.Space))
        {
            gameStarted = true;

            if (startPanel != null)
                startPanel.SetActive(false);

            if (carController != null)
                carController.canDrive = true;
        }
    }
}