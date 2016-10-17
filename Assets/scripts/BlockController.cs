using UnityEngine;
using System.Collections;

public class BlockController : MonoBehaviour {
    //enum HealthColor {purple=1,dark_blue,light_blue,green,yellow,orange,red}
    public int health=7;
    private Color[] healtColor;
    Renderer rend;
    // Use this for initialization
    void Start()
    {
        if (health > 7) health = 7;
        healtColor = new Color[8];
        healtColor[0] = Color.clear;
        healtColor[1] = Color.white;
        healtColor[2] = Color.magenta;
        healtColor[3] = Color.blue;
        healtColor[4] = Color.cyan;
        healtColor[5] = Color.green;
        healtColor[6] = Color.yellow;
        healtColor[7] = Color.red;
        rend = GetComponent<Renderer>();
        rend.material.shader = Shader.Find("Specular");
        rend.material.SetColor("_Color", healtColor[health]);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionExit(Collision col)
    {

        if (col.collider.tag.Equals("Ball"))
        {
            if(health>0)health--;
            rend.material.SetColor("_Color", healtColor[health]);
            if(health==0)Destroy(gameObject);
        }
    }
}
