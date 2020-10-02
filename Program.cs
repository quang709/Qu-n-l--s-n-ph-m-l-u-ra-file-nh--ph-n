using System;
using System.IO;
using System.Text;

namespace Quản_lý_sản_phẩm_lưu_ra_file_nhị_phân
{
    class Program
    {
        static void Main(string[] args)
        {
      
            Console.OutputEncoding = Encoding.UTF8;

            using ( StreamWriter streamWriter = new StreamWriter(@"C:\Users\admin\source\repos\Quản lý sản phẩm lưu ra file nhị phân\Quản lý sản phẩm lưu ra file nhị phân\sanpham.txt"))
            {
                Console.WriteLine("Mã sản phẩm: ");
                int msp = int.Parse(Console.ReadLine());
                streamWriter.WriteLine(msp);
                Console.WriteLine("Tên sản phẩm: ");
                string tsp = Console.ReadLine();
                streamWriter.WriteLine(tsp);
                Console.WriteLine("Hãng sản xuất: ");
                string hsx = Console.ReadLine();
                streamWriter.WriteLine(hsx);
                Console.WriteLine("Giá: ");
                int g = int.Parse(Console.ReadLine());
                streamWriter.WriteLine(g);
                Console.WriteLine("Các mô tả khác: ");
                string mtk = Console.ReadLine();
                streamWriter.WriteLine(mtk);
                streamWriter.Close();
            }
            using (StreamReader streamReader = new StreamReader(@"C:\Users\admin\source\repos\Quản lý sản phẩm lưu ra file nhị phân\Quản lý sản phẩm lưu ra file nhị phân\sanpham.txt"))
            {
                Console.WriteLine(streamReader.ReadToEnd());
                streamReader.Close();
            }
        }
    }
}
