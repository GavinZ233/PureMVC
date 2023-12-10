

using PureMVC.Interfaces;
using PureMVC.Patterns.Facade;

public class GameFacade : Facade
{

   public static GameFacade Instance {
        get
        {
            if (instance == null)
                instance=new GameFacade();
            return instance as GameFacade;
        }
       
    }
    /// <summary>
    /// 初始化控制层
    /// </summary>
    protected override void InitializeController()
    {
        base.InitializeController();
        //关于命令和通知绑定的逻辑

        RegisterCommand(PureNotification.START_UP, () =>
        {
            return new StartUpCommand();
        });

        RegisterCommand(PureNotification.SHOW_PANEL, () => { 
            return new ShowPanelCommand();
        });

    }

    public void StartUp()
    {
        SendNotification(PureNotification.START_UP);
        SendNotification(PureNotification.SHOW_PANEL,"MainPanel");
    }



}
