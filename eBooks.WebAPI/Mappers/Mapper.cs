using AutoMapper;

namespace eBooks.WebAPI.Mappers
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Database.Kategorije, Model.Kategorije>().ReverseMap();
            CreateMap<Database.Uloge, Model.Uloge>();

            CreateMap<Database.Korisnici, Model.Korisnici>().ReverseMap();
            CreateMap<Database.Korisnici, Model.Requests.KorisniciUpsertRequest>().ReverseMap();

            CreateMap<Database.Drzave, Model.Drzave>();
            CreateMap<Database.Gradovi, Model.Gradovi>();

            CreateMap<Database.Autori, Model.Autori>().ReverseMap();
            CreateMap<Database.Autori, Model.Requests.AutoriUpsertRequest>().ReverseMap();


            CreateMap<Database.Kupci, Model.Kupci>().ReverseMap();

            CreateMap<Database.Kupci, Model.Requests.KupciUpsertRequest>().ReverseMap();

            CreateMap<Database.Izdavaci, Model.Izdavaci>().ReverseMap();
            CreateMap<Database.Izdavaci, Model.Requests.IzdavaciUpsertRequest>().ReverseMap();

            CreateMap<Database.Kolekcije, Model.Kolekcije>().ReverseMap();
            CreateMap<Database.Kolekcije, Model.Requests.KolekcijeUpsertRequest>().ReverseMap();

            CreateMap<Database.Ocjene, Model.Ocjene>().ReverseMap();
            CreateMap<Database.Ocjene, Model.Requests.OcjeneUpsertRequest>().ReverseMap();

            CreateMap<Database.Ugovori, Model.Ugovori>().ReverseMap();
            CreateMap<Database.Ugovori, Model.Requests.UgovoriUpsertRequest>().ReverseMap();

            CreateMap<Database.AutoriKnjige, Model.AutoriKnjige>().ReverseMap();

            CreateMap<Database.KnjigeKategorije, Model.KnjigeKategorije>().ReverseMap();

            CreateMap<Database.Knjige, Model.Knjige>().ReverseMap();
            CreateMap<Database.Knjige, Model.Requests.KnjigeUpsertRequest>().ReverseMap();

            CreateMap<Database.Narudzbe, Model.Narudzbe>().ReverseMap();
            CreateMap<Database.Narudzbe, Model.Requests.NarudzbeUpsertRequest>().ReverseMap();

            CreateMap<Database.NarudzbaStavke, Model.NarudzbaStavke>().ReverseMap();
            CreateMap<Database.NarudzbaStavke, Model.Requests.NarudzbeStavkeUpsertRequest>().ReverseMap();

            CreateMap<Database.Racuni, Model.Racuni>().ReverseMap();
            CreateMap<Database.Racuni, Model.Requests.RacuniUpsertRequest>().ReverseMap();

            CreateMap<Database.RacunStavke, Model.RacunStavke>().ReverseMap();
            CreateMap<Database.RacunStavke, Model.Requests.RacunStavkeUpsertRequest>().ReverseMap();
        }
    }
}
