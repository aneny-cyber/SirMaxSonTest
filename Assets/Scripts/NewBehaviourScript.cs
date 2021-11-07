using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    float speed = 3.0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal")!= 0f)
        {
            transform.Translate(new Vector2(Input.GetAxis("Horizontal") * Time.deltaTime * speed, 0f));
        }
    }
}
