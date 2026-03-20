using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // ตัวแปรสำหรับเก็บตำแหน่งของเป้าหมายที่กล้องจะติดตาม
    public Vector3 offset = new Vector3(0, 3, -8); // ระยะห่างระหว่างกล้องกับเป้าหมาย
    public float smoothSpeed = 5f; // ความเร็วในการเคลื่อนที่ของกล้อง
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void LateUpdate()
    {
    Vector3 desiredPosition = target.position + offset; // คำนวณตำแหน่งที่ต้องการให้กล้องอยู่
        transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime); // เคลื่อนที่กล้องไปยังตำแหน่งที่ต้องการอย่างนุ่มนวล

        Quaternion targetrotation = Quaternion.LookRotation(target.position - transform.position); // หมุนกล้องให้มองไปที่เป้าหมาย
        transform.rotation = Quaternion.Lerp(transform.rotation, targetrotation, smoothSpeed * Time.deltaTime); // หมุนกล้องอย่างนุ่มนวล
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
