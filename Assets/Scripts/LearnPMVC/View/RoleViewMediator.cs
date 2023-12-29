﻿

using PureMVC.Interfaces;
using PureMVC.Patterns.Mediator;

public class RoleViewMediator : Mediator
{
    public static new string NAME = "RoleViewMediator";
    public RoleViewMediator() : base(NAME)
    {
        //创建页面预制体

    }

    //监听通知
    public override string[] ListNotificationInterests()
    {
        //返回的字符串数组，会被监听记录
        return new string[]{
            PureNotification.UPDATE_PLAYER_INFO,

        };
    }

    public void SetView(RoleView view)
    {
        ViewComponent=view;
        view.btnClose.onClick.AddListener(() =>
        {
            SendNotification(PureNotification.HIDE_PANEL, this);
        });
        view.btnGrown.onClick.AddListener(() =>
        {
            SendNotification(PureNotification.LEV_UP);
        });
    }

    public override void HandleNotification(INotification notification)
    {
        //通知名，包含信息
        switch (notification.Name)
        {
            case PureNotification.UPDATE_PLAYER_INFO:
                //收到更新通知做逻辑处理
                if (ViewComponent!=null)
                {
                    (ViewComponent as RoleView).UpdateInfo(notification.Body as PlayerDataObj);

                }
                break;
        }
    }



}
