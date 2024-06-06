Create database CuaHangDienThoai;
go
use CuaHangDienThoai;
go

-- Bảng Account(Tài khoản)
create table Account(
	IdAccount int identity(1,1) primary key,
	AccountName nvarchar(max) not null,
	PassWord nvarchar(max) not null,
	Role nvarchar(max) not null,
	DayCreated date not null,
	RememberPassword nvarchar(max) not null,
	Email nvarchar(max) not null,
	Status nvarchar(max) not null
);
go
-- Bảng Staff(Nhân Viên)
create table Staff(
	IdStaff int references Account(IdAccount) on delete cascade,
	StaffName nvarchar(max) not null,
	Birthday date not null,
	PhoneNumber nvarchar(max) not null,
	ImageStaff nvarchar(max) not null,
	Gender nvarchar(max) not null,
	Address nvarchar(max) not null,
	primary key(IdStaff)
);
go
-- Bảng Customer(Khách Hàng)
create table Customer(
	IdCustomer int references Account(IdAccount) on delete cascade,
	CustomerName nvarchar(max) not null,
	Birthday date not null,
	PhoneNumber nvarchar(max) not null,
	ImageCustomer nvarchar(max) not null,
	Gender nvarchar(max) not null,
	primary key(IdCustomer)
);
go
-- Bảng Category(Danh mục)
create table Category(
	IdCategory int identity(1,1) primary key,
	CategoryName nvarchar(max) not null,
	ProductDetail nvarchar(max) not null,
	IdCategoryDad int not null
);
go
-- Bảng Product(Sản phẩm)
create table Product(
	IdProduct int identity(1,1) primary key,
	ProductName nvarchar(max) not null,
	Quantity int not null,
	Price decimal not null,
	Trademark nvarchar(max) not null, -- thương hiệu
	LaunchTime date not null, -- thời điểm ra mắt
	ImageProduct nvarchar(max) not null,
	DayCreated date not null, -- ngày nhập sản phẩm
	IdCategory int references Category(IdCategory) on delete cascade,
	ProductDetail nvarchar(max) not null
);
go
-- Bảng Cart(Giỏ Hàng)
create table Cart(
	IdProduct int references Product(IdProduct) on delete cascade,
	IdCustomer int references Customer(IdCustomer) on delete cascade,
	primary key(IdProduct, IdCustomer)
);
go
-- Bảng Order(Đơn Hàng)
create table OrderTable(
	IdOrder int identity(1,1) primary key,
	IdCustomer int references Customer(IdCustomer),
	IdStaff int references Staff(IdStaff),
	OrderStatus nvarchar(max) not null,
	TotalPrice decimal not null,
	DayBuy date not null,
	DeliveryAddress nvarchar(max) -- Địa chỉ nhận hàng
);
go
-- Bảng Voucher(Mã giảm giá)
create table Voucher(
	IdVoucher int identity(1,1) primary key,
	VoucherName nvarchar(max) not null,
	FixedPrice nvarchar(max) not null,
	MinimumPrice nvarchar(max) not null,
	Quantity int not null,
	StartDay date not null,
	EndDate date not null,
	IdCategory int references Category(IdCategory) on delete cascade
);
go
-- Bảng OrderDetail(Chi Tiết Đơn Hàng)
create table OrderDetail(
	IdOrderDetail int identity(1,1) primary key,
	IdOrder int references OrderTable(IdOrder) on delete cascade,
	IdProduct int references Product(IdProduct),
	QuantityProduct int not null,
	Price decimal not null,
	DiscountAmount int not null, -- Số tiền giảm giá
	IdVoucher int references Voucher(IdVoucher)
);
go

					-- Proc select
create proc selectAccount as
	select * from Account
-- exec selectAccount
go
create proc selectStaff as
	select * from Staff
-- exec selectStaff
go
create proc selectCustomer as
	select * from Customer
-- exec selectCustomer
go
create proc selectProduct as
	select * from Product
-- exec selectProduct
go
create proc selectCategory as
	select * from Category
go
create proc selectCart as
	select * from Cart
go
create proc selectOrderTable as
	select * from OrderTable
go
create proc selectOrderDetail as
	select * from OrderDetail
go
create proc selectVoucher as
	select * from Voucher
go

					-- Proc insert into
-- insert Account Customer
create proc insertAccountCustomer(@AccountName nvarchar(max), @PassWord nvarchar(max),
@Email nvarchar(max)) as
	insert into Account values(@AccountName, @PassWord, N'Customer', GETDATE(), 
	N'No', @Email, N'Offline')
	DECLARE @IdAccount INT;
	SET @IdAccount = SCOPE_IDENTITY ();
	insert into Customer values(@IdAccount, @AccountName, GETDATE(), N'0123456789',
	N'No Image', N'Male')
