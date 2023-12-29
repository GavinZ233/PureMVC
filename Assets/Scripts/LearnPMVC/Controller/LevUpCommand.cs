
using PureMVC.Interfaces;
using PureMVC.Patterns.Command;

public class LevUpCommand : SimpleCommand
{
    public override void Execute(INotification notification)
    {
        base.Execute(notification);

        PlayerProxy playerProxy =Facade.RetrieveProxy(PlayerProxy.NAME) as PlayerProxy;

        if (playerProxy != null)
        {
            playerProxy.LevUp();
            playerProxy.SaveData();
            SendNotification(PureNotification.UPDATE_PLAYER_INFO, playerProxy.Data);
        }
    }



}
