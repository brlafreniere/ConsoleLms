namespace ConsoleLms;

public class MenuLevel
{
  private MenuItem[] menuItems;
  private MenuItem? currentMenuItem;
  public MenuLevel(MenuItem[] menuItems)
  {
    this.menuItems = menuItems;
  }
  public void Display()
  {
    Console.Clear();

    if (currentMenuItem != null)
    {
      currentMenuItem.DisplayOrExecute();
    }
    else
    {
      int i = 0;
      foreach (MenuItem menuItem in this.menuItems)
      {
        Console.Write((i+1).ToString() + ") ");
        Console.WriteLine(menuItem.ToString());
        i++;
      }
    }

  }

  public void PromptUserForSelection()
  {
    Console.WriteLine("Select an option: ");
    string inputValue = Console.ReadLine();
    int selectedOption = Convert.ToInt32(inputValue)-1;
    this.SelectOption(selectedOption);
  }
  public void SelectOption(int selectedOption)
  {
    this.currentMenuItem = this.menuItems[selectedOption];
    this.currentMenuItem.DisplayOrExecute();
  }
}
