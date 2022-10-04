using System;

namespace ApartmentManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                showMainMenu();
                handleChoice(selectOption());
            }
        }

        public static void showMainMenu()
        {
            visualFormatting('-');
            String add = "[1] Adding a new resident";
            String remove = "[2] Remove a resident";
            String searchApartment = "[3] Search apartment by number";
            String searchResident = "[4] Search resident by name";
            String listApartments = "[5] Apartments list";
            String listResidents = "[6] Residents list";

            String options = $"Available Options:\n {add}\n {remove}\n {searchApartment}\n {searchResident}\n {listApartments}\n {listResidents}";
            Console.WriteLine(options);
            visualFormatting('-');
            Console.Write("Select an option:");
        }

        public static void showResidentsMenu()
        {
            visualFormatting('-');
            String option0 = "[0] BACK TO PREVIOUS MENU";
            String option1 = "[1] Adding a new resident";
            String option2 = "[2] Remove a resident";
            String option3 = "[3] Search apartment by number";
            String option4 = "[4] Search resident by name";

            String options = $"Available Options:\n {option0}\n {option1}\n {option2}\n {option3}\n {option4})"; 
            Console.WriteLine(options);
            visualFormatting('-');
            Console.Write("Select an option:");
        }

        public static int selectOption()
        {

            Scanner scanner = new Scanner(System.in);
            int option = scanner.nextInt();
            visualFormatting('^');
            System.out.println("SUCCESS: You selected Option " + option);
            visualFormatting('^');

            return option;
        }

        public static void handleChoice(int selected)
        {
            switch (selected)
            {
                case 1:
                    Resident.addResident();
                    System.out.println("New resident successfully added");
                    System.out.println("You should Press [0] if you want to return to Main menu");
                    backToMain();
                    break;
                case 2:
                    if (Block.getTotalResidents() > 0)
                    {
                        Resident.removeResident();
                        System.out.println("One resident was removed from the Block");
                    }
                    else
                    {
                        System.out.println("Currently there are no residents in the Block");
                    }
                    System.out.println("You should Press [0] if you want to return to Main menu");
                    backToMain();
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    System.out.println("Number ot total residents is " + Resident.getTotalResidents());
                    showResidentsMenu();
                    backToMain();
                    break;
            }

        }

        public static void visualFormatting(char visualForm)
        {
            int dashes = 30;


            for (int i = 0; i < dashes; i++)
            {
                System.out.print(visualForm);
                if (i == dashes - 1)
                {
                    System.out.println();
                }
            }
        }

        public static void backToMain()
        {

            Scanner scanner1 = new Scanner(System.in);
            int choice = scanner1.nextInt();

            while (choice != 0)
            {
                System.out.println("You should Press [0] if you want to return to Main menu");
                choice = scanner1.nextInt();
            }
        }

        /*
        -   тоя selectOption също прави неща дето не са му работа
        -   във selectOption вкарай логиката по чентене на инпута там месиджа и връща избора
        -   тая част със суича в оделен метод handleChoice примерно
        -   а във backToMain освен принта на менюто слагаш и нов избор + handle
            така винаги ще се въртиш в кръг
        Grep Console:
            https://plugins.jetbrains.com/plugin/7125-grep-console
            https://stackoverflow.com/questions/46242330/clearing-console-in-intellij-idea?fbclid=IwAR1KiU3Z-31_NY8iJ8xDuR9Q4K3B3MScXtgFwBhIEF6FXARcj7S8s1cp9pg
         */
    }
}
}
