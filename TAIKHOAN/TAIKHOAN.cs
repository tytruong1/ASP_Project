using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TAIKHOAN
    {
        //attribute
        private string _tenTaiKhoan;
        private string _matKhau;
        private string _email;
        private string _sDT;
        private string _diaChi;
        private string _hoTen;
        private short _laAdmin;
        private string _anhDaiDien;
        private short _trangThai;
   

        //Getor and Setor
        public string tenTaiKhoan { set { _tenTaiKhoan = value; } get { return _tenTaiKhoan; } }
        public string matKhau { set { _matKhau = value; } get { return _matKhau; } }
        public string email { set { _email = value; } get { return _email; } }
        public string sDT { set { _sDT = value; } get { return _sDT; } }
        public string diaChi { set { _diaChi = value; } get { return _diaChi; } }
        public string hoTen { set { _hoTen = value; } get { return _hoTen; } }
        public short laAdmin { set { _laAdmin = value; } get { return _laAdmin; } }
        public string anhDaiDien { set { _anhDaiDien = value; } get { return _anhDaiDien; } }
        public short trangThai { set { _trangThai = value; } get { return _trangThai; } }

        //constructor
        public TAIKHOAN(string _tenTaiKhoan, string _matKhau, string _email, string _sDT, string _diaChi, string _hoTen, short _laAdmin, string _anhDaiDien, short _trangThai)
        {
            this._tenTaiKhoan = _tenTaiKhoan;
            this._matKhau = _matKhau;
            this._email = _email;
            this._sDT = _sDT;
            this._diaChi = _diaChi;
            this._hoTen = _hoTen;
            this._laAdmin = _laAdmin;
            this._anhDaiDien = _anhDaiDien;
            this._trangThai = _trangThai;
        }

       
    }
}
