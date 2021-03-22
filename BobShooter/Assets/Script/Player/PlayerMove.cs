using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    List<ScriptableObject> Modules;
    public MoveModule moveComponent;

    public Vector2 speed = new Vector2(20, 20);

    private void Start()
    {


        moveComponent = new MoveModule(speed.x * Input.GetAxis("Horizontal"), speed.y * Input.GetAxis("Vertical"), this.gameObject.transform);

        Modules = new List<ScriptableObject>();
        Modules.Add(moveComponent);
        TAccessor<MoveModule>.Instance().Add(moveComponent);
    }

    private void FixedUpdate()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(speed.x * inputX, speed.y * inputY, 0) * Time.deltaTime;

        transform.Translate(move);
    }

}
