using PureMVC.Interfaces;
using PureMVC.Patterns.Command;
using PureMVC.Patterns.Mediator;
using UnityEngine;

/// <summary>
/// 隐藏面板
/// Body处理的是Mediator
/// </summary>
public class HidePanelCommand : SimpleCommand
{
    public override void Execute(INotification notification)
    {
        base.Execute(notification);

        //
        Mediator m=notification.Body as Mediator;

        if (m!=null&&m.ViewComponent != null)
        {
            GameObject.Destroy((m.ViewComponent as MonoBehaviour).gameObject);

            m.ViewComponent=null;
        }
    }


}
