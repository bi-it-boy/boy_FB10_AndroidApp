namespace MoodTracker;

public partial class RatingPage : ContentPage
{
    private Course selectedCourse;

    private int selectedRating = 0;

    public RatingPage(Course course)
    {

        InitializeComponent();

        selectedCourse = course;

        CourseNameLabel.Text = selectedCourse.Name;
    }

    private void OnRatingClicked(object sender, EventArgs e)
    {
        Button clickedButton = (Button)sender;
        selectedRating = int.Parse(clickedButton.Text);

        foreach (var child in RatingButtonGrid.Children)
        {
            if (child is Button ratingButton)
            {
                ratingButton.BackgroundColor = Colors.LightGray;
                ratingButton.TextColor = Colors.Black;
            }
        }

        clickedButton.BackgroundColor = Color.FromArgb("#512BD4");
        clickedButton.TextColor = Colors.White;
    }

    private async void OnSaveClicked(object sender, EventArgs e)
    {
        if (selectedRating == 0)
        {
            await DisplayAlertAsync(
                "Keine Bewertung",
                "Bitte wähle zuerst eine Bewertung aus.",
                "OK"
                );
            return;
        }

        selectedCourse.Rating = selectedRating;
        selectedCourse.RatingTimestamp = DateTime.Now;

        await DisplayAlertAsync(
            "Gespeichert",
            "Deine Bewertung wurde gespeichert.",
            "OK"
        );

        await Navigation.PopAsync();

    }

}