public class ProgramUI
{
	private DevRepo _devRepo;
	private DevTeamRepo _teamRepo;

	public ProgramUI(DevRepo devRepo, DevTeamRepo teamRepo)
	{
		_devRepo = devRepo;
		_teamRepo = teamRepo;
	}

	public void Run()
	{
		// Seed???
		Menu();
	}
	private void Menu()
	{
		Console.Clear();
		Console.WriteLine("Menu!!!");
	}
	// etc...

	// Add a member to a team
	// Which dev would you like to add?
	// List 1. Joe 2. Jackson 3. Airy 4. Brock etc.
	// string choice = Console.ReadLine()
	// get the dev from the choice (switch?)
	// Which team would you like to add them to?
	// List 1. Team A \n2. Team B etc.
	// user selects
	// put dev on team, pause and continue
}
