using Object_Oriented_Program_which_display_different_types_of_vehicles_brands;
class Program
{
    static void Main(string[] args)
    {
        Vehicle myvehicle = new Vehicle();
        Vehicle MyAudiA4 = new AudiA4();
        Vehicle myChevroletLacetti = new ChevroletLacetti();
        Vehicle myBMWSUV = new BMWSUV();
        Vehicle myMustangCalifornia = new MustangCalifornia();
        Vehicle myMk3POLOGTI = new Mk3POLOGTI();

        myvehicle.Vehiclebrand();
        MyAudiA4.Vehiclebrand();
        myChevroletLacetti.Vehiclebrand();
        myBMWSUV.Vehiclebrand();
        myMustangCalifornia.Vehiclebrand();
        myMk3POLOGTI.Vehiclebrand();

    }
}

