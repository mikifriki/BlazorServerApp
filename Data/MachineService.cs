namespace BlazorServerApp.Data;

public class MachineService
{
    public Task<string[]> GetMachines()
    {
        string[] json = File.ReadAllText("wwwroot/data/machines.txt").Split(
            new string[] { Environment.NewLine },
            StringSplitOptions.None
        );
        return Task.FromResult(json);
    }
}
