﻿namespace BookRentalShopApp
{
    public enum BaseMode
    {
        NONE,   //기본 상태
        INSERT, //입력 상태
        UPDATE, //수정 상태
        DELETE, //
        SELECT  //
    }
    public class Commons
    {
        //공통 DB연결 문자열
        public static readonly string CONNSTR = "Data Source=localhost;port=3306;Database=bookrentalshop;Uid=root;Password=mysql_p@ssw0rd";
        

    }
}
