using DP_Factory_Method.Models.Abstract;
using DP_Factory_Method.Models.Creator;
using DP_Factory_Method.Models.Enums;
using System;

namespace DP_Factory_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            //Factory Method tasarım kalıbı , kalıtımsal ilişkileri olan nesnelerin üretilmesi amacıyla kullanılan patternlerden birisidir.
            //Burada asıl olan bir metottur. Bu metodun üstlendiği iş ise istemcinin ihtiyacı olan asıl ürünlerin üretilmesini sağlamak.
            //Fabrika metodunun özelliği istemciden gelen talebe göre uygun olan ürünün üretilip istemciye verilmesidir.
            //Tek bir sınıf ve metodun bunu üstlenebilmesi için polimorfik özelliği olan bir tipe ihtiyacımız var.
            //Yani bir parent class ve bu parent classtan türeyen subclasslar.Bu yüzden productların interface olarak bir atası tasarlanır.
            //Yani bizim creatorClassımız bir productu yani IProduct’ın taşıyabilceği türden bir referansı geriye döndürecektir.

            CreatorModel creator = new CreatorModel();

            Screen screenWindows = creator.ScreenFactory(ScreenModel.Windows);
            Screen screenWeb = creator.ScreenFactory(ScreenModel.Web);
            Screen screenMobile = creator.ScreenFactory(ScreenModel.Mobile);

            screenWindows.Draw();
            screenWeb.Draw();
            screenMobile.Draw();

            Console.ReadKey();
        }
    }
}
