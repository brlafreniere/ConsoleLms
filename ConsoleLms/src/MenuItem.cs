using System.Runtime.CompilerServices;

namespace ConsoleLms;

public class MenuItem
{
  private MenuLevel? submenu;
  private string name;
  private Action? callback;
  public MenuItem(string name, MenuLevel? submenu, Action? callback)
  {
    this.name = name;
    this.submenu =  submenu;
    this.callback = callback;
  }
  public override string ToString()
  {
    return this.name;
  }
  public void DisplayOrExecute()
  {
    if (this.submenu != null)
    {
      this.submenu.Display();
      this.submenu.PromptUserForSelection();
    }
    this.callback?.Invoke();
  }
}
