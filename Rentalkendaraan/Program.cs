List<Kendaraan> data_kendaraan = new List<Kendaraan>()
{
    new Kendaraan("vario","N 2234 B",12500),
    new Kendaraan("Aerox","N 4325 FG",100000 )

};




class Kendaraan
{
    protected string _namaKendaraan;
    protected double _hargaSewaPerhari;
    protected string _nomerpolisi;
    protected bool _IsAvailable;

    public Kendaraan(string namaKendaraan, string nomerpolisi, double hargaSewaPerhari)
    {
        _namaKendaraan = namaKendaraan;
        _hargaSewaPerhari = hargaSewaPerhari;
        _nomerpolisi = nomerpolisi;
        _IsAvailable = true;
    }
    public string namaKendaraan
    {
        get { return _namaKendaraan; }
        set { _namaKendaraan = value; }
    }

    public double HargaSewa
    {
        get { return _hargaSewaPerhari; }
        set
        {
            if (value > 0)
            {
                _hargaSewaPerhari += value;
            }
            else
            {
                Console.WriteLine("Harga sewa harus lebih dari 0!");
            }
        }
    }

    public string NomerPolisi
    {
        get { return _nomerpolisi; }
    }

    public bool isAvailable
    {
        get { return _IsAvailable; }
    }

    public void tampilkanInfo()
    {
        Console.WriteLine($"Nama Kendaraan: {_namaKendaraan}");
        Console.WriteLine($"Harga Sewa Per Hari: {_hargaSewaPerhari}");
        Console.WriteLine($"Nomer Polisi: {_nomerpolisi}");
        Console.WriteLine($"Ketersediaan: {(_IsAvailable ? "Tersedia" : "Tidak Tersedia")}");
    }
    public void UbahStatus()
    {
        _IsAvailable = !_IsAvailable;
    }

    public virtual double HitungTotal(int jumlahHari)
    {
        return _hargaSewaPerhari * jumlahHari;
    }

}

class Mobil : Kendaraan
{

    private double _biayaAnsuransi;
    public Mobil(string nama_kendaraan, string nomer_polisi, double hargaSewaPerhari)
        : base(nama_kendaraan, nomer_polisi, hargaSewaPerhari)
    {
        _biayaAnsuransi = 50000;
    }
    public override double HitungTotal(int jumlahHari)
    {
        return base.HitungTotal(jumlahHari) + _biayaAnsuransi;

    }

}
class MiniBus : Kendaraan
{
    private double _biayaSopir;
    public MiniBus(string nama_Kendaraan, string nomer_polisi, double hargaSewaPerhari)
        : base(nama_Kendaraan, nomer_polisi, hargaSewaPerhari)
    {
        _biayaSopir = 100000;
    }
    public override double HitungTotal(int jumlahHari)
    {
        return base.HitungTotal(jumlahHari) + _biayaSopir * jumlahHari;
    }
}