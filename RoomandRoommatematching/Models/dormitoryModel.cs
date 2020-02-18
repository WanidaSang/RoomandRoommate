using RoomAndRoomMate.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace RoomandRoommatematching.Models
{
    public class dormitoryModel
    {
        public int id_dormitory { get; set; }
        public String name_dormitory { get; set; }
        public int id_province { get; set; }
        public String address_dormitory { get; set; }
        public float price_dormitory { get; set; }
        public int telephone_dormitory { get; set; }
        public int elecbill_dormitory { get; set; }
        public int waterbill_dormitory { get; set; }
        public String email_dormitory { get; set; }
        public int insurancefree_dormitory { get; set; }
        public String facilities_dormitory { get; set; }
        public int people_dormitory { get; set; }
        public String gender_dormitory { get; set; }
        public String animal_dormitory { get; set; }
        public String smoke_dormitory { get; set; }
        public String door1win_dormitory { get; set; }
        public String door1walk_dormitory { get; set; }
        public String door2win_dormitory { get; set; }
        public String door2walk_dormitory { get; set; }
        public String map_dormitory { get; set; }
        public String picture1_dormitory { get; set; }
        public String picture2_dormitory { get; set; }
        public String picture3_dormitory { get; set; }
        public String picture4_dormitory { get; set; }
        public String picture5_dormitory { get; set; }
        public String province_dormitory { get; set; }


        public DataTable getDormitoryAll(String Name)
        {
            dbConnector db = new dbConnector();
            SqlCommand cmd = new SqlCommand(@"SELECT * 
                                              from dormitory inner join province on dormitory.id_province = province.id_province
                                              WHERE name_dormitory like '%' + @name + '%'");
            cmd.Parameters.Add(new SqlParameter("name", SqlDbType.NVarChar)).Value = Name;
            DataTable dt = db.ExecuteDataSet(cmd, db.Connection).Tables[0];
            return dt;
        }

        public void AddNew()
        {
            dbConnector db = new dbConnector();
            SqlCommand cmd = new SqlCommand(@"INSERT INTO dormitory([name_dormitory]
                                                                   ,[address_dormitory]
                                                                   ,[price_dormitory]
                                                                   ,[telephone_dormitory]
                                                                   ,[elecbill_dormitory]
                                                                   ,[waterbill_dormitory]
                                                                   ,[email_dormitory]
                                                                   ,[insurancefree_dormitory]
                                                                   ,[facilities_dormitory]
                                                                   ,[gender_dormitory]
                                                                   ,[people_dormitory]
                                                                   ,[animal_dormitory]
                                                                   ,[smoke_dormitory]
                                                                   ,[door1win_dormitory]
                                                                   ,[door1walk_dormitory]
                                                                   ,[door2win_dormitory]
                                                                   ,[door2walk_dormitory]
)
                                                             VALUES
                                                                   (@name_dormitory
                                                                   ,@address_dormitory
                                                                   ,@price_dormitory
                                                                   ,@telephone_dormitory
                                                                   ,@elecbill_dormitory
                                                                   ,@waterbill_dormitory
                                                                   ,@email_dormitory
                                                                   ,@insurancefree_dormitory
                                                                   ,@facilities_dormitory
                                                                   ,@gender_dormitory
                                                                   ,@people_dormitory
                                                                   ,@animal_dormitory
                                                                   ,@smoke_dormitory
                                                                   ,@door1win_dormitory
                                                                   ,@door1walk_dormitory
                                                                   ,@door2win_dormitory
                                                                   ,@door2walk_dormitory)");

            //SqlCommand cmd = new SqlCommand(@"INSERT INTO dormitory([name_dormitory]
            //                                                       ,[address_dormitory]
            //                                                       ,[id_province]
            //                                                       ,[price_dormitory]
            //                                                       ,[telephone_dormitory]
            //                                                       ,[elecbill_dormitory]
            //                                                       ,[waterbill_dormitory]
            //                                                       ,[email_dormitory]
            //                                                       ,[insurancefree_dormitory]
            //                                                       ,[facilities_dormitory]
            //                                                       ,[gender_dormitory]
            //                                                       ,[people_dormitory]
            //                                                       ,[animal_dormitory]
            //                                                       ,[smoke_dormitory]
            //                                                       ,[door1win_dormitory]
            //                                                       ,[door1walk_dormitory]
            //                                                       ,[door2win_dormitory]
            //                                                       ,[door2walk_dormitory]
            //                                                       ,[map_dormitory]
            //                                                       ,[picture1_dormitory]
            //                                                       ,[picture2_dormitory]
            //                                                       ,[picture3_dormitory]
            //                                                       ,[picture4_dormitory]
            //                                                       ,[picture5_dormitory])
            //                                                 VALUES
            //                                                       (@name_dormitory
            //                                                       ,@address_dormitory
            //                                                       ,@id_province
            //                                                       ,@price_dormitory
            //                                                       ,@telephone_dormitory
            //                                                       ,@elecbill_dormitory
            //                                                       ,@waterbill_dormitory
            //                                                       ,@email_dormitory
            //                                                       ,@insurancefree_dormitory
            //                                                       ,@facilities_dormitory
            //                                                       ,@gender_dormitory
            //                                                       ,@people_dormitory
            //                                                       ,@animal_dormitory
            //                                                       ,@smoke_dormitory
            //                                                       ,@door1win_dormitory
            //                                                       ,@door1walk_dormitory
            //                                                       ,@door2win_dormitory
            //                                                       ,@door2walk_dormitory
            //                                                       ,@map_dormitory
            //                                                       ,@picture1_dormitory
            //                                                       ,@picture2_dormitory
            //                                                       ,@picture3_dormitory
            //                                                       ,@picture4_dormitory
            //                                                       ,@picture5_dormitory)");


            cmd.Parameters.Add(new SqlParameter("name_dormitory", SqlDbType.NVarChar)).Value = this.name_dormitory;
            cmd.Parameters.Add(new SqlParameter("address_dormitory", SqlDbType.NVarChar)).Value = this.address_dormitory;
            cmd.Parameters.Add(new SqlParameter("price_dormitory", SqlDbType.Float)).Value = this.price_dormitory;
            cmd.Parameters.Add(new SqlParameter("telephone_dormitory", SqlDbType.Int)).Value = this.telephone_dormitory;

            cmd.Parameters.Add(new SqlParameter("elecbill_dormitory", SqlDbType.Int)).Value = this.elecbill_dormitory;
            cmd.Parameters.Add(new SqlParameter("waterbill_dormitory", SqlDbType.Int)).Value = this.waterbill_dormitory;
            cmd.Parameters.Add(new SqlParameter("email_dormitory", SqlDbType.NVarChar)).Value = this.email_dormitory;
            cmd.Parameters.Add(new SqlParameter("insurancefree_dormitory", SqlDbType.Int)).Value = this.insurancefree_dormitory;

            cmd.Parameters.Add(new SqlParameter("facilities_dormitory", SqlDbType.NVarChar)).Value = this.facilities_dormitory;

            cmd.Parameters.Add(new SqlParameter("gender_dormitory", SqlDbType.NVarChar)).Value = this.gender_dormitory;
            cmd.Parameters.Add(new SqlParameter("people_dormitory", SqlDbType.Int)).Value = this.people_dormitory;
            cmd.Parameters.Add(new SqlParameter("animal_dormitory", SqlDbType.NVarChar)).Value = this.animal_dormitory;
            cmd.Parameters.Add(new SqlParameter("smoke_dormitory", SqlDbType.NVarChar)).Value = this.smoke_dormitory;

            cmd.Parameters.Add(new SqlParameter("door1win_dormitory", SqlDbType.NVarChar)).Value = this.door1win_dormitory;
            cmd.Parameters.Add(new SqlParameter("door1walk_dormitory", SqlDbType.NVarChar)).Value = this.door1walk_dormitory;
            cmd.Parameters.Add(new SqlParameter("door2win_dormitory", SqlDbType.NVarChar)).Value = this.door2win_dormitory;
            cmd.Parameters.Add(new SqlParameter("door2walk_dormitory", SqlDbType.NVarChar)).Value = this.door2walk_dormitory;

            db.ExecuteNonQuery(cmd, db.Connection);
        }


    }
}
