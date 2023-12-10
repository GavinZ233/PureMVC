using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainView : MonoBehaviour
{
    public Button btnRole;

    public Text txtlevel;
    public Text txtname;


    public void UpdateInfo(PlayerDataObj data)
    {
        txtlevel.text = "LV."+data.lev.ToString();
        txtname.text=data.playerName;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
