public class DevRepo
{
    // List of developers
    private readonly List<Dev> _devs = new List<Dev>();

    // CRUD methods to access developers
    public List<Dev> GetAllDevs()
    {
        return _devs;
    }

    public Dev? GetDev(int id) {
        foreach (Dev dev in _devs) {
            if (dev.Id == id) return dev;
        }
        return default;

        // return _devs.FirstOrDefault(d => d.Id == id);
    }
    public Dev? GetDev(string email) {
        return _devs.FirstOrDefault(d => d.Email == email);
    }
    // Method with the same name (but different parameters) is an overload
    // The method is overloaded if there are more than 1 version

    // Add a dev
    public bool AddDev(Dev dev) {
        if (string.IsNullOrEmpty(dev.Email))
            return false;

        _devs.Add(dev);
        return true;
    }
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
        deb.HasPluralSight = true;
        _devs.Add(deb);

        Dev roy = new Dev();
        roy.Email = "roy@company.com";
        roy.Name = "Roy";
        roy.HasPluralSight = true;
        _devs.Add(roy);

        Dev david = new Dev();
        david.Email = "dh@company.com";
        david.Name = "David";
        _devs.Add(david);
    }
}