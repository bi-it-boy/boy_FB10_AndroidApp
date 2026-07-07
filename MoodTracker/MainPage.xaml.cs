using System.Text.Json; //damit es JSON Datei lesen kann
using System.Text.Json.Serialization; // welches JSON-Fled zu welcher Eigenschaft gehört

namespace MoodTracker 
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();


            LoadCourses(); // Kurse aus der JSON-Datei laden
        }

        private async void LoadCourses() // async macht, dass ich await benutzen kann
        {
            // Datei laden
            using Stream stream = await FileSystem.Current.OpenAppPackageFileAsync("MoodTrackerDaten.json");

            //JSON-Inhalte in Objekte umwandeln
            CourseData? data = await JsonSerializer.DeserializeAsync<CourseData>(stream);

            // wenn Daten ausgelesen werden können, DANN übergeben wir an Liste
            if (data != null)
            {
                // CollectionView aus MainPage.xaml
                // ItemsSource bestimmt, welche Daten in der Liste angezeigt werden
                CourseCollectionView.ItemsSource = data.Courses;
            }
        }

        private async void OnRateClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Course course = (Course)button.BindingContext;

            await DisplayAlertAsync(
                "Bewerten",
                "Du möchtest diesen Kurs bewerten: " + course.Name,
                "OK"
                );
        }
    }

    public class CourseData
    {
        [JsonPropertyName("courses")]
        public List<Course> Courses { get; set; } = new List<Course>();
    }

    public class Course
    {
        [JsonPropertyName("name")]
        public string Name { get; set; } = "";

        [JsonPropertyName("description")]
        public string Description { get; set; } = "";

        [JsonPropertyName("location")]
        public string Location { get; set; } = "";

        [JsonPropertyName("date")]
        public string Date { get; set; } = "";

        [JsonPropertyName("time")]
        public string Time { get; set; } = "";

        public string DateAndTime
        {
            get
            {
                return Date + " · " + Time;
            }
        }
    }
}
