namespace Gun20BlazorOrnek1.Components.Pages
{
    public partial class About
    {
        string[]? arrCities;// = { "Antalya","Ankara","İzmir", "Muğla", "İstanbul", "Adana", "Konya","Balıkesir" };

        int? mesajSayisi;

        protected async override Task OnInitializedAsync()
        {
            await Task.Delay(3000);

            arrCities = new string[] { "Antalya", "Ankara", "İzmir", "Muğla", "İstanbul", "Adana", "Konya", "Balıkesir" };

            StateHasChanged();

            await Task.Delay(3000);

            mesajSayisi = 5;
        }
    }
}
