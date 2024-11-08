CREATE TABLE admin (
id SERIAL PRIMARY KEY,
nama_admin VARCHAR(100) NOT NULL,
email Varchar (100) NOT NULL,
telepon INT (50) NOT NULL,
);


CREATE TABLE customer (
id SERIAL PRIMARY KEY,
nama VARCHAR(100) NOT NULL,
alamat VARCHAR(20) UNIQUE NOT NULL,
email VARCHAR(100) NOT NULL,
telepon INT (25) NOT NULL,
);

INSERT INTO TABLE admin (nama_admin) VALUES
('Shofia')
('shiaazl')
('13xksbi')

