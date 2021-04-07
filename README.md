# ReCapProject - Araç Kiralama Sistemi
![Araç Kiralama](https://image.freepik.com/free-vector/businessman-with-smartphone-rents-car-street-via-carsharing-service-carsharing-service-short-periods-rent-best-taxi-alternative-concept-bright-vibrant-violet-isolated-illustration_335657-903.jpg)
<br><br>
 Araç Kiralama Sistemi, (Nitelikli) Yazılım Geliştirici Yetiştirme Kampı'nda yapılan çalışmaları kapsayan bir projedir.
 <br><br>
Proje, back-end arayüzde sunucu tarafından gerçekleştirilen C# dilinde, katmanlı yazılım kurumsal mimari yapısı, SOLID yazılım prensipleri, Web API, EntityFrameWork yapısı ile geliştirilmiştir. JWT entegrasyonu; Transaction, Cache, Validation ve Performance aspectlerinin implementasyonları gerçekleştirilmiş olup Validation için FluentValidation desteği, IoC için Autofac desteği eklenmiştir.
 <br><br>
## :card_index_dividers: Layers
### :file_folder: Entities Layer
Projede kullanılacak veritabanı nesnelerini tutmak için oluşturulan katmandır.<br>
Üç alt klasörden oluşmaktadır. <br>
&nbsp;&nbsp;1.`Abstract` klasörü soyut nesneleri tutmak için (`Abstract` klasörü daha sonra geliştirilecek olan projeler içinde ortak kodlar içermesinden dolayı `Core` katmanına taşınmıştır.),<br>
&nbsp;&nbsp;2.`Concrete` klasörü somut nesneleri tutmak için <br>
&nbsp;&nbsp;3.`DTOs` klasörü nesnelere farklı özellikler vermek ve veritabanındaki tabloları birleştirmek için kullanılmıştır.
<br><br>
&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder:`Abstract`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: ~~IEntity~~<br>
&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder: `Concrete`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [Brand](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Entities/Concrete/Brand.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [Car](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Entities/Concrete/Car.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [Color](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Entities/Concrete/Color.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [Customer](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Entities/Concrete/Customers.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [CarImages](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Entities/Concrete/CarImages.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [Rental](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Entities/Concrete/Rentals.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [Payment](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Entities/Concrete/Payment.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder: `DTOs`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [CarDetailsDto](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Entities/DTOs/CarDetailDto.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [RentalDetailsDto](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Entities/DTOs/RentDetailDto.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [UserForLoginDto](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Entities/DTOs/UserForLoginDto.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [UserForRegisterDto](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Entities/DTOs/UserForRegisterDto.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [CustomerDetailDto](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Entities/DTOs/CustomerDetailDto.cs)<br>

### :file_folder: DataAccess Layer
Veritabanı CRUD işlemleri gerçekleştirmek için kurulan veri erişim katmanıdır.<br>
İki alt klasörden oluşmaktadır.<br>
&nbsp;&nbsp;1.`Abstract` klasörü soyut nesneleri tutmak için,<br>
&nbsp;&nbsp;2.`Concrete` klasörü somut nesneleri tutmak için. <br>
<br><br>
&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder:`Abstract`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [IBrandDal](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/DataAccess/Abstract/IBrandDal.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [ICarDal](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/DataAccess/Abstract/ICarDal.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [IColorDal](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/DataAccess/Abstract/IColorDal.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [ICustomerDal](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/DataAccess/Abstract/ICustomersDal.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [ICarImagesDal](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/DataAccess/Abstract/ICarImagesDal.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [IRentalDal](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/DataAccess/Abstract/IRentalsDal.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [IUserDal](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/DataAccess/Abstract/IUserDal.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [IPayment](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/DataAccess/Abstract/IPaymentDal.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder: `Concrete`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder: `EntityFrameWork`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [EfBrandDal](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/DataAccess/Concrete/EntityFramework/EfBrandDal.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [EfCarDal](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/DataAccess/Concrete/EntityFramework/EfCarDal.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [EfColorDal](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/DataAccess/Concrete/EntityFramework/EfColorDal.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [EfCustomerDal](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/DataAccess/Concrete/EntityFramework/EfCustomersDal.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [EfCarImagesDal](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/DataAccess/Concrete/EntityFramework/EfCarImagesDal.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [EfRentalDal](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/DataAccess/Concrete/EntityFramework/EfRentalsDal.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [EfUserDal](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/DataAccess/Concrete/EntityFramework/EfUserDal.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [EfPaymentDal](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/DataAccess/Concrete/EntityFramework/EfPaymentDal.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [CarDbContext](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/DataAccess/Concrete/EntityFramework/CarDbContext.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder: `InMemory`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [InMemoryCarDal](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/DataAccess/Concrete/InMemory/InMemoryCarDal.cs)<br>

### :file_folder: Business Layer
DataAccess tarafından veratabanından projeye çekilen verileri alarak işleyen katmandır. Bir başka deyişle iş yüklerinin yazıldığı katmandır.
Altı alt klasörden oluşur.<br>
&nbsp;&nbsp;1.`Abstract` klasörü soyut nesneleri tutmak için,<br>
&nbsp;&nbsp;2.`Concrete` klasörü somut nesneleri tutmak için,<br>
&nbsp;&nbsp;3.`BusinessAspect` klasörü güvenlik operasyonlarının yönetimi için,<br>
&nbsp;&nbsp;4.`Constants` klasörü kullanıcı verileri ile gerçekleştirilen işlem sonucunda bilgilendirme mesajlarının yönetimi için, <br>
&nbsp;&nbsp;5.`DependecyResolvers` klasörü instance oluşturmak için,<br>
&nbsp;&nbsp;6.`ValidationRules` klasörü doğrulama kurallarının yönetimi için oluşturulmuştur.<br>
<br><br>
&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder:`Abstract`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [IAuthService](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Business/Abstract/IAuthService.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [IBrandService](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Business/Abstract/IBrandService.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [ICarService](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Business/Abstract/ICarService.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [IColorService](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Business/Abstract/IColorService.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [ICustomerService](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Business/Abstract/ICustomersService.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [ICarImagesService](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Business/Abstract/ICarImagesService.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [IRentalService](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Business/Abstract/IRentalsService.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [IUserService](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Business/Abstract/IUserService.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [IPaymentService](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Business/Abstract/IPaymentService.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder:`Concrete`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [AuthManager](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Business/Concrete/AuthManager.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [BrandManager](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Business/Concrete/BrandManager.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [CarManager](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Business/Concrete/CarManager.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [ColorManager](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Business/Concrete/ColorManager.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [CustomersManager](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Business/Concrete/CustomersManager.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [CarImagesManager](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Business/Concrete/CarImagesManager.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [RentalsManager](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Business/Concrete/RentalsManager.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [UserManager](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Business/Concrete/UserManager.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [Payment](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Business/Concrete/PaymentManager.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder:`BusinessAspect`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder: `Autofac`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [SecuredOperation](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Business/BusinessAspects/Autofac/SecuredOperation.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder:`Constants`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [Messages](https://github.com/ilaydaez/ReCarProject2/blob/master/Business/Constants/Messages.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder:`DependecyResolvers`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder: `Autofac`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [AutofacBusinessModule](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Business/DependencyResolvers/Autofac/AutofacBusinessModule.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder:`ValidationRules`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder: `FluentValidation`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [CarValidator](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Business/ValidationRules/FluentValidation/CarValidator.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [CustomerValidator](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Business/ValidationRules/FluentValidation/CustomerValidator.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [CarImagesValidator](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Business/ValidationRules/FluentValidation/CarImagesValidator.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [PaymentValidator](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Business/ValidationRules/FluentValidation/PaymentValidator.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [UserValidator](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Business/ValidationRules/FluentValidation/UserValidator.cs)<br>


### :file_folder: Core Layer
Tüm projelerde kullanılacak ortak kodların bulunduğu evrensel bir katmandır.<br>
Yedi alt klasörden oluşmaktadır.<br>
&nbsp;&nbsp;1.`Aspects` klasörü,<br>
&nbsp;&nbsp;2.`CrossCuttingConcerns` klasörü,<br>
&nbsp;&nbsp;3.`DataAccess` klasörü,<br>
&nbsp;&nbsp;4.`Entities` klasörü, <br>
&nbsp;&nbsp;5.`DependecyResolvers` klasörü,<br>
&nbsp;&nbsp;6.`Extensions` klasörü,<br>
&nbsp;&nbsp;7.`Utilities` klasörü,<br>
<br><br>
&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder:`Aspect`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder: `Autofac`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder: `Caching`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [CacheAspect](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Core/Aspects/Autofac/Caching/CacheAspect.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [CacheRemoveAspect](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Core/Aspects/Autofac/Caching/CacheRemoveAspect.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder: `Performance`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [PerformanceAspect](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Core/Aspects/Autofac/Performance/PerformanceAspect.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder: `Transactional`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [TransactionScopeAspect](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Core/Aspects/Autofac/Transaction/TransactionScopeAspect.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder: `Validation`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [ValidationAspect](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Core/Aspects/Autofac/Validation/ValidationAspect.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder:`CrossCuttingConcerns`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder: `Caching`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder: `Microsoft`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [MemoryCacheManager](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Core/CrossCuttingConcerns/Caching/Microsoft/MemoryCacheManager.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder: `Validation`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [ValidationTool](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Core/CrossCuttingConcerns/Validation/ValidationTool.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder:`DataAccess`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder: `EntityFramework`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [EfEntityRepositoryBase](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Core/DataAccess/EntityFramework/EfEntityRepositoryBase.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder:`DependecyResolvers`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [CoreModule](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Core/DependencyResolvers/CoreModule.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder:`Entities`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [IDto](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Core/Entities/IDto.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder:`Concrete`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [OperationClaim](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Core/Entities/Concrete/OperationClaim.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [User](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Core/Entities/Concrete/User.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [UserOperationClaim](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Core/Entities/Concrete/UserOperationClaim.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder:`Extensions`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [ClaimExtensions](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Core/Extensions/ClaimExtensions.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [ClaimsPrincipalExtensions](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Core/Extensions/ClaimsPrincipalExtensions.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [ServiceCollectionExtensions](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Core/Extensions/ServiceCollectionExtensions.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder:`Utilities`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder:`Business`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [BusinessRules](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Core/Utilities/Business/BusinessRules.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder:`Interceptors`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [AspectInterceptorSelector](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Core/Utilities/Interceptors/AspectInterceptorSelector.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [MethodInterception](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Core/Utilities/Interceptors/MethodInterception.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [MethodInterceptionBaseAttribute](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Core/Utilities/Interceptors/MethodInterceptionBaseAttribute.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder:`IoC`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [ICoreModule](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Core/Utilities/IoC/ICoreModule.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [ServiceTool](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Core/Utilities/IoC/ServiceTool.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder:`Results`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [DataResult](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Core/Utilities/Results/DataResult.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [ErrorDataResult](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Core/Utilities/Results/ErrorDataResult.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [ErrorResult](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Core/Utilities/Results/ErrorResult.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [IDataResult](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Core/Utilities/Results/IDataResult.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [IResult](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Core/Utilities/Results/IResult.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [Result](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Core/Utilities/Results/Result.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [SuccessDataResult](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Core/Utilities/Results/SuccessDataResult.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [SuccessResult](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Core/Utilities/Results/SuccessResult.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder:`Security`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder:`Encryption`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [SecurityKeyHelper](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Core/Utilities/Security/Encryption/SecurityKeyHelper.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [SigningCredentialsHelper](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Core/Utilities/Security/Encryption/SigningCredentialsHelper.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder:`Hashing`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [HashingHelper](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Core/Utilities/Security/Hashing/HashingHelper.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder:`JWT`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [AccessToken](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Core/Utilities/Security/JWT/AccessToken.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [ITokenHelper](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Core/Utilities/Security/JWT/ITokenHelper.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [JwtHelper](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Core/Utilities/Security/JWT/JwtHelper.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [TokenOptions](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/Core/Utilities/Security/JWT/TokenOptions.cs)<br>

### :file_folder: WebAPI Layer
&nbsp;&nbsp;&nbsp;&nbsp;:open_file_folder:`Controllers`<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [AuthController](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/WebAPI/Controllers/AuthController.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [BrandController](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/WebAPI/Controllers/BrandController.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [CarsController](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/WebAPI/Controllers/CarsController.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [ColorController](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/WebAPI/Controllers/ColorController.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [CustomersController](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/WebAPI/Controllers/CustomersController.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [CarImagesController](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/WebAPI/Controllers/CarImagesController.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [RentalController](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/WebAPI/Controllers/RentalController.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [PaymentsController](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/WebAPI/Controllers/PaymentsController.cs)<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;:clipboard: [UsersController](https://github.com/cihanicelliler/ReCapProject-Backend/blob/master/WebAPI/Controllers/UsersController.cs)<br>
