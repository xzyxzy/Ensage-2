using System;
using Ensage;

using Ensage.Common.Menu;
using Ensage.Common;


namespace Color_Chat
{
    internal class Program
    {
        private static readonly Menu Menu = new Menu("Color Chat", "chat", true);
        static string Command;
        static string modifier;
        public static Boolean team;
        enum color
        {
            Olive,
            Pink,
            Red,
            Orange,
            DarkYellow,
            LightGreen,
            Purple,
            Grey,
            Green,
            Blue,
            White,
            LimeGreen,
            HotPink,
            VibrantOrange,
            Violet,
            RedishPink
        }


        static void Main(string[] args)
        {
           
            Game.OnWndProc += Game_OnGameWndProc;
            var menu_utama = new Menu("Options", "opsi");
            menu_utama.AddItem(new MenuItem("Color", "Color").SetValue(new StringList(new[] { "Olive", "Pink", "Red","Orange","Dark Yellow","Light Green","Purple","Grey","Green","Blue","White","Lime Green","Hot Pink","Vibrant Orange","Violet","Redish Pink" })));
            Menu.AddSubMenu(menu_utama);
            Menu.AddToMainMenu();
            Game.PrintMessage("Colored Chat by <font color='#ff1111'>Spyware293</font> Loaded !!", MessageType.LogMessage);
           

        }
        public static void Game_OnGameWndProc(WndEventArgs args)
        {
            if (Game.IsChatOpen)
            {
                if (args.Msg == 0x0101 && args.WParam == 0x0D)
                {

                    if (Game.IsKeyDown(0x10)) team = false;
                    else team = true;
                }
                    if (Menu.Item("Color").GetValue<StringList>().SelectedIndex == (int)color.Olive)
                {
                    modifier = "10";
                }
                if (Menu.Item("Color").GetValue<StringList>().SelectedIndex == (int)color.Pink)
                {
                    modifier = "11";
                }
                if (Menu.Item("Color").GetValue<StringList>().SelectedIndex == (int)color.Red)
                {
                    modifier = "12";
                }
                if (Menu.Item("Color").GetValue<StringList>().SelectedIndex == (int)color.Orange)
                {
                    modifier = "13";
                }
                if (Menu.Item("Color").GetValue<StringList>().SelectedIndex == (int)color.DarkYellow)
                {
                    modifier = "14";
                }
                if (Menu.Item("Color").GetValue<StringList>().SelectedIndex == (int)color.LightGreen)
                {
                    modifier = "15";
                }
                if (Menu.Item("Color").GetValue<StringList>().SelectedIndex == (int)color.Purple)
                {
                    modifier = "16";
                }
                if (Menu.Item("Color").GetValue<StringList>().SelectedIndex == (int)color.Grey)
                {
                    modifier = "17";
                }
                if (Menu.Item("Color").GetValue<StringList>().SelectedIndex == (int)color.Green)
                {
                    modifier = "18";
                }
                if (Menu.Item("Color").GetValue<StringList>().SelectedIndex == (int)color.Blue)
                {
                    modifier = "19";
                }
                if (Menu.Item("Color").GetValue<StringList>().SelectedIndex == (int)color.White)
                {
                    modifier = "";
                }
                if (Menu.Item("Color").GetValue<StringList>().SelectedIndex == (int)color.LimeGreen)
                {
                    modifier = "0C";
                }
                if (Menu.Item("Color").GetValue<StringList>().SelectedIndex == (int)color.HotPink)
                {
                    modifier = "0E";
                }
                if (Menu.Item("Color").GetValue<StringList>().SelectedIndex == (int)color.VibrantOrange)
                {
                    modifier = "0F";
                }
                if (Menu.Item("Color").GetValue<StringList>().SelectedIndex == (int)color.Violet)
                {
                    modifier = "1A";
                }
                if (Menu.Item("Color").GetValue<StringList>().SelectedIndex == (int)color.RedishPink)
                {
                    modifier = "1C";
                }
                if (args.Msg == 256)
                {
                    if (args.WParam == 13)
                    {
                        
                        int hexnum = Int32.Parse(modifier, System.Globalization.NumberStyles.HexNumber);
                        string stringmodifier = Char.ConvertFromUtf32(hexnum);
                        if (Command =="")
                        {
                            return;
                        }
                        Game.ExecuteCommand(((team) ? "say_team " : "say ") + stringmodifier + Command);
                        Command = "";

                        return;
                    }
                    if (args.WParam == 8)
                    {
                        Command = Command.Substring(0, Command.Length - 1);
                        return;
                    }
                    if (args.WParam == 32)
                    {
                        Command += " ";
                        return;
                    }
                    if (args.WParam == 186)
                    {
                        if (Game.IsKeyDown(16))
                        {
                            Command += ":";
                            return;
                        }
                        else
                            Command += ";";
                        return;
                    }
                    if (args.WParam == 222)
                    {
                        if (Game.IsKeyDown(16))
                        {
                            Command += "\"";
                            return;
                        }
                        else
                            Command += "'";
                        return;
                    }
                    if (args.WParam == 191)
                    {
                        if (Game.IsKeyDown(16))
                        {
                            Command += "?";
                            return;
                        }
                        else
                            Command += "/";
                        return;
                    }
                    if (args.WParam == 190)
                    {
                        if (Game.IsKeyDown(16))
                        {
                            Command += ">";
                            return;
                        }
                        else
                            Command += ".";
                        return;
                    }
                    if (args.WParam == 188)
                    {
                        if (Game.IsKeyDown(16))
                        {
                            Command += "<";
                            return;
                        }
                        else
                            Command += ",";
                        return;
                    }
                    if (args.WParam == 49)
                    {
                        if (Game.IsKeyDown(16))
                        {
                            Command += "!";
                            return;
                        }
                        else
                            Command += "1";
                        return;
                    }
                    if (args.WParam == 50)
                    {
                        if (Game.IsKeyDown(16))
                        {
                            Command += "@";
                            return;
                        }
                        else
                            Command += "2";
                        return;
                    }
                    if (args.WParam == 51)
                    {
                        if (Game.IsKeyDown(16))
                        {
                            Command += "#";
                            return;
                        }
                        else
                            Command += "3";
                        return;
                    }
                    if (args.WParam == 52)
                    {
                        if (Game.IsKeyDown(16))
                        {
                            Command += "$";
                            return;
                        }
                        else
                            Command += "4";
                        return;
                    }
                    if (args.WParam == 53)
                    {
                        if (Game.IsKeyDown(16))
                        {
                            Command += "%";
                            return;
                        }
                        else
                            Command += "5";
                        return;
                    }
                    if (args.WParam == 54)
                    {
                        if (Game.IsKeyDown(16))
                        {
                            Command += "^";
                            return;
                        }
                        else
                            Command += "6";
                        return;
                    }
                    if (args.WParam == 55)
                    {
                        if (Game.IsKeyDown(16))
                        {
                            Command += "&";
                            return;
                        }
                        else
                            Command += "7";
                        return;
                    }
                    if (args.WParam == 56)
                    {
                        if (Game.IsKeyDown(16))
                        {
                            Command += "*";
                            return;
                        }
                        else
                            Command += "8";
                        return;
                    }
                    if (args.WParam == 57)
                    {
                        if (Game.IsKeyDown(16))
                        {
                            Command += "(";
                            return;
                        }
                        else
                            Command += "9";
                        return;
                    }
                    if (args.WParam == 48)
                    {
                        if (Game.IsKeyDown(16))
                        {
                            Command += ")";
                            return;
                        }
                        else
                            Command += "0";
                        return;
                    }
                    if (args.WParam == 189)
                    {
                        if (Game.IsKeyDown(16))
                        {
                            Command += "_";
                            return;
                        }
                        else
                            Command += "-";
                        return;
                    }
                    if (args.WParam == 187)
                    {
                        if (Game.IsKeyDown(16))
                        {
                            Command += "+";
                            return;
                        }
                        else
                            Command += "=";
                        return;
                    }
                    if (args.WParam == 192)
                    {
                        if (Game.IsKeyDown(16))
                        {
                            Command += "~";
                            return;
                        }
                        else
                            Command += "`";
                        return;
                    }

                    if (args.WParam == 45 || args.WParam == 46 || args.WParam == 19 || args.WParam == 36 || args.WParam == 35 || args.WParam == 34 || args.WParam == 33 || args.WParam == 93 || args.WParam == 91 || args.WParam == 17 || args.WParam == 9 || args.WParam == 16 || args.WParam == 112 || args.WParam == 113 || args.WParam == 114 || args.WParam == 115 || args.WParam == 116 || args.WParam == 117 || args.WParam == 118 || args.WParam == 119 || args.WParam == 120 || args.WParam == 121 || args.WParam == 122 || args.WParam == 123)
                    {
                        return;
                    }
                    if (args.WParam == 27)
                    {
                        Command = "";
                        return;
                    }

                    if (Game.IsKeyDown(16))
                    {
                        Command += Utils.KeyToText((uint)args.WParam).ToUpper();
                        
                        return;
                    }   
                    else
                        Command += Utils.KeyToText((uint)args.WParam).ToLower();
                    //Game.PrintMessage(args.WParam.ToString(),MessageType.LogMessage);

                        
                    return;


                }
            }
        }

      
    }
}

