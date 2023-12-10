
using PureMVC.Interfaces;
using PureMVC.Patterns.Command;
using UnityEngine;

public class StartUpCommand : SimpleCommand
{

    public override void Execute(INotification notification)
    {
        base.Execute(notification);
        //当命令执行时，调用该方法

        Debug.Log("执行命令");

    }

}
