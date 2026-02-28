using UnityEngine;

public class GameInput : MonoBehaviour
{
    private PlayerInputActions playerInputActions;

    private void Awake()
    {
        // создаём экземпляр Input Actions
        playerInputActions = new PlayerInputActions();
        playerInputActions.Player.Enable(); // включаем действия
    }

    // Получение нормализованного вектора движения
    public Vector2 GetMovementVectorNormalized()
    {
        Vector2 inputVector = playerInputActions.Player.Move.ReadValue<Vector2>();
        return inputVector.normalized;
    }

    private void OnDisable()
    {
        // отключаем Input Actions при отключении объекта
        playerInputActions.Player.Disable();
    }
}