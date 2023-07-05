DevRepo repo = new();
DevTeamRepo teamRepo = new();

repo.Seed();

Console.WriteLine("What");

ProgramUI ui = new(repo, teamRepo);
ui.Run();