namespace Kolokwium_2_powtórzenie.Controllers.Model
{
    public class Zamówienie_WyrobCukierniczy
    {
        public int IdWyrobuCukierniczego { get; set; }
        public int IdZamowienia { get; set; }
        public int Ilosc { get; set; }
        public string Uwagi { get; set; }
    }
}