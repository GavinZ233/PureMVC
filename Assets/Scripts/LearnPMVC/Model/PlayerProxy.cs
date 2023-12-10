using PureMVC.Patterns.Proxy;
using UnityEngine;

/// <summary>
/// 玩家数据代理对象
/// 处理玩家数据更新相关逻辑
/// </summary>
public class PlayerProxy : Proxy
{
    public new const string NAME = "PlayerProxy";

    /// <summary>
    /// 继承父类的构造函数
    /// </summary>
    /// <param name="proxyName"></param>
    /// <param name="data"></param>
    public PlayerProxy() : base(PlayerProxy.NAME)
    {
        //构造函数初始化一个数据   
        PlayerDataObj data= new PlayerDataObj();   
        

        //初始化
        data.playerName=PlayerPrefs.GetString("PlayerName","吴彦祖");
        data.lev = PlayerPrefs.GetInt("PlayerLev",0);
        data.money = PlayerPrefs.GetInt("PlayerMoney", 32);
        data.hp = PlayerPrefs.GetInt("PlayerHP", 100);
        data.atk = PlayerPrefs.GetInt("PlayerAtk", 11);
        data.def = PlayerPrefs.GetInt("PlayerDef", 5);


        Data = data;
    }
    /// <summary>
    /// 升级方法
    /// </summary>
    public void LevUp()
    {
        PlayerDataObj data=Data as PlayerDataObj;
        //升级改变数据
        data.lev++;
        data.money++;
        data.hp++;
        data.atk++;
        data.def++;
    }

    /// <summary>
    /// 保存数据
    /// </summary>
    public void SaveData()
    {
        PlayerDataObj data = Data as PlayerDataObj;
        //升级改变数据
        PlayerPrefs.SetString("PlayerName",data.playerName);
        PlayerPrefs.SetInt("PlayerLev", data.lev);
        PlayerPrefs.SetInt("PlayerMoney", data.money);
        PlayerPrefs.SetInt("PlayerHP", data.hp);
        PlayerPrefs.SetInt("PlayerAtk", data.atk);
        PlayerPrefs.SetInt("PlayerDef", data.def);

    }
}
