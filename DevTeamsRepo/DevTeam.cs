public class DevTeam
{
    // Team name, Members (list of devs), etc
    private readonly List<Dev> _members = new List<Dev>();
    // CRUD (access methods)
    public List<Dev> GetTeamMembers()
    {
        return _members;
    }
    // Add member
    // Remove member
    // Change name??
}