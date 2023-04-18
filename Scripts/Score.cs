using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public Transform player;
    public TMP_Text scoreText;
    int x = -7;
    void Start(){
        float x = player.position.z;

    }
    
    void Update()
    {
        float newZ = player.position.z - x;
        scoreText.text =  newZ.ToString("0");
        //Debug.Log(player.position.z);
    }
}
