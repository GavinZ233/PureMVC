
using PureMVC.Interfaces;
using PureMVC.Patterns.Mediator;
public class MainViewMediator : Mediator
{
    public static new string NAME = "MainViewMediator";
    public MainViewMediator() : base(NAME)
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


    public void SetView(MainView view)
    {
        ViewComponent=view;
        view.btnRole.onClick.AddListener(() =>
        {
            SendNotification(PureNotification.SHOW_PANEL, "RolePanel");
        });
    }

    public override void HandleNotification(INotification notification)
    {
        //通知名，包含信息
        switch (notification.Name)
        {
            case PureNotification.UPDATE_PLAYER_INFO:
                //收到更新通知做逻辑处理
                (ViewComponent as MainView).UpdateInfo(notification.Body as PlayerDataObj);
                break;
        }
    }



}
