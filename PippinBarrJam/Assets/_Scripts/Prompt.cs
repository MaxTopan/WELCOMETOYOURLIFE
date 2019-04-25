using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Prompt : MonoBehaviour
{
    public Text promptText;
    public string promptString;
    public float pauseTime = 0.4f;
    public Camera mainCam;
    public GameObject previousObj;
    public GameObject secondObj;
    public AudioSource click;
    public bool killPlayer = false;
    public bool disableSprite = false;

    public Color colourA = new Color(1.0f, 0.95f, 0.0f);
    public Color colourB = new Color(0.55f, 0.52f, 0.0f);
    public Color cameraAfter = Color.black;
    private GameObject player;
    private SpriteRenderer sr;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        StartCoroutine(PromptTrigger());
    }

    public IEnumerator PromptTrigger()
    {
        if (previousObj != null)
            Destroy(previousObj);

        if (disableSprite == true)
            Destroy(sr);

        if (killPlayer == true)
            Destroy(player);

        mainCam.backgroundColor = colourA; // turn screen to first colour
        click.Play(); // sound off a click

        promptText.color = colourB; // turn prompt text to other colour
        promptText.text = promptString; // turn text on (darker yellow)

        yield return new WaitForSeconds(pauseTime);

        mainCam.backgroundColor = cameraAfter; // turn screen black again
        click.Play();
        promptText.color = colourA; // turn prompt text (normal)yellow

        if (sr != null)
            if (disableSprite == false)
                sr.color = colourB; // turn start to faded colour (139, 139, 139)

        if (secondObj != null)
            secondObj.SetActive(true); // turn second object on

        Destroy(this); // delete this script
    }
}
