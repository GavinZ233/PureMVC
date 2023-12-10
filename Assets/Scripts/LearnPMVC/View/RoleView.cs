using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoleView : MonoBehaviour
{
    public Button btnClose;
    public Button btnGrown;

    public Text txtMoney;
    public Text txtHP;
    public Text txtAtk;
    public Text txtDef;

    public void UpdateInfo(PlayerDataObj data)
    {
        txtMoney.text=data.money.ToString();
        txtHP.text = data.hp.ToString();
        txtAtk.text = data.atk.ToString();
        txtDef.text = data.def.ToString();

    }
}
