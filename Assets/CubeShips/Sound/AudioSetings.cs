using UnityEngine.UI;
using UnityEngine;

public class AudioSetings : MonoBehaviour
{
    private static readonly string FirstPlay = "FirstPlay";
    private int firstPlayInt;
    public Slider backgroundSlider, soundEffectsSlider;
    private float backgroundFloat, soundEffectsFloat;

    void Start()
    {
        firstPlayInt = PlayerPrefs.GetInt(FirstPlay);

        if(firstPlayInt == 0)
        {

        }
        else
        {

        }
    }

}
