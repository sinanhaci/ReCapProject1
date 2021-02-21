using Business.Concrete;
using Business.Constants;
using Core.Utilities;
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
            //CarAdd();
            //ColorAdd();
            //BrandAdd();
            //CustomerAdd();
            //UserAdd();
            //CarDeleted();
            //ColorDeleted();
            //BrandDeleted();
            //CustomerDeleted();
            //UserDeleted();
            //CarUpdate();
            //ColorUpdate();
            //BrandUpdate();
            //CustomerUpdate();
            //UserUpdate();
            //CarDetailList();
            //BrandDetailList();
            //ColorDetailList();
            //CustomerDetailList();
            //UserDetailList();


            //BrandManager brandManager = new BrandManager(new EfBrandDal());
            CarManager carManager = new CarManager(new EfCarDal());
            //ColorManager colorManager = new ColorManager(new EfColorDal());
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            UserManager userManager = new UserManager(new EfUserDal());


            var result = rentalManager.GetAll();
            if (result.Success==true)
            {
                foreach (var rental in result.Data)
                {
                    
                        Console.WriteLine("Kiralanabilir Araba Listesi =" + rental.CarId + " " + rental.CustomerId);
                    
                }
            }
            
                //Rental rentalAdd = new Rental
                //{
                    
                //    CarId=rentCarId,
                //    CustomerId=rentCustomerId,
                //    RentDate=rentDate,
                //    ReturnDate=returnDate
                //};
                //rentalManager.Add(rentalAdd);
                //Console.WriteLine("Araç kiralama işlemi başarılı");
           




        }

        //private static void UserDetailList()
        //{
        //    UserManager userManager = new UserManager(new EfUserDal());
        //    int userIdList = 0, userListSecim = 0;
        //    Console.WriteLine("Lütfen listeleme şeklini seçiniz: \n 1-) Kullanıcıları listele \n 2-) User Id'ye göre listele");
        //    userListSecim = Convert.ToInt32(Console.ReadLine());
        //    if (userListSecim == 1)
        //    {
        //        var result = userManager.GetAll();
        //        if (result.Success == true)
        //        {
        //            foreach (var userListele in result.Data)
        //            {
        //                Console.WriteLine(userListele.Id + "-)" + userListele.FirstName + " " + userListele.LastName + " " + userListele.Email);
        //            }
        //            Console.WriteLine(Messages.UserListed);
        //        }
        //    }
        //    else if (userListSecim == 2)
        //    {
        //        Console.WriteLine("Lütfen listelemek istediğiniz kullanıcının Id'sini giriniz: ");
        //        userIdList = Convert.ToInt32(Console.ReadLine());
        //        var result = userManager.GetById(userIdList);
        //        foreach (var userIdListele in result.Data)
        //        {
        //            Console.WriteLine(userIdListele.Id + "-)" + userIdListele.FirstName + " " + userIdListele.LastName + " " + userIdListele.Email);
        //        }
        //    }
        //}

        //private static void CustomerDetailList()
        //{
        //    CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
        //    int customerId = 0, customerListSecim = 0;
        //    Console.WriteLine("Lütfen listeleme şeklini seçiniz: \n 1-) Müşterileri listele \n 2-) CustomerId'ye göre listele");
        //    customerListSecim = Convert.ToInt32(Console.ReadLine());
        //    if (customerListSecim == 1)
        //    {
        //        var result = customerManager.GetAll();
        //        if (result.Success == true)
        //        {
        //            foreach (var customerListele in result.Data)
        //            {
        //                Console.WriteLine(customerListele.UserId + "-)" + customerListele.CompanyName);
        //            }
        //            Console.WriteLine(Messages.CustomerListed);
        //        }
        //    }
        //    else if (customerListSecim == 2)
        //    {
        //        Console.WriteLine("Lütfen listelemek istediğiniz müşterininin Id'sini giriniz.");
        //        customerId = Convert.ToInt32(Console.ReadLine());
        //        var result = customerManager.GetByUserId(customerId);
        //        foreach (var customerIdListele in result.Data)
        //        {
        //            Console.WriteLine(customerIdListele.UserId + "-)" + customerIdListele.CompanyName);
        //        }
        //        Console.WriteLine(Messages.CustomerListed);
        //    }
        //}

        //private static void ColorDetailList()
        //{
        //    ColorManager colorManager = new ColorManager(new EfColorDal());
        //    int colorIdList = 0, colorSecimList = 0;
        //    Console.WriteLine("Lütfen listeleme tipini seçiniz: \n 1-) Renkleri listele \n 2-) ColorId'ye göre listele");
        //    colorSecimList = Convert.ToInt32(Console.ReadLine());
        //    if (colorSecimList == 1)
        //    {
        //        var result = colorManager.GetAll();
        //        if (result.Success == true)
        //        {
        //            foreach (var colorListele in result.Data)
        //            {
        //                Console.WriteLine(colorListele.ColorId + "-)" + colorListele.ColorName);

        //            }
        //            Console.WriteLine(Messages.BrandListed);
        //        }


        //    }
        //    else if (colorSecimList == 2)
        //    {

        //        Console.WriteLine("Lütfen listelemek istediğiniz markanın id numarasını giriniz.");
        //        colorIdList = Convert.ToInt32(Console.ReadLine());
        //        var result = colorManager.GetAllByColorId(colorIdList);
        //        if (result.Success == true)
        //        {
        //            foreach (var colorIdListele in result.Data)
        //            {
        //                Console.WriteLine(colorIdListele.ColorId + "-)" + colorIdListele.ColorName);

        //            }
        //            Console.WriteLine(Messages.BrandListed);
        //        }
        //    }
        //}

        //private static void BrandDetailList()
        //{
        //    BrandManager brandManager = new BrandManager(new EfBrandDal());
        //    int brandIdList = 0, brandSecimList = 0;
        //    Console.WriteLine("Lütfen listeleme tipini seçiniz: \n 1-) Markaları listele \n 2-) BrandId'ye göre listele");
        //    brandSecimList = Convert.ToInt32(Console.ReadLine());
        //    if (brandSecimList == 1)
        //    {
        //        var result = brandManager.GetAll();
        //        if (result.Success == true)
        //        {
        //            foreach (var brandListele in result.Data)
        //            {
        //                Console.WriteLine(brandListele.BrandId + "-)" + brandListele.BrandName);

        //            }
        //            Console.WriteLine(Messages.BrandListed);
        //        }


        //    }
        //    else if (brandSecimList == 2)
        //    {

        //        Console.WriteLine("Lütfen listelemek istediğiniz markanın id numarasını giriniz.");
        //        brandIdList = Convert.ToInt32(Console.ReadLine());
        //        var result = brandManager.GetCarsByBrandId(brandIdList);
        //        if (result.Success == true)
        //        {
        //            foreach (var brandIdListele in result.Data)
        //            {
        //                Console.WriteLine(brandIdListele.BrandId + "-)" + brandIdListele.BrandName);

        //            }
        //            Console.WriteLine(Messages.BrandListed);
        //        }
        //    }
        //}

        //private static void CarDetailList()
        //{

        //    CarManager carManager = new CarManager(new EfCarDal());
        //    int carIdList = 0, carColorIdList = 0, carBrandIdList = 0, listSecim = 0;
        //    Console.WriteLine("Lütfen listeleme tipini seçiniz: \n 1-) Araba Detaylarını Listele \t \n 2-) Araba Id'sine göre listele \t \n 3-) Araba Renk Id'sine göre listele \t \n 4-) Araba marka Id'sine göre listele");
        //    listSecim = Convert.ToInt32(Console.ReadLine());
        //    if (listSecim==1)
        //    {
        //        var result = carManager.GetCarDetails();
        //        if (result.Success == true)
        //        {

        //            foreach (var carListele in result.Data)
        //            {
        //                Console.WriteLine(carListele.Id + "/" + carListele.CarName + "/" + carListele.Brands + "/" + carListele.ColorName + "/" + carListele.DailyPrice);

        //            }
        //            Console.WriteLine(Messages.CarListed);
        //        }
        //    }
        //    else if (listSecim ==2)
        //    {
        //        Console.WriteLine("Listelemek istediğiniz Id numarasını giriniz");
        //        carIdList = Convert.ToInt32(Console.ReadLine());
        //        var result = carManager.GetCarsId(carIdList);
        //        if (result.Success==true)
        //        {
        //            foreach (var carIdListele in result.Data)
        //            {
        //                Console.WriteLine(carIdListele .Id + "-)" + carIdListele.CarName +" " + carIdListele.Description + " " + carIdListele.DailyPrice);

        //            }
        //            Console.WriteLine(Messages.CarListed);

        //        }
        //    }
        //    else if (listSecim==3)
        //    {
        //        Console.WriteLine("Listelemek istediğiniz Id numarasını giriniz");
        //        carColorIdList = Convert.ToInt32(Console.ReadLine());
        //        var result = carManager.GetAllByColorId(carColorIdList);
        //        if (result.Success == true)
        //        {
        //            foreach (var carColorIdListele in result.Data)
        //            {
        //                Console.WriteLine(carColorIdListele.ColorId + "-)" + carColorIdListele.CarName + " " + carColorIdListele.Description + " " + carColorIdListele.DailyPrice);

        //            }
        //            Console.WriteLine(Messages.CarListed);
        //        }
        //    }
        //    else if (listSecim ==4)
        //    {
        //        Console.WriteLine("Listelemek istediğiniz Id numarasını giriniz");
        //        carBrandIdList = Convert.ToInt32(Console.ReadLine());
        //        var result = carManager.GetCarsByBrandId(carBrandIdList);
        //        if (result.Success == true)
        //        {
        //            foreach (var carBrandIdListele in result.Data)
        //            {
        //                Console.WriteLine(carBrandIdListele.BrandId+ "-)" + carBrandIdListele.CarName + " " + carBrandIdListele.Description + " " + carBrandIdListele.DailyPrice);

        //            }
        //            Console.WriteLine(Messages.CarListed);
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Lütfen seçiminizi kontrol ediniz.");
        //    }


        //}

        //private static void UserUpdate()
        //{
        //    UserManager userManager = new UserManager(new EfUserDal());
        //    int userId = 0;
        //    string firstName, lastName, eMail, Password;
        //    Console.WriteLine("Lütfen güncellemek istediğiniz kullanıcının Id numarasını giriniz");
        //    userId = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Lütfen kullanıcının yeni isim bilgisini giriniz:");
        //    firstName = Console.ReadLine();
        //    Console.WriteLine("Lütfen kullanıcının yeni soyisim bilgisini giriniz:");
        //    lastName = Console.ReadLine();
        //    Console.WriteLine("Lütfen kullanıcının yeni email bilgisini giriniz:");
        //    eMail = Console.ReadLine();
        //    Console.WriteLine("Lütfen kullanıcının yeni password bilgisini giriniz:");
        //    Password = Console.ReadLine();

        //    User userUpdate = new User { Id = userId, FirstName = firstName, LastName = lastName, Email = eMail, Password = Password };
        //    userManager.Update(userUpdate);
        //    Console.WriteLine(Messages.UserUpdate);
        //}

        //private static void CustomerUpdate()
        //{
        //    CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
        //    int userId = 0;
        //    string companyName;
        //    Console.WriteLine("Lütfen güncellemek istediğiniz müşterinin Id numarasını giriniz");
        //    userId = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Lütfen güncellemek istediğiniz müşterinin yeni ismini giriniz");
        //    companyName = Console.ReadLine();
        //    Customer customerUpdate = new Customer { UserId = userId, CompanyName = companyName };
        //    customerManager.Update(customerUpdate);
        //    Console.WriteLine(Messages.CustomerUpdate);
        //}

        //private static void BrandUpdate()
        //{
        //    BrandManager brandManager = new BrandManager(new EfBrandDal());
        //    int brandId = 0;
        //    string brandName;
        //    Console.WriteLine("Lütfen güncellemek istediğiniz markanın Id numarasını giriniz:");
        //    brandId = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Lütfen Markanın yeni ismini giriniz:");
        //    brandName = Console.ReadLine();
        //    Brand brandUpdate = new Brand { BrandId = brandId, BrandName = brandName };
        //    brandManager.Update(brandUpdate);
        //    Console.WriteLine(Messages.BrandUpdate);
        //}

        //private static void ColorUpdate()
        //{
        //    ColorManager colorManager = new ColorManager(new EfColorDal());
        //    string colorName;
        //    int colorId = 0;
        //    Console.WriteLine("Lütfen güncellemek istediğiniz rengin Id numarasını giriniz:");
        //    colorId = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Lütfen güncellemek istediğiniz rengin Adını giriniz");
        //    colorName = Console.ReadLine();
        //    Color colorUpdate = new Color { ColorId = colorId, ColorName = colorName };
        //    colorManager.Update(colorUpdate);
        //    Console.WriteLine(Messages.ColorUpdate);
        //}

        //private static void CarUpdate()
        //{
        //    CarManager carManager = new CarManager(new EfCarDal());
        //    int id = 0, brandId = 0, colorId = 0, modelYear = 0, dailyPrice = 0;
        //    string description, carName;

        //    Console.WriteLine("Lütfen güncellemek istediğiniz aracın Id numarasını giriniz:");
        //    id = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Lütfen yeni brandId numarasını giriniz:");
        //    brandId = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Lütfen yeni colorId numarasını giriniz:");
        //    colorId = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Lütfen yeni ModelYear bilgisini giriniz:");
        //    modelYear = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Lütfen yeni dailyPrice bilgisini giriniz:");
        //    dailyPrice = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Lütfen yeni Açıklama bilgisini giriniz:");
        //    description = Console.ReadLine();
        //    Console.WriteLine("Lütfen yeni Araç ismini bilgisini giriniz:");
        //    carName = Console.ReadLine();
        //    Car updateCar = new Car { Id = id, BrandId = brandId, ColorId = colorId, ModelYear = modelYear, DailyPrice = dailyPrice, Description = description, CarName = carName };
        //    carManager.Update(updateCar);
        //    Console.WriteLine(Messages.CarUpdate);
        //}

        //private static void UserDeleted()
        //{
        //    UserManager userManager = new UserManager(new EfUserDal());
        //    int userDelete = 0;
        //    Console.WriteLine("Lütfen silmek istediğiniz kullanıcının Id numarasını giriniz:");
        //    userDelete = Convert.ToInt32(Console.ReadLine());
        //    User userDeleted = new User { Id = userDelete };
        //    userManager.Delete(userDeleted);
        //    Console.WriteLine(Messages.UserDeleted);
        //}

        //private static void CustomerDeleted()
        //{
        //    CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
        //    int customerDelete = 0;
        //    Console.WriteLine("Lütfen silmek istediğiniz firmanın Id numarasını giriniz");
        //    customerDelete = Convert.ToInt32(Console.ReadLine());
        //    Customer customerDeleted = new Customer { UserId = customerDelete };
        //    customerManager.Delete(customerDeleted);
        //    Console.WriteLine(Messages.CustomerDeleted);
        //}

        //private static void BrandDeleted()
        //{
        //    BrandManager brandManager = new BrandManager(new EfBrandDal());
        //    int brandDelete = 0;
        //    Console.WriteLine("Lütfen silmek istediğiniz markanın Id numarasını giriniz");
        //    brandDelete = Convert.ToInt32(Console.ReadLine());
        //    Brand brandDeleted = new Brand { BrandId = brandDelete };
        //    brandManager.Delete(brandDeleted);
        //    Console.WriteLine(Messages.BrandDeleted);
        //}

        //private static void ColorDeleted()
        //{
        //    ColorManager colorManager = new ColorManager(new EfColorDal());
        //    int colorDeleted = 0;
        //    Console.WriteLine("Lütfen silmek istediğiniz rengin Id numarasını giriniz:");
        //    colorDeleted = Convert.ToInt32(Console.ReadLine());
        //    Color colorDelete = new Color { ColorId = colorDeleted };
        //    colorManager.Delete(colorDelete);
        //    Console.WriteLine(Messages.ColorDeleted);
        //}

        //private static void CarDeleted()
        //{
        //    CarManager carManager = new CarManager(new EfCarDal());
        //    int carDelete = 0;
        //    Console.WriteLine("Silmek istediğiniz aracın Id numarasını giriniz:");
        //    carDelete = Convert.ToInt32(Console.ReadLine());

        //    Car carDeleted = new Car { Id = carDelete };
        //    carManager.Delete(carDeleted);
        //    Console.WriteLine(Messages.CarDeleted);
        //}

        //private static void UserAdd()
        //{
        //    UserManager userManager = new UserManager(new EfUserDal());
        //    string firstName, lastName, eMail, password;
        //    Console.WriteLine("Lütfen eklemek istediğiniz kullanıcı bilgilerini giriniz");
        //    Console.WriteLine("İsim giriniz:");
        //    firstName = Console.ReadLine();
        //    Console.WriteLine("Soyisim giriniz:");
        //    lastName = Console.ReadLine();
        //    Console.WriteLine("Email adresini giriniz:");
        //    eMail = Console.ReadLine();
        //    Console.WriteLine("Şifre giriniz:");
        //    password = Console.ReadLine();
        //    User userAdd = new User
        //    {
        //        FirstName = firstName,
        //        LastName = lastName,
        //        Email = eMail,
        //        Password = password
        //    };
        //    userManager.Add(userAdd);
        //    Console.WriteLine(Messages.UserAdded);
        //}

        //private static void CustomerAdd()
        //{
        //    CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
        //    string companyName;
        //    Console.WriteLine("Eklemek istediğiniz müşteri bilgilerini giriniz:");
        //    Console.WriteLine("Şirket ismini giriniz");
        //    companyName = Console.ReadLine();
        //    Customer customerAdd = new Customer
        //    {
        //        CompanyName = companyName
        //    };
        //    customerManager.Add(customerAdd);
        //    Console.WriteLine(Messages.CustomerAdded);
        //}

        //private static void BrandAdd()
        //{
        //    BrandManager brandManager = new BrandManager(new EfBrandDal());
        //    string brandName;
        //    Console.WriteLine("Lütfen eklemek istediğiniz marka bilgilerini giriniz:");
        //    Console.WriteLine("Marka ismini giriniz");
        //    brandName = Console.ReadLine();
        //    Brand brandAdd = new Brand
        //    {
        //        BrandName = brandName
        //    };
        //    brandManager.Add(brandAdd);
        //    Console.WriteLine(Messages.BrandAdded);
        //}

        //private static void ColorAdd()
        //{
        //    ColorManager colorManager = new ColorManager(new EfColorDal());
        //    string colorName;
        //    Console.WriteLine("Lütfen girmek istediğiniz rengin bilgilerini giriniz:");
        //    Console.WriteLine("Renk ismini giriniz");
        //    colorName = Console.ReadLine();
        //    Color colorAdd = new Color
        //    {
        //        ColorName = colorName
        //    };
        //    colorManager.Add(colorAdd);
        //    Console.WriteLine(Messages.ColorAdded);
        //}

        //private static void CarAdd()
        //{
        //    CarManager carManager = new CarManager(new EfCarDal());
        //    int brandId = 0, colorId = 0, modelYear = 0, dailyPrice = 0;
        //    string descriptionCar, carName;
        //    Console.WriteLine("Eklemek istediğiniz araç bilgilerini giriniz:");
        //    Console.WriteLine("BrandId giriniz:");
        //    brandId = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("ColorId giriniz:");
        //    colorId = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("ModelYear giriniz:");
        //    modelYear = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("DailyPrice giriniz");
        //    dailyPrice = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Araç ismini giriniz");
        //    carName = Console.ReadLine();
        //    Console.WriteLine("Araç açıklamasını giriniz");
        //    descriptionCar = Console.ReadLine();
        //    Car addCar = new Car { BrandId = brandId, ColorId = colorId, ModelYear = modelYear, DailyPrice = dailyPrice, CarName = carName, Description = descriptionCar };
        //    carManager.Add(addCar);
        //    Console.WriteLine(Messages.CarAdded);
        //}
    }
    }
