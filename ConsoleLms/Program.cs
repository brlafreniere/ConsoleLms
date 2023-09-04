
using ConsoleLms;

MenuItem[] accountMenuItems = new MenuItem[] {
  new MenuItem("Current Checkouts", null, () => { Console.WriteLine("No Checkouts."); })
};
MenuLevel accountMenu = new MenuLevel(accountMenuItems);

MenuItem[] catalogMenuItems = new MenuItem[] {
  new MenuItem("Search", null, () => { Console.WriteLine("Not Implemented."); })
};
MenuLevel catalogMenu = new MenuLevel(catalogMenuItems);

MenuItem[] rootMenuItems = new MenuItem[] {
  new MenuItem("Account", accountMenu, null),
  new MenuItem("Catalog", catalogMenu, null)
};
MenuLevel rootMenu = new MenuLevel(rootMenuItems);

rootMenu.Display();
rootMenu.PromptUserForSelection();