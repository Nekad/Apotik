use master
go
create database apotek
go
use apotek
go
create table t_pegawai
(
	id_pegawai varchar(10) primary key,
	nama_pegawai varchar(100),
	jenis_kelamin bit,
	alamat varchar (100),
	telepon varchar(50),
	username varchar(50) unique,
	password varchar(50),
	aktif bit
)
go
create table t_kategori
(
	id_kategori varchar(10) primary key,
	kategori varchar(100) unique,
	aktif bit
)
go
create table t_satuan
(
	id_satuan varchar(10) primary key,
	satuan varchar(100) unique,
	aktif bit
)
go
create table t_supplier
(
	id_supplier varchar(10) primary key,
	supplier varchar(100) unique,
	alamat varchar(100),
	kota varchar(50),
	telepon varchar(50),
	aktif bit,
	id_pegawai varchar(10) references t_pegawai(id_pegawai)
)
go
create table t_obat
(
	id_obat varchar(10) primary key,
	nama_obat varchar(100) unique,
	id_kategori varchar(10) references t_kategori(id_kategori),
	id_satuan varchar(10) references t_satuan(id_satuan),
	harga_beli money,
	harga_jual money,
	stock numeric,
	aktif bit,
	id_pegawai varchar(10) references t_pegawai(id_pegawai)
)
go
create table t_pembelian
(
	faktur_pembelian varchar(20) primary key,
	tgl_pembelian datetime,
	id_supplier varchar(10) references t_supplier(id_supplier),
	disc float,
	total money,
	grand_total money,
	id_pegawai varchar(10) references t_pegawai(id_pegawai)
)
go
create table t_detail_pembelian
(
	faktur_pembelian varchar(20) references t_pembelian(faktur_pembelian),
	nomor int,
	id_obat varchar(10) references t_obat(id_obat),
	tgl_expired datetime,
	harga_beli money,
	jumlah numeric,
	sub_total money
)
go
create table t_penjualan
(
	faktur_penjualan varchar(20) primary key,
	tgl_penjualan datetime,
	disc float,
	total money,
	grand_total money,
	id_pegawai varchar(10) references t_pegawai(id_pegawai)
)
go
create table t_detail_penjualan
(
	faktur_penjualan varchar(20) references t_penjualan(faktur_penjualan),
	nomor int,
	id_obat varchar(10) references t_obat(id_obat),
	harga_jual money,
	jumlah numeric,
	sub_total money
)
go
create proc id_pegawai
as
begin
	select max(substring(id_pegawai, 2, 4)) as tahun, max(id_pegawai) as maksimum from t_pegawai
end
go
create proc insert_pegawai
@id_pegawai varchar(10),
@nama_pegawai varchar(100),
@jenis_kelamin bit,
@alamat varchar(100),
@telepon varchar(50),
@username varchar(50),
@password varchar(50),
@aktif bit
as
begin
	insert into t_pegawai (id_pegawai,nama_pegawai,jenis_kelamin,alamat,telepon,username,password,aktif)
	values (@id_pegawai,@nama_pegawai,@jenis_kelamin,@alamat,@telepon,@username,@password,@aktif)
end
go
create proc update_pegawai
@id_pegawai varchar(10),
@nama_pegawai varchar(100),
@jenis_kelamin bit,
@alamat varchar(100),
@telepon varchar(50),
@username varchar(50),
@password varchar(50),
@aktif bit
as
begin
	update t_pegawai set nama_pegawai = @nama_pegawai,
						 jenis_kelamin = @jenis_kelamin,
					     alamat = @alamat,
						 telepon = @telepon,
						 username = @username,
						 password = @password,
						 aktif = @aktif
			       where id_pegawai = @id_pegawai
end
go
create proc id_kategori
as
begin
	select max(substring(id_kategori, 2, 4)) as tahun, max(id_kategori) as maksimum from t_kategori
end
go
create proc insert_kategori
@id_kategori varchar(10),
@kategori varchar(100),
@aktif bit
as
begin
	insert into t_kategori (id_kategori,kategori,aktif)
	values (@id_kategori,@kategori,@aktif)
