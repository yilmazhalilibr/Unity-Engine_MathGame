using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fourtProcess : MonoBehaviour
{
    public UnityEngine.UI.Text firstValue,secondValue,process,InputValue,result;
    public UnityEngine.UI.InputField InputVal;
    double value1,value2,procesRandom;
    double processAnswer;
    // Start is called before the first frame update
    void Start()
    {
        yeniSoru();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LastResult() 
    {
        if (int.Parse(InputValue.text)==processAnswer) 
        {
            result.text = "DOGRU";
        }
        else { result.text = "YANLIS"; }
    }
    public void yeniSoru() 
    {
        InputValue.text = "";
        result.text = "";
        InputVal.text = "";
        value1 = Random.Range(2, 10);
        value2 = Random.Range(2, 10);
        procesRandom = Random.Range(1, 5);
        switch (procesRandom)
        {
            case 1:
                process.text = "+";
                processAnswer = value1 + value2;
                break;
            case 2:
                process.text = "-";
                processAnswer = value1 - value2;
                break;
            case 3:
                process.text = "*";
                processAnswer = value1 * value2;
                break;
            case 4:
                process.text = "/";
                processAnswer = value1 / value2;
                break;

        }
        firstValue.text = value1.ToString();
        secondValue.text = value2.ToString();
    }
}
