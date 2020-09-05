using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace rpg_game
{
    public class CharacterService
    {
        //public List<Char> Characters { get; set; }
        //public CharService()
        //{
        //    Characters = new List<Char>();
        //}

        //adding new character
        public ActionMenuService actionService;

        public CharacterService(ActionMenuService actionService)
        {
            this.actionService = actionService;
        }
        public void AddNewCharacter()
        {

            var menuId;
            do
            {
                Console.Clear();
                var addNewItemMenu = actionService.GetMenuActionsByMenuName("charCreation");
                Console.WriteLine("Please choose from the following: ");
                for (int i = 0; i < addNewItemMenu.Count; i++)
                {
                    Console.WriteLine($"{addNewItemMenu[i].Id}. {addNewItemMenu[i].Name}");
                }
                ConsoleKey operation = Console.ReadKey(true).Key;
            } while (!(menuId == 49 || menuId == 50 || menuId == 51));
            if (menuId == 51) return;
            ProceedWithCharacterCreation(menuId);

        }

        private void ProceedWithCharacterCreation(int chosenAction)
        {
            if (chosenAction == 49)
            {
                TakeCharacterName();
            }
            else if (chosenAction == 50)
            {
                TakeCharacterVocation();
            }
        }
        private void TakeCharacterName()
        {
            bool IsOk;
            do
            {
                Console.Clear();
                Console.Write("Please enter your nickname: ");
                string nickname = Console.ReadLine();
                StringValidator myStrValidator = new StringValidator(3, 12);
                IsOk = myStrValidator.Validate(nickname);
            }
            while (!IsOk);
            AddNewCharacter();
        }
        private void TakeCharacterVocation()
        {
            Console.Clear();
            Console.WriteLine("Please choose your vocation: \r\n 1. Knight \r\n 2. Sorcerer \r\n 3. Assasin\r\n What is your choice? ");
            var operation = Console.ReadKey();
            switch (operation.KeyChar)
            {
                case '1':
                    Console.WriteLine("Across many years of hard training, you've grown up to become a brave warrior. " +
                        "Your weapon is a one-handed sword to slash enemies without problems and shield to protect yourself from harm." +
                        "You were born in the mountains where your mighty brother taught you how to fight, protect and survive in such dangerous place like Voltovia," +
                        " the mighty village.");
                    break;
                case '2':
                    Console.WriteLine("Throw many years of study in the Tower of Truth and Knowledge, you became a well-known Sorcerer." +
                        " You handle a good staff which can deal amazing magical damage to your enemies. You were living in a friendly but mostly unwelcome place far from people." +
                        " Now you grown up to go your own way.");
                    break;
                case '3':
                    Console.WriteLine("Across many years, since you were born, your place was a temple where you needed to learn and practice a lot of amazing things," +
                        " basically counting only on your speed and encouragement. Years of fighting with others helped you to turn yourself into a true assasin." +
                        " Your dagger is a light but dangerous weapon against your enemies.");
                    break;
                default:
                    Console.WriteLine("You didn't make a choice. Try again!");
                    break;
            }
            AddNewCharacter();
        }


        public string RemoveCharacter()
        {
            Console.WriteLine("Please enter the character's nickname which you want to remove: ");
            Console.WriteLine("List of characters: " + "character list");
            //list of characters
            string characterToRemove = Console.ReadLine();
            Console.WriteLine("Character succesfully removed!");
            return ;
        }

    }


}
