using TMPro;
using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject cube;
    public TextMeshProUGUI txtScreenSize;
    public Vector3 RotateAmount;
    
    void Update()
    {
        cube.transform.Rotate(RotateAmount * Time.deltaTime);
        txtScreenSize.SetText($"{Screen.width} X {Screen.height}");
    }
}
