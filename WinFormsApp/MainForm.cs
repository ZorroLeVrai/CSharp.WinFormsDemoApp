using MyLibrary;
using System.Text.Json;

namespace WinFormsApp;

public partial class MainForm : Form
{
    private const int DEFAULT_PORT = 7233;
    private CancellationTokenSource? cancellationTokenSource;

    public MainForm()
    {
        InitializeComponent();
    }

    private async void Form1_Load(object sender, EventArgs e)
    {
        var optionLoader = new OptionLoader("Option", 10, 6000);
        var optionData = await optionLoader.GetOptionsAsync();
        option1ComboBox.DataSource = optionData.ToList();
        option1ComboBox.Enabled = true;
    }

    /// <summary>
    /// Handles the click event for the action button.
    /// This method handles a cancellation token to allow the user to cancel the operation if needed.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void ActionButton_Click(object sender, EventArgs e)
    {
        actionButton.Enabled = false;
        option2ComboBox.Enabled = false;
        cancelButton.Enabled = true;

        var optionLoader = new OptionLoader("User", 8, 6000);
        cancellationTokenSource = new CancellationTokenSource();

        try
        {
            var optionData = await optionLoader.GetOptionsAsync(cancellationTokenSource.Token);
            option2ComboBox.DataSource = optionData.ToList();
            option2ComboBox.Enabled = true;
        }
        catch (OperationCanceledException)
        {
            MessageBox.Show("Operation was cancelled.");
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred: {ex.Message}");
        }
        finally
        {
            actionButton.Enabled = true;
            cancelButton.Enabled = false;
            cancellationTokenSource.Dispose();
            cancellationTokenSource = null;
        }
    }

    private async void Button1_Click(object sender, EventArgs e)
    {
        serverButton.Enabled = false;
        serverComboBox.Enabled = false;

        using (HttpClient client = new())
        {
            client.BaseAddress = new Uri($"https://localhost:{DEFAULT_PORT}/api/Option/3");
            var response = await client.GetAsync("");
            if (response.IsSuccessStatusCode)
            {
                string jsonString = await response.Content.ReadAsStringAsync();
                // Deserialize the JSON string into a list of strings
                var voitureList = JsonSerializer.Deserialize<List<string>>(jsonString);
                serverComboBox.DataSource = voitureList;

                serverButton.Enabled = true;
                serverComboBox.Enabled = true;
            }
            else
            {
                MessageBox.Show("Erreur lors de la récupération des données du serveur.");
            }
        }
    }

    private void CancelButton_Click(object sender, EventArgs e)
    {
        cancellationTokenSource?.Cancel();
    }
}
