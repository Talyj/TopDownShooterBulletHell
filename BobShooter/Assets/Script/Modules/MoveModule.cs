using UnityEngine;

public class MoveModule : ScriptableObject
{
    public float speedX;
    public float speedY;
    public float move;
    public Transform playerTransform;

    public void SpeedX(float speedX)
    {
        this.speedX = speedX;
    }

    public void SpeedY(float speedY)
    {
        this.speedY = speedY;
    }

    public MoveModule(float speedX, float speedY, Transform playerTransform)
    {
        this.speedX = speedX;
        this.speedY = speedY;
        this.playerTransform = playerTransform;
    }
}
