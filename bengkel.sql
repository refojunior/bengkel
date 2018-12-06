use bengkel

select * from tb_customer

CREATE TABLE tb_user (
	id int NOT NULL identity(1,1),
	username varchar(100),
	password varchar(255)
)

CREATE TABLE tb_customer (
	id INT NOT NULL identity(1,1),
	nama_customer varchar(100) NOT NULL,
	alamat varchar(255) NOT NULL,
	email varchar(150) NOT NULL,
	telp INT NOT NULL,
	PRIMARY KEY (id)
);

CREATE TABLE tb_kendaraan (
	id INT NOT NULL identity(1,1),
	customer_id INT NOT NULL,
	nama_kendaraan varchar(50) NOT NULL,
	merk varchar(30) NOT NULL,
	tahun INT NOT NULL,
	plat_nomor varchar(15) NOT NULL,
	PRIMARY KEY (id)
);

CREATE TABLE tb_jasa (
	[id] INT NOT NULL IDENTITY,
	[nama_jasa] varchar(30) NOT NULL,
	[harga] INT NOT NULL,
	PRIMARY KEY ([id])
);

CREATE TABLE tb_service (
	[id] INT NOT NULL IDENTITY,
	[tanggal] DATE NOT NULL,
	[kendaraan_id] INT NOT NULL,
	[jasa_id] INT NOT NULL,
	[keterangan] varchar(255),
	PRIMARY KEY ([id])
);

CREATE TABLE tb_barang (
	[id] INT NOT NULL IDENTITY,
	[tipe_barang] varchar(20) CHECK(tipe_barang IN('kendaraan', 'sparepart')),
	[nama_barang] varchar(100) NOT NULL,
	[merk] varchar(20) NOT NULL,
	[harga] INT NOT NULL,
	PRIMARY KEY ([id])
);

CREATE TABLE tb_penjualan (
	[id] INT NOT NULL IDENTITY,
	[tanggal] DATE NOT NULL,
	[customer_id] INT NOT NULL,
	[barang_id] INT NOT NULL,
	[jumlah] INT NOT NULL,
	[total] INT NOT NULL,
	[payment_type] varchar(20) CHECK(payment_type IN('cash', 'kredit')),
	PRIMARY KEY ([id])
);

CREATE TABLE tb_pembelian (
	[id] INT NOT NULL IDENTITY,
	[barang_id] INT NOT NULL,
	[tanggal] DATE NOT NULL,
	[jumlah] INT NOT NULL,
	[total] INT NOT NULL,
	PRIMARY KEY ([id])
);

ALTER TABLE [tb_kendaraan] ADD CONSTRAINT [tb_kendaraan_fk0] FOREIGN KEY ([customer_id]) REFERENCES tb_customer([id]);

ALTER TABLE [tb_service] ADD CONSTRAINT [tb_service_fk0] FOREIGN KEY ([kendaraan_id]) REFERENCES tb_kendaraan([id]);

ALTER TABLE [tb_service] ADD CONSTRAINT [tb_service_fk1] FOREIGN KEY ([jasa_id]) REFERENCES tb_jasa([id]);

ALTER TABLE [tb_penjualan] ADD CONSTRAINT [tb_penjualan_fk0] FOREIGN KEY ([customer_id]) REFERENCES tb_customer([id]);

ALTER TABLE [tb_penjualan] ADD CONSTRAINT [tb_penjualan_fk1] FOREIGN KEY ([barang_id]) REFERENCES tb_barang([id]);

ALTER TABLE [tb_pembelian] ADD CONSTRAINT [tb_pembelian_fk0] FOREIGN KEY ([barang_id]) REFERENCES tb_barang([id]);