go

-- insert Customer Account
create proc insertCustomer(@CustomerName nvarchar(max), @Birthday date,
@PhoneNumber nvarchar(max), @ImageCustomer nvarchar(max),
@Gender nvarchar(max)) as
	DECLARE @RandomNumber NVARCHAR(MAX);
	DECLARE @AccountName NVARCHAR(MAX);
	-- Tạo số ngẫu nhiên: ban đầu là số thực -> int -> nvarchar
	SET @RandomNumber = CAST(CAST(RAND() * 10000 AS INT) AS NVARCHAR(MAX));
	-- Nối số ngẫu nhiên vào cuối CustomerName
	SET @AccountName = CONCAT(@CustomerName, @RandomNumber);
	insert into Account values(@AccountName, N'123', N'Customer', GETDATE(), 
	N'No', N'defaut@gmail.com', N'Offline')
	DECLARE @IdAccount INT;
	SET @IdAccount = SCOPE_IDENTITY ();
	insert into Customer values(@IdAccount, @CustomerName, @Birthday, @PhoneNumber,
	@ImageCustomer, @Gender)
go

-- insert Account Staff
create proc insertAccountStaff(@AccountName nvarchar(max), @PassWord nvarchar(max),
@Role nvarchar(max), @DayCreated date, @RememberPassword nvarchar(max),
@Email nvarchar(max), @Status nvarchar(max)) as
	insert into Account values(@AccountName, @PassWord, @Role, @DayCreated, 
	@RememberPassword, @Email, @Status)
	DECLARE @IdAccount INT;
	SET @IdAccount = SCOPE_IDENTITY ();
	insert into Staff values(@IdAccount, @AccountName, GETDATE(), N'0123456789',
	N'No Image', N'Male', N'Mỹ Hào - Hưng Yên')
go

-- insert Staff Account
create proc insertStaff(@StaffName nvarchar(max), @Birthday date,
@PhoneNumber nvarchar(max), @ImageStaff nvarchar(max),
@Gender nvarchar(max), @Address nvarchar(max)) as
	DECLARE @RandomNumber NVARCHAR(MAX);
	DECLARE @AccountName NVARCHAR(MAX);
	-- Tạo số ngẫu nhiên: ban đầu là số thực -> int -> nvarchar
	SET @RandomNumber = CAST(CAST(RAND() * 10000 AS INT) AS NVARCHAR(MAX));
	-- Nối số ngẫu nhiên vào cuối CustomerName
	SET @AccountName = CONCAT(@StaffName, @RandomNumber);
	insert into Account values(@AccountName, N'123', N'Staff', GETDATE(), 
	N'No', N'defaut@gmail.com', N'Offline')
	DECLARE @IdAccount INT;
	SET @IdAccount = SCOPE_IDENTITY ();
	insert into Staff values(@IdAccount, @StaffName, @Birthday, @PhoneNumber,
	@ImageStaff, @Gender, @Address)
go

-- insert Product
create proc insertProduct(@ProductName nvarchar(max), @Quantity int,
@Price decimal, @Trademark nvarchar(max), @LaunchTime date, @ImageProduct nvarchar(max),
@DayCreated date, @IdCategory int, @ProductDetail nvarchar(max)) as
	insert into Product values(@ProductName, @Quantity, @Price, @Trademark,
	@LaunchTime, @ImageProduct, @DayCreated, @IdCategory, @ProductDetail)
go

-- insert Category
create proc insertCategory(@CategoryName nvarchar(max), @ProductDetail nvarchar(max),
@IdCategoryDad int) as
	insert into Category values(@CategoryName, @ProductDetail, @IdCategoryDad)
go

-- insert Cart
create proc insertCart(@IdProduct int, @IdCustomer int) as
	insert into Cart values(@IdProduct, @IdCustomer)
go

-- insert Order
create proc insertOrder(@IdCustomer int, @IdStaff int, @OrderStatus nvarchar(max),
@TotalPrice decimal, @DayBuy date, @DeliveryAddress nvarchar(max)) as
	insert into OrderTable values(@IdCustomer, @IdStaff, @OrderStatus, 
	@TotalPrice, @DayBuy, @DeliveryAddress)
go 

-- insert Voucher
create proc insertVoucher(@VoucherName nvarchar(max), @FixedPrice nvarchar(max),
@MinimumPrice nvarchar(max), @Quantity int, @StartDay date, @EndDate date, @IdCategory int)
as
	insert into Voucher values(@VoucherName, @FixedPrice, @MinimumPrice, 
	@Quantity, @StartDay, @EndDate, @IdCategory)
