# Tugas Besar ke-2 IF4020 Kriptografi

# Aplikasi Klien Surel dengan Fitur Enkripsi dan Tanda Tangan Digital (Secure E-mail)

# Deskripsi Tugas

	Aplikasi klien surel (e-mail client) banyak tersedia di Internet. Sebagian besar tidak memiliki fitur enkripsi surel dan fitur tanda tangan digital. Surel rawan untuk disadap dan dibaca oleh pihak yang tidak berhak, dimanipulasi, dan sebagainya. Enkripsi dapat digunakan untuk untuk menjaga kerahasiaan surel, sedangkan tanda tangan digital dapat digunakan untuk keperluan otentikasi (pengirim dan penerima surel), keaslian isi surel (data integrity), an nirpenyangkalan (non-repudiation).
	Pada tugas besar 2 anda diminta membuat aplikasi klien surel sederhana yang dilengkapi dengan fitur enkripsi/dekripsi dan fitur tanda tangan digital. Surel dienkripsi dengan algoritma block-cipher yang sudah anda buat sebelumnya, sedangkan tanda tangan digital dibangkitkan dengan kolaborasi algoritma ECDSA (Elliptic Curve Digital Signature Algorithm) dan fungsi hash SHA-1.
	Tanda tangan digital bergantung pada isi surel dan kunci. Tanda-tangan digital direpresentasikan sebagai karakter-karakter heksadesimal dan ditaruh pada akhir surel. Untuk membedakan tanda-tangan digital dengan isi dokumen, maka tanda-tangan digital diawali dan diakhiri dengan tag  <ds> dan </ds>, atau tag lain.
	
# Spesifikasi Program

	1.	Klien surel dilengkapi dengan menu untuk membangkitkan kunci publik dan kunci privat untuk berdasarkan Elliptic Curve Cryptography.
	2.	Klien surel memiliki editor untuk mengetikkan isi surel, memasukkan alamat surel penerima, mengetikkan subyek surel, dll.
	3.	Klien surel dapat menampilkan inbox, sent email, dan fitur-fitur umum yang terdapat di dalam klien surel.
	4.	Klien surel boleh menyediakan attachment, tetapi file yang di-attach tidak perlu dienkripsi.
	5.	Pengguna dapat memilih apakah surel dienkripsi atau tidak (ada toggle icon untuk memilihnya)
	6.	Pengguna dapat memilih apakah surel ditandatangani atau tidak (ada toggle icon untuk memilihnya).
	7.	Jika pengguna memilih mengenkripsi/dekripsi surel, maka klien surel meminta pengguna memasukkan kunci.
	8.	Isi surel dienkripsi/dekripsi dengan block cipher yang sudah andfa buat pada tugas pengganti UTS.
	9.	Program SHA-1 harus dibuat sendiri (tidak menggunakan library atau fungsi built-in)
	10.	Jika pengguna memilih menandatangani surel (baik surel terenkripsi atau tidak), maka klien meminta kunci privat. Untuk memverifikasi tanda tangan digital, klien surel meminta kunci public. Kunci public/privat dapat dibaca dari file atau diketikkan oleh pengguna.
	11.	Bahasa dan kakas yang digunakan bebas (Java, C#, C++, Phyton, dll).
	12.	Platform yang digunakan bebas (desktop, mobile)
	13.	Sistem operasi yang digunakan bebas (Windows, Android, iOS, dll).
	14.	Untuk program klien surel sendiri boleh menggunakan open source atau dibuat sendiri.
