using Newtonsoft.Json;
using ZipExtractor;

string settingsPath = "settings.json";
string output = string.Empty;

Settings settings = new Settings();
Settings deserializedData = new Settings();

//Creates a new settings.json file with default values in case settings.json does not exist.
if (!File.Exists(settingsPath))
{
    settings.FileName = "folder name after extracting";
    settings.FilePath = "exact path to the file";
    settings.FileExtension = ".zip";

    output = JsonConvert.SerializeObject(settings);
}

deserializedData = JsonConvert.DeserializeObject<Settings>(output);