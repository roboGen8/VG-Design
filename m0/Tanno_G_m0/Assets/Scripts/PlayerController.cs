using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public Text countText;
    public Text winText;
    public GameObject prefab;

    private Rigidbody rb;
    private int count;
    private void Start()
    {
        prefab = Resources.Load("projectile") as GameObject;
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winText.text = "";
    }
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed * 3);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject projectile = Instantiate(prefab) as GameObject;

            projectile.transform.position = transform.position - Camera.main.transform.forward;
            //projectile.transform.position = rb.position * Random.Range(-1.0f, 1.0f);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 12) {
            winText.text = "You Win";
        }
    }
}
