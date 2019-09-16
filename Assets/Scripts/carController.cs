using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class carController : MonoBehaviour {

	public float carSpeed;
	public float maxPos = 3f;
    public Text scoreText;

    private int score;

    Vector3 position;

	// Use this for initialization
	void Start () {
		position = transform.position;
        score = 0;
        SetCountText();
    }
	
	// Update is called once per frame
	void Update () {

		position.x += Input.GetAxis ("Horizontal") * carSpeed * Time.deltaTime;

		position.x = Mathf.Clamp (position.x, -1.8f, 1.8f);
		
		/*if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			position.x = -2.2f;
		}
		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			position.x = 2.2f;
		}*/

		transform.position = position;

	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Enemy Car") {
			Application.LoadLevel ("GameOver");
		}
        if (col.gameObject.tag == "Point")
        {
            Destroy(col.gameObject);
            score = score + 1;
            SetCountText();
        }

    }

    void SetCountText()
    {
        scoreText.text = " " + score.ToString();
    }


}
