using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using RTLTMPro;

public class Languege : MonoBehaviour
{
    public RTLTextMeshPro Score;
    public RTLTextMeshPro Hiegh_Score;
   [SerializeField]
    public LanguegeType lan;

    void Start()
    {
        switch (lan)
        {
            case LanguegeType.Farsi:

                setFarsi();

                break;

            case LanguegeType.English:

                setEnglish();

                break;
        }


    }


    public enum LanguegeType{

     Farsi,
     English
    

     }


    public void setFarsi()
    {
        Score.text = "امتیاز";
        Hiegh_Score.text = "بیشترین امتیاز";
    }


    public void setEnglish()
    {
        Score.text = "score";
        Hiegh_Score.text = "High score";
    }




}
