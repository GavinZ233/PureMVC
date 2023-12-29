
/// <summary>
/// 通知类
/// 声明各种通知的名称
/// </summary>
public class PureNotification 
{
    /// <summary>
    /// 启动
    /// </summary>
    public const string START_UP = "startUp";

    /// <summary>
    /// 打开面板
    /// Body内容是面板名称
    /// </summary>
    public const string SHOW_PANEL = "showPanel";
    /// <summary>
    /// 隐藏面板
    /// Body内容是Mediator
    /// </summary>
    public const string HIDE_PANEL = "hidePanel";

    /// <summary>
    /// 更新玩家数据
    /// </summary>
    public const string UPDATE_PLAYER_INFO = "updatePlayerInfo";
    /// <summary>
    /// 升级  
    /// 不需要传参，数据在Command自动寻找
    /// </summary>
    public const string LEV_UP = "levUp";

}