go 

-- insert OrderDetail
create proc insertOrderDetail(@IdOrder int, @IdProduct int, @QuantityProduct int,
@Price decimal, @DiscountAmount int, @IdVoucher int) as
	insert into OrderDetail values(@IdOrder, @IdProduct, @QuantityProduct, 
	@Price, @DiscountAmount, @IdVoucher)
go

				-- Proc update
-- update Account
create proc updateAccount(@IdAccount int, @AccountName nvarchar(max), 
@PassWord nvarchar(max), @Role nvarchar(max), @DayCreated date,
@RememberPassword nvarchar(max), @Email nvarchar(max), @Status nvarchar(max))
as
begin
	update Account 
	set AccountName = @AccountName, PassWord = @PassWord,
	Role = @Role, DayCreated = @DayCreated, RememberPassword = @RememberPassword,
	Email = @Email, Status = @Status
	where IdAccount = @IdAccount
end
go 

-- update Staff
create proc updateStaff(@IdStaff int, @StaffName nvarchar(max), @Birthday date,
@PhoneNumber nvarchar(max), @ImageStaff nvarchar(max), @Gender nvarchar(max),
@Address nvarchar(max)) as
begin
	update Staff 
	set StaffName = @StaffName, Birthday = @Birthday,
	PhoneNumber = @PhoneNumber, ImageStaff = @ImageStaff,
	Gender = @Gender, Address = @Address
	where IdStaff = @IdStaff
end
go 

-- update Customer
create proc updateCustomer(@IdCustomer int, @CustomerName nvarchar(max),
@Birthday date, @PhoneNumber nvarchar(max), @ImageCustomer nvarchar(max),
@Gender nvarchar(max)) as
begin
	update Customer 
	set CustomerName = @CustomerName, Birthday = @Birthday,
	PhoneNumber = @PhoneNumber, ImageCustomer = @ImageCustomer,
	Gender = @Gender
	where IdCustomer = @IdCustomer
end
go 

-- update Category
create proc updateCategory(@IdCategory int, @CategoryName nvarchar(max),
@ProductDetail nvarchar(max), @IdCategoryDad int) as
begin
	update Category
	set CategoryName = @CategoryName, ProductDetail = @ProductDetail,
	IdCategoryDad = @IdCategoryDad
	where IdCategory = @IdCategory
end
go 

-- update Product
create proc updateProduct(@IdProduct int, @ProductName nvarchar(max), @Quantity int,
@Price decimal, @Trademark nvarchar(max), @LaunchTime date, @ImageProduct nvarchar(max),
@DayCreated date, @IdCategory int, @ProductDetail nvarchar(max)) 
as
	update Product
	set ProductName = @ProductName, Quantity = @Quantity,
	Price = @Price, Trademark = @Trademark, LaunchTime = @LaunchTime,
	ImageProduct = @ImageProduct, DayCreated = @DayCreated, 
	IdCategory = @IdCategory, ProductDetail = @ProductDetail
	where IdProduct = @IdProduct
go 

-- update OrderTable
create proc updateOrderTable(@IdOrder int, @IdCustomer int, @IdStaff int, 
@OrderStatus nvarchar(max), @TotalPrice decimal, @DayBuy date, 
@DeliveryAddress nvarchar(max))
as
	update OrderTable
	set IdCustomer = @IdCustomer, IdStaff = @IdStaff, 
	OrderStatus = @OrderStatus, TotalPrice = @TotalPrice,
	DayBuy = @DayBuy, DeliveryAddress = @DeliveryAddress
	where IdOrder = @IdOrder
go 

-- update Voucher
create proc updateVoucher(@IdVoucher int, @VoucherName nvarchar(max), 
@FixedPrice nvarchar(max), @MinimumPrice nvarchar(max), @Quantity int, @StartDay date, 
@EndDate date, @IdCategory int)
as
	update Voucher 
	set VoucherName = @VoucherName, FixedPrice = @FixedPrice,
	MinimumPrice = @MinimumPrice, Quantity = @Quantity,
	StartDay = @StartDay, EndDate = @EndDate, IdCategory = @IdCategory
	where IdVoucher = @IdVoucher
go 

-- update OrderDetail
create proc updateOrderDetail(@IdOrderDetail int, @IdOrder int, 
@IdProduct int, @QuantityProduct int, @Price decimal, 
@DiscountAmount int, @IdVoucher int)
as
	update OrderDetail 
	set IdOrder = @IdOrder, IdProduct = @IdProduct, 
	QuantityProduct = @QuantityProduct, Price = @Price,
	DiscountAmount = @DiscountAmount, IdVoucher = @IdVoucher
	where IdOrderDetail = @IdOrderDetail