end
go
create proc update_kategori
@id_kategori varchar(10),
@kategori varchar(100),
@aktif bit
as
begin
	update t_kategori set kategori = @kategori,
						  aktif = @aktif
			        where id_kategori = @id_kategori
end
go
create proc id_satuan
as
begin
	select max(substring(id_satuan, 2, 4)) as tahun, max(id_satuan) as maksimum from t_satuan
end
go
create proc insert_satuan
@id_satuan varchar(10),
@satuan varchar(100),
@aktif bit
as
begin
	insert into t_satuan (id_satuan,satuan,aktif)
	values (@id_satuan,@satuan,@aktif)
end
go
create proc update_satuan
@id_satuan varchar(10),
@satuan varchar(100),
@aktif bit
as
begin
	update t_satuan set satuan = @satuan,
						aktif = @aktif
			      where id_satuan = @id_satuan
end
go
create proc id_supplier
as
begin
	select max(substring(id_supplier, 2, 4)) as tahun, max(id_supplier) as maksimum from t_supplier
end
go
create proc insert_supplier
@id_supplier varchar(10),
@supplier varchar(100),
@alamat varchar(100),
@kota varchar(50),
@telepon varchar(50),
@aktif bit,
@id_pegawai varchar(10)
as
begin
	insert into t_supplier (id_supplier,supplier,alamat,kota,telepon,aktif,id_pegawai)
	values (@id_supplier,@supplier,@alamat,@kota,@telepon,@aktif,@id_pegawai)
end
go
create proc update_supplier
@id_supplier varchar(10),
@supplier varchar(100),
@alamat varchar(100),
@kota varchar(50),
@telepon varchar(50),
@aktif bit,
@id_pegawai varchar(10)
as
begin
	update t_supplier set supplier = @supplier,
						  alamat = @alamat,
						  kota = @kota,
						  telepon = @telepon,
						  aktif = @aktif,
						  id_pegawai = @id_pegawai
			        where id_supplier = @id_supplier
end
go
create proc id_obat
as
begin
	select max(substring(id_obat, 2, 4)) as tahun, max(id_obat) as maksimum from t_obat
end
go
create proc insert_obat
@id_obat varchar(10),
@nama_obat varchar(100),
@id_kategori varchar(10),
@id_satuan varchar(10),
@harga_jual money,
@aktif bit,
@id_pegawai varchar(10)
as
begin
	declare @harga_beli money
	declare @stock numeric
	set @harga_beli = 0
	set @stock = 0
	insert into t_obat (id_obat,nama_obat,id_kategori,id_satuan,harga_beli,harga_jual,stock,aktif,id_pegawai)
	values (@id_obat,@nama_obat,@id_kategori,@id_satuan,@harga_beli,@harga_jual,@stock,@aktif,@id_pegawai)
end
go
create proc update_obat
@id_obat varchar(10),
@nama_obat varchar(100),
@id_kategori varchar(10),
@id_satuan varchar(10),
@harga_jual money,
@aktif bit,
@id_pegawai varchar(10)
as
begin
	update t_obat set nama_obat = @nama_obat,
				      id_kategori = @id_kategori,
					  id_satuan = @id_satuan,
					  harga_jual = @harga_jual,
					  aktif = @aktif,
					  id_pegawai = @id_pegawai
			    where id_obat = @id_obat
end
go
create proc faktur_pembelian
as
begin
	select max(substring(faktur_pembelian, 3, 4)) as tahun, max(faktur_pembelian) as maksimum from t_pembelian
end
go
create proc insert_pembelian
@faktur_pembelian varchar(20),
@tgl_pembelian datetime,
@id_supplier varchar(10),
@disc float,
@total money,
@grand_total money,
@id_pegawai varchar(10)
as
begin
	insert into t_pembelian (faktur_pembelian,tgl_pembelian,id_supplier,disc,total,grand_total,id_pegawai)
	values (@faktur_pembelian,@tgl_pembelian,@id_supplier,@disc,@total,@grand_total,@id_pegawai)
