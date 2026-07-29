using System;
using System.Collections.Generic;

namespace MapLinker.Gui
{
    internal sealed class Localizer
    {
        public string Language = "en";
        private readonly Dictionary<string, string> zhTw = new();

        public Localizer(string language = "en")
        {
            Language = language;
            LoadZhTw();
        }

        public string Localize(string message)
        {
            if (message == null)
                return message;
            if (Language.StartsWith("zh", StringComparison.OrdinalIgnoreCase))
                return zhTw.TryGetValue(message, out var translation) ? translation : message;
            return message;
        }

        private void LoadZhTw()
        {
            zhTw.Add("Panel", "面板");
            zhTw.Add("TabBar", "分頁列");
            zhTw.Add("Settings", "設定");
            zhTw.Add("General Settings", "一般設定");
            zhTw.Add("Recording", "記錄地圖連結");
            zhTw.Add("Tooltips", "顯示說明");
            zhTw.Add("Reverse sorting", "最新記錄優先");
            zhTw.Add("Call /tp to teleport to the nearest aetheryte", "使用 /tp 傳送至最近的傳送網");
            zhTw.Add("Language:", "介面語言：");
            zhTw.Add("Print Debug Message", "顯示偵錯訊息");
            zhTw.Add("Print Error Message", "顯示錯誤訊息");
            zhTw.Add("Filters", "頻道篩選");
            zhTw.Add("Records", "記錄");
            zhTw.Add("Filter out duplicates", "略過重複連結");
            zhTw.Add("FiltersTable", "頻道篩選表");
            zhTw.Add("Debug", "偵錯");
            zhTw.Add("Urgent", "緊急");
            zhTw.Add("Notice", "通知");
            zhTw.Add("Say", "說話");
            zhTw.Add("Shout", "喊話");
            zhTw.Add("TellOutgoing", "傳出密語");
            zhTw.Add("TellIncoming", "收到密語");
            zhTw.Add("Party", "小隊");
            zhTw.Add("Alliance", "團隊");
            zhTw.Add("FreeCompany", "公會");
            zhTw.Add("Free", "自由頻道");
            zhTw.Add("Ls1", "通訊貝 1");
            zhTw.Add("Ls2", "通訊貝 2");
            zhTw.Add("Ls3", "通訊貝 3");
            zhTw.Add("Ls4", "通訊貝 4");
            zhTw.Add("Ls5", "通訊貝 5");
            zhTw.Add("Ls6", "通訊貝 6");
            zhTw.Add("Ls7", "通訊貝 7");
            zhTw.Add("Ls8", "通訊貝 8");
            zhTw.Add("Yell", "呼喊");
            zhTw.Add("CrossParty", "跨界小隊");
            zhTw.Add("PvPTeam", "PvP 隊伍");
            zhTw.Add("NoviceNetwork", "新手頻道");
            zhTw.Add("CrossLinkShell1", "跨界通訊貝 1");
            zhTw.Add("CrossLinkShell2", "跨界通訊貝 2");
            zhTw.Add("CrossLinkShell3", "跨界通訊貝 3");
            zhTw.Add("CrossLinkShell4", "跨界通訊貝 4");
            zhTw.Add("CrossLinkShell5", "跨界通訊貝 5");
            zhTw.Add("CrossLinkShell6", "跨界通訊貝 6");
            zhTw.Add("CrossLinkShell7", "跨界通訊貝 7");
            zhTw.Add("CrossLinkShell8", "跨界通訊貝 8");
            zhTw.Add("Echo", "默語");
            zhTw.Add("Automatically record messages with maplink and retrieve later.", "自動記錄聊天訊息中的地圖連結，方便稍後查看。");
            zhTw.Add("Add an option to call /tp to teleport to the nearest aetheryte.\nMake sure you have downloaded Teleporter Plugin.", "呼叫 /tp 傳送至距離地圖連結最近的傳送網。\n請確認已安裝並啟用 Teleporter 插件。");
            zhTw.Add("Maplinks", "地圖連結");
            zhTw.Add("Sender", "傳送者");
            zhTw.Add("Timeout", "判重時間（分鐘）");
            zhTw.Add("Maplink within timeout will be filtered by it's maplink instead of full text.", "在判重時間內，相同座標的地圖連結將視為重複訊息。");
            zhTw.Add("Bring front", "收到新連結時切回遊戲");
            zhTw.Add("Bring the game to front with new maplink", "收到新的地圖連結時，將遊戲視窗移至最前方。");
            zhTw.Add("Message Wrap", "訊息自動換行");
            zhTw.Add("Line Wrap for message column.", "讓訊息欄位中的文字自動換行。");
            zhTw.Add("Combat Hide", "戰鬥中隱藏");
            zhTw.Add("Hide during combat.", "進入戰鬥時隱藏 MapLinker 視窗。");
            zhTw.Add("Combat Click Thru", "戰鬥中允許點擊穿透");
            zhTw.Add("Click through during combat.", "戰鬥中不攔截滑鼠點擊。");
            zhTw.Add("Combat Opacity", "戰鬥中透明度");
            zhTw.Add("Opacity during combat.", "設定戰鬥時視窗的透明度。");
            zhTw.Add("Change the UI Language.", "變更插件介面語言。");
            zhTw.Add("Message", "訊息");
            zhTw.Add("Time", "時間");
            zhTw.Add("Retrieve", "查看");
            zhTw.Add("Teleport", "傳送");
            zhTw.Add("Delete", "刪除");
            zhTw.Add("View", "查看");
            zhTw.Add("Tele", "傳送");
            zhTw.Add("Del", "刪除");
            zhTw.Add("Export", "複製全部");
            zhTw.Add("Clear", "清除");
            zhTw.Add("Max Records", "最多保留筆數");
            zhTw.Add("Target", "加入目前目標");
        }
    }
}
