public class DevRepo
{
    // List of developers
    private readonly List<Dev> _devs;

    // CRUD methods to access developers
    
    public List<Dev> GetAllDevs()
    {
        return _devs;
    }


    // Add a dev
    // Remove a dev (find teams they belong to - remove from teams!)

    public void Seed()
    {
        Dev dev = new Dev();
        dev.Email = "someone@email.com";
        dev.Name = "someone";
        _devs.Add(dev);

        Dev deb = new Dev();
        deb.Email = "deb@company.com";
        deb.Name = "Deb";
        _devs.Add(deb);
    }
}