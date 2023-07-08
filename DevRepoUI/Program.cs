DevRepo repo = new();
DevTeamRepo teamRepo = new();

// Create a list of devs
repo.Seed();
// Add THOSE devs to teams
teamRepo.Seed(repo);

Console.WriteLine("What");

ProgramUI ui = new(repo, teamRepo);
ui.Run();