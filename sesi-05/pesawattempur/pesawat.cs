using System;


    public class pesawat{
        public string Nama, Ketinggian, JumlahPenumpang;
        public int JumlahRoda;
        public void terbang(){
                Console.WriteLine("Pesawat Tempur dengan nama {0}\n"+
                                    "yang mempunyai jumlah roda {1}\n"+
                                     "sedang berada pada ketinggian{2}\n"+ 
                                     "dengan membawa jumlah penumpang sebanyak{3}\n"+
                                     " Akan meledakan senjata",
                                      this.Nama, this.JumlahRoda, this.Ketinggian, this.JumlahPenumpang);
            }
    
    }
    class pesawat_tempur:pesawat{
            public void terbangtinggi(){
                Console.WriteLine("Pesawat Tempur dengan nama {0}\n"+
                                    "yang mempunyai jumlah roda {1}\n"+
                                     "sedang berada pada ketinggian{2}\n"+ 
                                     "dengan membawa jumlah penumpang sebanyak{3}\n"+
                                     " Akan meledakan senjata",
                                      this.Nama, this.JumlahRoda, this.Ketinggian, this.JumlahPenumpang);
            }
        }