end
go
create proc insert_detail_pembelian
@faktur_pembelian varchar(20),
@nomor int,
@id_obat varchar(10),
@tgl_expired datetime,
@harga_beli money,
@jumlah numeric,
@sub_total money
as
begin
	insert into t_detail_pembelian (faktur_pembelian,nomor,id_obat,tgl_expired,harga_beli,jumlah,sub_total)
	values (@faktur_pembelian,@nomor,@id_obat,@tgl_expired,@harga_beli,@jumlah,@sub_total)
end
go
create trigger transaksi_pembelian
on t_detail_pembelian
for insert, update, delete
as
declare @harga_beli money
select @harga_beli=harga_beli from inserted
update t_obat set harga_beli = @harga_beli,
				  stock = stock + jumlah
from inserted where t_obat.id_obat = inserted.id_obat
go
create proc faktur_penjualan
as
begin
	select max(substring(faktur_penjualan, 3, 4)) as tahun, max(faktur_penjualan) as maksimum from t_penjualan
end
go
create proc insert_penjualan
@faktur_penjualan varchar(20),
@tgl_penjualan datetime,
@disc float,
@total money,
@grand_total money,
@id_pegawai varchar(10)
as
begin
	insert into t_penjualan (faktur_penjualan,tgl_penjualan,disc,total,grand_total,id_pegawai)
	values (@faktur_penjualan,@tgl_penjualan,@disc,@total,@grand_total,@id_pegawai)
end
go
create proc insert_detail_penjualan
@faktur_penjualan varchar(20),
@nomor int,
@id_obat varchar(10),
@harga_jual money,
@jumlah numeric,
@sub_total money
as
begin
	insert into t_detail_penjualan (faktur_penjualan,nomor,id_obat,harga_jual,jumlah,sub_total)
	values (@faktur_penjualan,@nomor,@id_obat,@harga_jual,@jumlah,@sub_total)
end
go
create trigger transaksi_penjualan
on t_detail_penjualan
for insert, update, delete
as
select * from inserted
update t_obat set stock = stock - jumlah
from inserted where t_obat.id_obat = inserted.id_obat
go
create view view_obat
as
select t_obat.id_obat,t_obat.nama_obat,t_kategori.id_kategori,t_kategori.kategori,t_satuan.id_satuan,t_satuan.satuan, t_obat.harga_beli,t_obat.harga_jual,t_obat.stock,t_obat.aktif,t_pegawai.id_pegawai,t_pegawai.nama_pegawai
from t_kategori INNER JOIN t_obat
ON t_kategori.id_kategori = t_obat.id_kategori INNER JOIN t_pegawai
ON t_obat.id_pegawai = t_pegawai.id_pegawai INNER JOIN t_satuan
ON t_obat.id_satuan = t_satuan.id_satuan
go
create view view_pembelian
as
select t_pembelian.faktur_pembelian,t_pembelian.tgl_pembelian,t_supplier.id_supplier,t_supplier.supplier,t_supplier.alamat,t_supplier.kota,t_supplier.telepon,t_detail_pembelian.nomor,t_obat.id_obat,t_obat.nama_obat,t_kategori.id_kategori,t_kategori.kategori,t_satuan.id_satuan, t_satuan.satuan,t_detail_pembelian.tgl_expired,t_obat.harga_beli,t_obat.stock,t_detail_pembelian.jumlah,t_detail_pembelian.sub_total,t_pembelian.disc,t_pembelian.total,t_pembelian.grand_total,t_pegawai.id_pegawai,t_pegawai.nama_pegawai
from t_detail_pembelian INNER JOIN t_obat
ON t_detail_pembelian.id_obat = t_obat.id_obat INNER JOIN t_kategori
ON t_obat.id_kategori = t_kategori.id_kategori INNER JOIN t_pegawai
ON t_obat.id_pegawai = t_pegawai.id_pegawai INNER JOIN t_pembelian
ON t_detail_pembelian.faktur_pembelian = t_pembelian.faktur_pembelian AND t_pegawai.id_pegawai = t_pembelian.id_pegawai INNER JOIN t_satuan
ON t_obat.id_satuan = t_satuan.id_satuan INNER JOIN t_supplier
ON t_pegawai.id_pegawai = t_supplier.id_pegawai AND t_pembelian.id_supplier = t_supplier.id_supplier
go
exec insert_pegawai 'P201100001','Administrator',1,'-','-','admin','admin',1