go 

				-- Proc delete
-- delete Account Customer
create proc deleteAccountCustomer(@IdAccount int)
as
	delete from Cart where IdCustomer = @IdAccount
	-- IdCustomer = 3 vì 3 là dữ liệu ảo
	update OrderTable set IdCustomer = 3 where IdCustomer = @IdAccount
	delete from Account where IdAccount = @IdAccount
	delete from Customer where IdCustomer = @IdAccount
go 

-- delete Acount Staff
create proc deleteAccountStaff(@IdAccount int)
as
	-- IdStaff = 2 vì 2 là dữ liệu ảo
	update OrderTable set IdStaff = 2 where IdStaff = @IdAccount
	delete from Account where IdAccount = @IdAccount
	delete from Staff where IdStaff = @IdAccount
go 

-- delete Category
create proc deleteCategory(@IdCategory int)
as
	-- IdCategory = 1 vì 1 là dữ liệu ảo
	update Voucher set IdCategory = 1 where IdCategory = @IdCategory
	update Product set IdCategory = 1 where IdCategory = @IdCategory
	delete from Category where IdCategory = @IdCategory
go 

-- delete Product
create proc deleteProduct(@IdProduct int)
as
	delete from Cart where IdProduct = @IdProduct
	update OrderDetail set IdProduct = 1 where IdProduct = @IdProduct
	delete from Product where IdProduct = @IdProduct
go 

-- delete Cart
create proc deleteCart(@IdProduct int, @IdCustomer int)
as
	delete from Cart 
	where IdCustomer = @IdCustomer and IdProduct = @IdProduct
go 

-- delete OrderTable
create proc deleteOrderTable(@IdOrder int)
as
	delete from OrderDetail where IdOrder = @IdOrder
	delete from OrderTable where IdOrder = @IdOrder
go 

-- delete Voucher
create proc deleteVoucher(@IdVoucher int)
as
	-- IdVoucher = 1 vì 1 là dữ liệu ảo
	update OrderDetail set IdVoucher = 1
	where IdVoucher = @IdVoucher
	delete from Voucher where IdVoucher = @IdVoucher
go 

-- proc bill
create proc bill(@IdOrder int) as
	SELECT	Product.ProductName, OrderDetail.QuantityProduct, 
			OrderDetail.Price, OrderTable.TotalPrice, OrderTable.DayBuy,
			Customer.CustomerName
	FROM	Customer INNER JOIN OrderTable on Customer.IdCustomer = OrderTable.IdCustomer
		INNER JOIN OrderDetail ON OrderDetail.IdOrder = OrderTable.IdOrder
		INNER JOIN Product on OrderDetail.IdProduct = Product.IdProduct
	where OrderTable.IdOrder = @IdOrder

go
-- virtual data
INSERT INTO Account (AccountName, PassWord, Role, DayCreated, RememberPassword, Email, Status)
VALUES (N'hieu', N'123', N'Admin', GETDATE(), N'No', N'defaut@gmail.com', N'Offline');
go
insertAccountStaff
    @AccountName = N'VirtualStaff',
    @PassWord = N'123',
    @Role = N'Staff',
    @DayCreated = '2024-1-1',
    @RememberPassword = N'No',
    @Email = N'defaut@gmail.com',
    @Status = N'Offline'
go
insertAccountCustomer
    @AccountName = N'VirtualCustomer',
    @PassWord = N'123',
    @Email = N'defaut@gmail.com'
go
insertAccountStaff
    @AccountName = N'hieu1',
    @PassWord = N'123',
    @Role = N'Staff',
    @DayCreated = '2024-1-1',
    @RememberPassword = N'No',
    @Email = N'defaut@gmail.com',
    @Status = N'Offline'
go
insertAccountCustomer
    @AccountName = N'hieu2',
    @PassWord = N'123',
    @Email = N'defaut@gmail.com'
go
INSERT INTO Category (CategoryName, ProductDetail, IdCategoryDad)
VALUES (N'Virtual category', N'6.5 in', 0)
go
INSERT INTO Product (ProductName, Quantity, Price, Trademark, LaunchTime, ImageProduct, DayCreated, IdCategory, ProductDetail)
VALUES (N'Virtual product', 0, 0, N'Virtual Trademark', GETDATE(), N'No Image', GETDATE(), 1, N'Virtual Product Detail')
go
INSERT INTO Voucher (VoucherName, FixedPrice, MinimumPrice, Quantity, StartDay, EndDate, IdCategory)
VALUES (N'Virtual voucher', '0', '0', 0, GETDATE(), GETDATE(), 1)
go
