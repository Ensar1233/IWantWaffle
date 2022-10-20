using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class MoneyEffect : MonoBehaviour
{

    [SerializeField] GameObject floatingTextPrefab;
    [SerializeField] Vector3 offset = new Vector3(0f,2f,0f);
    
    public void ShowFloatingText(string text)
    {
        floatingTextPrefab.GetComponent<TextMeshPro>().text = text;
        
        Vector3 currentPosition =  transform.position-offset;
        
        Instantiate(floatingTextPrefab, currentPosition, Quaternion.identity);

        Score(GetMoneyValue(text));
    }

    private string GetMoneyValue(string text)
    {
        char[] array = text.ToCharArray();
        return array[0].ToString();
    }
    public void Score(string score)
    {
        
        int money = GameManager.moneyScore +=int.Parse(score);
        GameObject.Find("Score").GetComponent<TextMeshProUGUI>().text = "$"+money.ToString();
    }
}
