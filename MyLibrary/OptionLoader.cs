namespace MyLibrary;

public class OptionLoader
{
    private string _prefix;
    private int _nbElement;
    private int _time;

    public OptionLoader(string prefix, int nbElement, int time)
    {
        _prefix = prefix;
        _nbElement = nbElement;
        _time = time;
    }

    public async Task<IEnumerable<string>> GetOptionsAsync()
    {
        var options = Enumerable.Range(1, _nbElement)
            .Select(i => $"{_prefix} {i}")
            .ToList();

        await Task.Delay(_time).ConfigureAwait(false);
        return options;
    }
}
