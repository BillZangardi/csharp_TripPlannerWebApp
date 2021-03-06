﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;


namespace EventTermProjectWS
{
    /// <summary>
    /// Summary description for EventService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class EventService : System.Web.Services.WebService
    {
        
        [WebMethod]
        public DataSet GetEvents(Agency agency, string city, string state)
        {
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetEvents";

            objCommand.Parameters.AddWithValue("@state", state);
            objCommand.Parameters.AddWithValue("@city", city);
            objCommand.Parameters.AddWithValue("@agencyID", agency.ID);

            DBConnect objDB = new DBConnect();
            DataSet myDS = objDB.GetDataSetUsingCmdObj(objCommand);
            return myDS;

        }

        [WebMethod]
        public DataSet FindEvents(Activity activity, string city, string state)
        {
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "FindEvents";

          
            objCommand.Parameters.AddWithValue("@state", state);
            objCommand.Parameters.AddWithValue("@city", city);
            objCommand.Parameters.AddWithValue("@activityType", activity.type);
            objCommand.Parameters.AddWithValue("@activityDay", activity.day);
            objCommand.Parameters.AddWithValue("@activityTime", activity.time);


            DBConnect objDB = new DBConnect();
            DataSet myDS = objDB.GetDataSetUsingCmdObj(objCommand);
            return myDS;
        }

        [WebMethod]
        public DataSet GetEventAgencies(string city, string state)
        {
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetEventAgencies";

            objCommand.Parameters.AddWithValue("@state", state);
            objCommand.Parameters.AddWithValue("@city", city);

            DBConnect objDB = new DBConnect();
            DataSet myDS = objDB.GetDataSetUsingCmdObj(objCommand);
            return myDS;

        }

        [WebMethod]
        public Boolean Reserve(Event eventObj, Customer custObj)
        {
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "Reserve";

            Random rnd = new Random();
            int reserveId = rnd.Next(1, 1000);
            objCommand.Parameters.AddWithValue("@reserveID", reserveId);
            objCommand.Parameters.AddWithValue("@eventID", eventObj.ID);
            objCommand.Parameters.AddWithValue("@agencyID", eventObj.AgencyID);
            objCommand.Parameters.AddWithValue("@firstName", custObj.CustomerFirstName);
            objCommand.Parameters.AddWithValue("@lastName", custObj.CustomerLastName);
            objCommand.Parameters.AddWithValue("@email", custObj.CustomerEmail);
            objCommand.Parameters.AddWithValue("@phone", custObj.CustomerPhone);
            DBConnect objDB = new DBConnect();
            if (objDB.DoUpdateUsingCmdObj(objCommand) > 0)
            {
                return true;
            }
            else { return false; }

        }
    }
}
