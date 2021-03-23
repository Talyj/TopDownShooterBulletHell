using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmerMove : MonoBehaviour
{
    List<ScriptableObject> Modules;
    public MoveModule moveComponent;

    private Vector2 speed = new Vector2(0.1F, 0.1F);
    
    private float frequency;
    private float magnitude;

    [SerializeField]
    public GameObject farmer;

    Vector3 pos, localScale, move;

    private void Start() {
        //moveComponent = new MoveModule(speed.x * Input.GetAxis("Horizontal"), speed.y * Input.GetAxis("Vertical"), this.gameObject.transform);
        moveComponent = new MoveModule(speed.x , speed.y, this.gameObject.transform);

        Modules = new List<ScriptableObject>();
        Modules.Add(moveComponent);
        TAccessor<MoveModule>.Instance().Add(moveComponent);

        frequency = 2.0F;
        magnitude = Random.Range(0.005F, 0.008F);
    }

    private void Update()
    {
        move = new Vector3(speed.x, speed.y, 0) * Time.deltaTime;
        
        if(farmer.tag == "FarmerHorizontal") {
            MoveHorizontal();
        } else if(farmer.tag == "FarmerVertical") {
            MoveVertical();
        }
    }

    private void MoveHorizontal() {
        transform.position += move + transform.up * Mathf.Sin(Time.time * frequency) * magnitude;
        transform.position += transform.right * Time.deltaTime;
    }

    private void MoveVertical() {
        transform.position += move + transform.right * Mathf.Sin(Time.time * frequency) * magnitude;
        transform.position -= transform.up * Time.deltaTime;
    }
}
 