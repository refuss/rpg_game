using System;
using System.Collections.Generic;
using System.Text;

namespace rpg_game
{
    public class ActionMenuService
    {
        private List<ActionMenu> actionsMenu;

        public void AddAnAction(int id, string name, string menuName )
        {
            ActionMenu actionMenu = new ActionMenu() { Id = id, Name = name, MenuName = menuName };
            actionsMenu.Add(actionMenu);
        }

        public List<ActionMenu> GetMenuActionsByMenuName(string menuName)
        {
            List<ActionMenu> result = new List<ActionMenu>();
            foreach (var menuAction in actionsMenu)
            {
                if (menuAction.MenuName == menuName)
                {
                    result.Add(menuAction);
                }
            }
            return result;
        }

    }
}
