using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebServer.Models.KSOA
{
    public class wqh_speech_lib:DataInfor
    {
        public string text { get; set; }
        public string URL { get; set; }

        public static wqh_speech_lib Get(string text) {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                var sql = @"select * from wqh_speech_lib(nolock) where text = @text ";
                return conn.QueryFirstOrDefault<wqh_speech_lib>(sql, new { text });
            }
        }

        public void Add() {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                var sql = @"insert into wqh_speech_lib(text,url)values(@text,@url)";
                conn.Execute(sql, this);
            }
        }
    }
}