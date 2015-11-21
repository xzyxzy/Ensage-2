using System;
using System.Linq;
using Ensage.Common;
using Ensage;
using Ensage.Common.Extensions;
using Ensage.Common.Menu;

namespace Silencer_Global_Disable
{
    internal class Program
    {
        private static Hero me;
        private static Item Refresher;
        private static readonly Menu Menu = new Menu("Global Silencer", "silencer", true);

        public static void Main(string[] args)
        {
            Game.OnUpdate += Game_OnUpdate;
            var mainmenu = new Menu("Options", "options");
            mainmenu.AddItem(new MenuItem("globaldisable", "Disable Enemy Ulti").SetValue(true));
            mainmenu.AddItem(new MenuItem("useref", "Use Refresher").SetValue(true));
            Menu.AddSubMenu(mainmenu);
            Menu.AddToMainMenu();
            Game.PrintMessage("Silencer Global Disable by <font color='#ff1111'>Spyware293</font> Loaded !!", MessageType.LogMessage);
        }
        private static void Game_OnUpdate(EventArgs args)
        {
            me = ObjectMgr.LocalHero;
            if (!Game.IsInGame || Game.IsPaused || Game.IsWatchingGame || me == null || me.ClassID != ClassID.CDOTA_Unit_Hero_Silencer)
                return;
            if (Refresher == null)
            {
                Refresher = me.FindItem("item_refresher");
            }
            if (Utils.SleepCheck("GlobalSave") && Menu.Item("globaldisable").GetValue<bool>() && me.Spellbook.Spell4.CanBeCasted() && me.Mana > me.Spellbook.Spell4.ManaCost)
            {
                var target = ObjectMgr.GetEntities<Hero>().Where(e => e.Team != me.Team && e.IsAlive && !e.IsIllusion);
                foreach (var v in target)
                {
                    var channel = v.GetChanneledAbility();
                    if (v.IsChanneling() && channel.Name != "item_travel_boots" && channel.Name != "item_travel_boots_2" && channel.Name != "lion_mana_drain" && channel.Name != "elder_titan_echo_stomp" && channel.Name != "elder_titan_echo_stomp_spirit" && channel.Name != "puck_phase_shift" && channel.Name != "pugna_life_drain" && channel.Name != "sandking_sand_storm" && channel.Name != "shadow_shaman_shackles" && channel.Name != "tinker_rearm" && channel.Name != "warlock_upheaval" && channel.Name != "enraged_wildkin_tornado" && channel.Name != "windrunner_powershot" && channel.Name != "oracle_fortunes_end" && channel.Name != "keeper_of_the_light_illuminate" && channel.Name != "keeper_of_the_light_illuminate_end" && channel.Name != "keeper_of_the_light_spirit_form_illuminate" && channel.Name != "keeper_of_the_light_spirit_form_illuminate_end")
                    {
                        me.Spellbook.Spell4.UseAbility();
                        Utils.Sleep(300, "GlobalSave");
                    }
                }
            }
            if (Utils.SleepCheck("RefreshGlobal") && Menu.Item("useref").GetValue<bool>() && Menu.Item("globaldisable").GetValue<bool>() && !me.Spellbook.Spell4.CanBeCasted() && Refresher.CanBeCasted() && me.Mana > me.Spellbook.Spell4.ManaCost + Refresher.ManaCost)
            {
                var target = ObjectMgr.GetEntities<Hero>().Where(e => e.Team != me.Team && e.IsAlive && !e.IsIllusion);
                foreach (var v in target)
                {
                    var channel = v.GetChanneledAbility();
                    if (v.IsChanneling() && channel.Name != "item_travel_boots" && channel.Name != "item_travel_boots_2" && channel.Name != "lion_mana_drain" && channel.Name != "elder_titan_echo_stomp" && channel.Name != "elder_titan_echo_stomp_spirit" && channel.Name != "puck_phase_shift" && channel.Name != "pugna_life_drain" && channel.Name != "sandking_sand_storm" && channel.Name != "shadow_shaman_shackles" && channel.Name != "tinker_rearm" && channel.Name != "warlock_upheaval" && channel.Name != "enraged_wildkin_tornado" && channel.Name != "windrunner_powershot" && channel.Name != "oracle_fortunes_end" && channel.Name != "keeper_of_the_light_illuminate" && channel.Name != "keeper_of_the_light_illuminate_end" && channel.Name != "keeper_of_the_light_spirit_form_illuminate" && channel.Name != "keeper_of_the_light_spirit_form_illuminate_end")
                    {
                        Refresher.UseAbility();
                        me.Spellbook.Spell4.UseAbility();
                        Utils.Sleep(300, "RefreshGlobal");
                    }
                }
            }

        }
    }
}
