using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kelime_islem
{
    class sayim //static classların constructor türü olmaz yazıldığı zaman tüm voidlerin başına yazılır 
    {
        public sayim()//dönüştürücü yapı bellekte yer ayrılmasını ve ilk işlemlerin yapılmasını sağlar //constructor
        {

        }

        public int kac_harf(string metin) //dışardan çağırıp kullanılır private özeldir dışardan çağırılamaz
        {
            int say = 0;
            string kucuk = metin.ToLower(); //tolower küçük harfe çevirir
            for (int i = 0; i < metin.Length; i++) //metin.Length metinin uzunluğunu okur (dizisini)
                if (kucuk[i] >= 'a' && kucuk[i] <= 'z') // karakterler '' 
                    say++;

            return say;

        }
        public int kac_kelime(string metin) //bir işlem döndürmüyorsa void yazılır döndürüyor ise tipi yazılır
        {
            int say = 0;
            string kucuk = metin.ToLower(); //tolower küçük harfe çevirir
            for (int i = 0; i < metin.Length; i++) //metin.Length metinin uzunluğunu okur (dizisini)
                if (kucuk[i] == ' ' ||  kucuk[i] == '.' || kucuk[i]==',') // || veya demek
                    say++;

            return say;
        }
        public int kac_cumle(string metin)
        {
            int say = 0;
            string kucuk = metin.ToLower(); //tolower küçük harfe çevirir
            for (int i = 0; i < metin.Length; i++) //metin.Length metinin uzunluğunu okur (dizisini)
                if (kucuk[i] == '.' || kucuk[i] == '?' || kucuk[i] == '!') // || veya demek
                    say++;

            return say;
        }

    }
}
