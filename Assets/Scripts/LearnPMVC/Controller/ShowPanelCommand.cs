using PureMVC.Interfaces;
using PureMVC.Patterns.Command;
using PureMVC.Patterns.Mediator;
using UnityEngine;

public class ShowPanelCommand : SimpleCommand
{
    public override void Execute(INotification notification)
    {
        base.Execute(notification);
        string panelName=notification.Body.ToString();

        switch (panelName)
        {
            case"MainPanel":
                //显示主面板
                //ShowPanel<MainViewMediator, MainView>(MainViewMediator.NAME, "UI/MainPanel");
                //注册Mediator
                if (!Facade.HasMediator(MainViewMediator.NAME))
                {
                    Facade.RegisterMediator(new MainViewMediator());
                }
                //得到Mediator
                MainViewMediator mvm = Facade.RetrieveMediator(MainViewMediator.NAME) as MainViewMediator;

                if (mvm.ViewComponent == null)
                {
                    //实例化面板

                    GameObject obj = GameObject.Instantiate(Resources.Load<GameObject>("UI/MainPanel"));

                    obj.transform.SetParent(GameObject.Find("Canvas").transform, false);

                    mvm.SetView(obj.GetComponent<MainView>());
                }


                break;
            case"RolePanel":
                //显示角色面板
               // ShowPanel<RoleViewMediator, RoleView>(RoleViewMediator.NAME, "UI/RolePanel");
                //注册Mediator
                if (!Facade.HasMediator(RoleViewMediator.NAME))
                {
                    Facade.RegisterMediator(new RoleViewMediator());
                }
                //得到Mediator
                RoleViewMediator rvm = Facade.RetrieveMediator(RoleViewMediator.NAME) as RoleViewMediator;

                if (rvm.ViewComponent == null)
                {
                    //实例化面板

                    GameObject obj = GameObject.Instantiate(Resources.Load<GameObject>("UI/RolePanel"));

                    obj.transform.SetParent(GameObject.Find("Canvas").transform, false);

                    rvm.ViewComponent = obj.GetComponent<RoleView>();
                    
                }
                break;
            default:
                break;
        }

        
    }
/// <summary>
/// 显示面板
/// </summary>
/// <typeparam name="T">Mediator类</typeparam>
/// <typeparam name="K">面板类</typeparam>
/// <param name="className">目标类的NAME</param>
/// <param name="panelPath">面板预制体路径</param>
    private void ShowPanel<T,K>(string className,string panelPath) where T: Mediator,new() where K : MonoBehaviour
    {

        //注册Mediator
        if (!Facade.HasMediator(className))
        {
            Facade.RegisterMediator(new T());
        }
        //得到Mediator
        T t = Facade.RetrieveMediator(className) as T;

        if (t.ViewComponent == null)
        {
            //实例化面板

            GameObject obj = GameObject.Instantiate(Resources.Load<GameObject>(panelPath));

            obj.transform.SetParent(GameObject.Find("Canvas").transform, false);

            t.ViewComponent = obj.GetComponent<K>();

            
        }
    }



}
