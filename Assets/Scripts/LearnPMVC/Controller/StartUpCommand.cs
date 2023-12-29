
using PureMVC.Interfaces;
using PureMVC.Patterns.Command;
using UnityEngine;
/// <summary>
/// 启动命令 做初始化操作
/// </summary>
public class StartUpCommand : SimpleCommand
{

    public override void Execute(INotification notification)
    {
        base.Execute(notification);
        //当命令执行时，调用该方法

        if (!Facade.HasProxy(PlayerProxy.NAME))
        {
            Facade.RegisterProxy(new PlayerProxy());

        }



    }

}
