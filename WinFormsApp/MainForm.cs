using MyLibrary;
using System.Text.Json;

namespace WinFormsApp;

public partial class MainForm : Form
{
    private const int DEFAULT_PORT = 7233;

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

    private async void actionButton_Click(object sender, EventArgs e)
    {
        actionButton.Enabled = false;
        option2ComboBox.Enabled = false;

        var optionLoader = new OptionLoader("User", 8, 3000);
        var optionData = await optionLoader.GetOptionsAsync();
        option2ComboBox.DataSource = optionData.ToList();

        option2ComboBox.Enabled = true;
        actionButton.Enabled = true;
    }

    private async void button1_Click(object sender, EventArgs e)
    {
        serverButton.Enabled = false;
        serverComboBox.Enabled = false;

        using (HttpClient client = new ())
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
}
