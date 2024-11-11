using SQLite;
using System;
using System.Collections.Generic;
using System.IO;

namespace App1.Models
{
    public class HocSinh
    {
        [PrimaryKey, AutoIncrement]
        public int HocSinhId { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public bool GioiTinh { get; set; }

        public string LopId {  get; set; }   

    }

    public class Lop
    {
        [PrimaryKey, AutoIncrement]
        public int LopId { get; set; }
        public string TenLop { get; set; }
    }

    public class GiaoVien
    {
        [PrimaryKey, AutoIncrement]
        public int GiaoVienId { get; set; }
        public string HoTen { get; set; }
        public string MonHoc { get; set; }
    }
    public class Diem
    {
        [PrimaryKey, AutoIncrement]
        public int DiemId { get; set; }
        public int HocSinhId { get; set; }
        public string MonHoc {  get; set; }
        public double DiemSo {  get; set; }
    }

    public class LichHoc
    {
        [PrimaryKey]
        public string LichHocId { get; set; }
        public int LopId { get; set; }
        public int Phong { get; set; }
        public int GiaoVienId { get; set; }
    }

    //internal class AdminDbContext
    //{
    //    private SQLiteConnection _db;

    //    public AdminDbContext()
    //    {
    //        // Get or create the database file
    //        _db = new SQLiteConnection(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Admin.db"));

    //        // Create tables if they don't exist
    //        _db.CreateTable<Admin>();
    //    }

    //    public void AddAdmin(Admin admin)
    //    {
    //        _db.Insert(admin);
    //    }

    //    public List<Admin> GetAdmins()
    //    {
    //        return _db.Table<Admin>().ToList();
    //    }

        
    //}

    //public class Admin
    //{
      
    //    public string Username { get; set; }
    //    public string PasswordHash { get; set; }
    //}

}