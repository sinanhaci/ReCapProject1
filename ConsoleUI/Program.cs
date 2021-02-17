using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            //AddCar();
            //AddColor();
            //AddBrand();
            //ListCar();
            //ListBrand();
            //ListColor();
            //DeleteCar();
            //DeleteColor();
            //DeleteBrand();
            //GetCarDetailsTest();



        }

        private static void GetCarDetailsTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var carList in carManager.GetCarDetails())
            {
                Console.WriteLine(carList.Id + "\t" + carList.CarName + "\t" + carList.Brands + "\t" + carList.ColorName + "\t" + carList.DailyPrice);
            }
        }

        private static void ListColor()
        {
            int colorIslem, colorSecim;
            Console.WriteLine("1-)Tüm Renkleri listele");
            Console.WriteLine("2-)ColodId'ye göre renkleri listele");
            colorIslem = Convert.ToInt32(Console.ReadLine());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            if (colorIslem == 1)
            {
                foreach (var color in colorManager.GetAll())
                {
                    Console.WriteLine(color.ColorName);
                }
            }
            else if (colorIslem == 2)
            {
                Console.WriteLine("Lütfen listelemek istediğiniz renk Id'sini giriniz.");
                colorSecim = Convert.ToInt32(Console.ReadLine());
                foreach (var color1 in colorManager.GetAllByColorId(colorSecim))
                {
                    Console.WriteLine(color1.ColorName);
                }
            }
            else
            {
                Console.WriteLine("Lütfen seçiminizi kontrol ediniz.");
            }
        }

        private static void ListCar()
        {
            int carIslem, carSecim;
            Console.WriteLine("1-)Tüm araçları listele");
            Console.WriteLine("2-)BrandsId'ye göre araçları listele");
            carIslem = Convert.ToInt32(Console.ReadLine());
            CarManager carManager = new CarManager(new EfCarDal());
            if (carIslem == 1)
            {
                foreach (var car in carManager.GetAll())
                {
                    Console.WriteLine(car.Id);
                }
            }
            else if (carIslem == 2)
            {
                Console.WriteLine("Lütfen listelemek istediğiniz araç Id'sini giriniz.");
                carSecim = Convert.ToInt32(Console.ReadLine());
                foreach (var car1 in carManager.GetCarsByBrandId(carSecim))
                {
                    Console.WriteLine(car1.Description);
                }
            }
            else
            {
                Console.WriteLine("Lütfen seçiminizi kontrol ediniz.");
            }
        }

        private static void ListBrand()
        {
            int brandIslem, brandSecim;
            Console.WriteLine("1-)Tüm Markaları listele");
            Console.WriteLine("2-)BrandsId'ye göre Markaları listele");
            brandIslem = Convert.ToInt32(Console.ReadLine());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            if (brandIslem == 1)
            {
                foreach (var marka in brandManager.GetAll())
                {
                    Console.WriteLine(marka.BrandName);
                }
            }
            else if (brandIslem==2)
            {
                Console.WriteLine("Lütfen listelemek istediğiniz Marka Id'sini giriniz.");
                brandSecim = Convert.ToInt32(Console.ReadLine());
                foreach (var marka1 in brandManager.GetCarsByBrandId(brandSecim))
                {
                    Console.WriteLine(marka1.BrandName);
                }
            }
            else
            {
                Console.WriteLine("Lütfen seçiminizi kontrol ediniz.");
            }

        }

        private static void DeleteBrand()
        {
            int deleteBrand;
            Console.WriteLine("Lütfen sistemden silmek istediğiniz Markanın Id numarasını giriniz:");
            deleteBrand = Convert.ToInt32(Console.ReadLine());
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            foreach (var marka in brandManager.GetCarsByBrandId(deleteBrand))
            {
                brandManager.Delete(marka);
                Console.WriteLine("Seçtiğiniz Araç Başarılı Bir şekilde silindi.");
            }
        }

        private static void DeleteColor()
        {
            int deleteColor;
            Console.WriteLine("Lütfen sistemden silmek istediğiniz Rengin Id numarasını giriniz:");
            deleteColor = Convert.ToInt32(Console.ReadLine());
            ColorManager colorManager = new ColorManager(new EfColorDal());

            foreach (var renk in colorManager.GetAllByColorId(deleteColor))
            {
                colorManager.Delete(renk);
                Console.WriteLine("Seçtiğiniz Araç Başarılı Bir şekilde silindi.");
            }
        }

        private static void DeleteCar()
        {
            int deleteCar;
            Console.WriteLine("Lütfen sistemden silmek istediğiniz aracın Id numarasını giriniz:");
            deleteCar = Convert.ToInt32(Console.ReadLine());
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var marka in carManager.GetCarsId(deleteCar))
            {
                carManager.Delete(marka);
                Console.WriteLine("Seçtiğiniz Araç Başarılı Bir şekilde silindi.");
            }
        }

        private static void AddBrand()
        {
            Console.WriteLine("Sırasıyla eklenecek Marka Bilgilerini giriniz: BrandId-Brands");
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Brand brand1 = new Brand()

            {

                BrandId = Convert.ToInt32(Console.ReadLine()),
                BrandName = Convert.ToString(Console.ReadLine()),

            };
            brandManager.Add(brand1);
            Console.WriteLine("Girdiğiniz Marka Bilgileri Sisteme Kaydedildi.");
        }

        private static void AddColor()
        {
            Console.WriteLine("Sırasıyla eklenecek Renk Bilgilerini giriniz: ColorId-ColorName");
            ColorManager colorManager = new ColorManager(new EfColorDal());
            Color color11 = new Color()

            {

                ColorId = Convert.ToInt32(Console.ReadLine()),
                ColorName = Convert.ToString(Console.ReadLine()),

            };
            colorManager.Add(color11);
            Console.WriteLine("Girdiğiniz Renk Bilgileri Sisteme Kaydedildi.");
        }

        private static void AddCar()
        {
            Console.WriteLine("Sırasıyla eklenecek araç bilgilerini giriniz: ID-BrandId-ColorId-DailyPrice-Description-ModelYear");
            CarManager carManager = new CarManager(new EfCarDal());
            Car car1 = new Car()

            {

                Id = Convert.ToInt32(Console.ReadLine()),
                BrandId = Convert.ToInt32(Console.ReadLine()),
                ColorId = Convert.ToInt32(Console.ReadLine()),
                DailyPrice = Convert.ToInt32(Console.ReadLine()),
                Description = Convert.ToString(Console.ReadLine()),
                ModelYear = Convert.ToInt32(Console.ReadLine())
            };
            carManager.Add(car1);
            Console.WriteLine("Girdiğiniz Araç Sisteme Kaydedildi.");
        }

    }
}
