using System;
using System.Globalization;

namespace rpg_game
{
    class Program
    {
        static void Main(string[] args)
        {

            //1. Welcome the user
            //2. Menu actions:
            ////a. create character
            //// a1. name, vocation
            //// b. choose character
            //// c. remove character
            //// d. enter the game
            //3. The story
            //4. The game
            //5. If win/lose return the total result of the fight
            ActionMenuService actionService = new ActionMenuService();
            
            Console.WriteLine("Hello. Welcome to The Game...");
            Console.WriteLine("Please choose what do you want to do: ");
            //A method that initializes all the menu elements that will be created and used later
            actionService = Init(actionService);
            var mainMenu = actionService.GetMenuActionsByMenuName("Main");
            for (int i = 0; i < mainMenu.Count; i++)
            {
                Console.WriteLine($"{mainMenu[i].Id}. {mainMenu[i].Name}");
            }
            //when we want to choose the action we can use readkey which reads only 1 sign entered from the user.
            var operation = Console.ReadKey();
            CharacterService charCreation = new CharacterService(actionService);
            switch (operation.KeyChar)
            {
                case '1':
                     charCreation.AddNewCharacter();
                    break;
                case '2':
                    break;
                case '3':
                    string characterToRemove = CharacterService.RemoveCharacter();
                    break;
                case '4':
                    break;
                default:
                    Console.WriteLine("Chosen wrong action. Please try again!");
                    break;
            }



        }

        private static ActionMenuService Init(ActionMenuService actionService)
        {
            actionService.AddAnAction(1, "Create character", "Main");
            actionService.AddAnAction(2, "Choose character", "Main");
            actionService.AddAnAction(3, "Delete chracter", "Main");
            actionService.AddAnAction(4, "Enter the game", "Main");
            actionService.AddAnAction(1, "Choose a name", "charCreation");
            actionService.AddAnAction(2, "Choose a vocation", "charCreation");
            actionService.AddAnAction(3, "Back to main menu", "charCreation");
            return actionService;


            
        }
    }
}
