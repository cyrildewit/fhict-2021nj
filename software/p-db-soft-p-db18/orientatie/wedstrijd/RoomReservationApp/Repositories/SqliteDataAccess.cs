using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloedPressureApp
{
    public class SqliteDataAccess
    {
        public static List<TimeSlotModel> LoadTimeSlots(string dateTime, string timeSlot)
        {
            using IDbConnection cnn = new SQLiteConnection(LoadConnectionString());
            string q = string.Concat("SELECT * FROM time_slots WHERE datetime ='", dateTime, "' AND timeslot='", timeSlot, "';");
            var output = cnn.Query<TimeSlotModel>(q);

            return output.ToList();
        }

        public static void BookTimeSlot(TimeSlotModel timeSlot)
        {
            List<TimeSlotModel> list = LoadTimeSlots(timeSlot.Datetime, timeSlot.Timeslot);

            if (list.Count > 0) {
                using IDbConnection cnn = new SQLiteConnection(LoadConnectionString());
                cnn.Execute("INSERT into time_slots (roomid, datetime, timeslot, booked) values (@RoomId, @Datetime, @Timeslot, @Booked)", timeSlot);
            }
        }

        public static void UpdateTimeSlot(TimeSlotModel timeSlot)
        {
            using IDbConnection cnn = new SQLiteConnection(LoadConnectionString());
            string q = string.Concat("UPDATE time_slots SET roomid = '", timeSlot.Roomid, "', datetime ='", timeSlot.Datetime, "', timeslot='", timeSlot.Timeslot, "', booked='", timeSlot.Booked, "' WHERE id =", timeSlot.Id.ToString(), ";");
            cnn.Execute(q, timeSlot);
        }

        /*
                public static void SavePatient(PatientModel patient)
                {
                    using IDbConnection cnn = new SQLiteConnection(LoadConnectionString());
                    cnn.Execute("insert into patients (firstname, lastname, birthdate, gender) values (@FirstName, @LastName, @Birthdate, @Gender)", patient);
                }

                public static void UpdatePatient(PatientModel patient)
                {
                    using IDbConnection cnn = new SQLiteConnection(LoadConnectionString());
                    string q = string.Concat("UPDATE patients SET firstname = '", patient.FirstName, "', lastname ='", patient.LastName, "', birthdate='", patient.Birthdate, "', gender='", patient.Gender, "' WHERE id =", patient.Id.ToString(), ";");
                    cnn.Execute(q, patient);
                }

                public static void DeletePatient(PatientModel patient)
                {
                    using IDbConnection cnn = new SQLiteConnection(LoadConnectionString());
                    string q = string.Concat("DELETE FROM patients WHERE id =", patient.Id.ToString(), ";");
                    cnn.Execute(q, patient);
                }

                public static List<BloodPressureModel> LoadBloodPressureForPatient(PatientModel patient)
                {
                    using IDbConnection cnn = new SQLiteConnection(LoadConnectionString());
                    string q = string.Concat("SELECT * FROM blood_pressure WHERE patient_id =", patient.Id.ToString(), ";");
                    var output = cnn.Query<BloodPressureModel>(q);

                    return output.ToList();
                }

                public static void SaveBloodPressure(PatientModel patient, BloodPressureModel bloodPressure)
                {
                    using IDbConnection cnn = new SQLiteConnection(LoadConnectionString());
                    string q = string.Concat("INSERT INTO blood_pressure (patient_id, upper_pressure, under_pressure, result, notes) values (", patient.Id.ToString(), ", ", bloodPressure.UpperPressure, ", ", bloodPressure.UnderPressure, ", '", bloodPressure.Result, "', '", bloodPressure.Notes, "');");
                    cnn.Execute(q);
                }*/

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }

}
