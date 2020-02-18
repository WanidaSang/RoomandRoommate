using RoomAndRoomMate.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace RoomandRoommatematching.Models
{
    public class roommateModel
    {
        public int id_dormitory { get; set; }
        public char name_dormitory { get; set; }
        public int id_province { get; set; }
        public char address_dormitory { get; set; }
        public float price_dormitory { get; set; }
        public int phone_dormitory { get; set; }
        public int elecbill_dormitory { get; set; }
        public int waterbill_dormitory { get; set; }
        public char email_dormitory { get; set; }
        public int insurancefee_dormitory { get; set; }
        public char facilities_dormitory { get; set; }
        public int people_dormitory { get; set; }
        public char gender_dormitory { get; set; }
        public char animal_dormitory { get; set; }
        public char smoke_dormitory { get; set; }
        public char door1win_dormitory { get; set; }
        public char door1walk_dormitory { get; set; }
        public char door2win_dormitory { get; set; }
        public char door2walk_dormitory { get; set; }
        public char map_dormitory { get; set; }
        public char picture1_dormitory { get; set; }
        public char picture2_dormitory { get; set; }
        public char picture3_dormitory { get; set; }
        public char picture4_dormitory { get; set; }
        public char picture5_dormitory { get; set; }
        public char province_dormitory { get; set; }


        //public void AddNew()
        //{
        //    dbConnector db = new dbConnector();
        //    SqlCommand cmd = new SqlCommand(@"INSERT INTO ");
        //    cmd.Parameters.Add(new SqlParameter("name", SqlDbType.NVarChar)).Value = Name;
        //    DataTable dt = db.ExecuteDataSet(cmd, db.Connection).Tables[0];
        //    return dt;
        //}


    }
}
