using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DBDemo2.Entites;

namespace DBDemo2.Data
{
    public class ContactRepository : IContactsRepository
    {
        public void Delete(int id)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                // Open DB Connection
                conn.ConnectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=ContactsDb2022;Integrated Security=True;Pooling=False";
                conn.Open();
                // prepare sql delete stmt
                string sqlDelete = $"delete from contacts where contactid = {id}";

                // send sql cmd to db
                SqlCommand cmd = new SqlCommand(sqlDelete, conn);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                // close the conn
                conn.Close();
            }
        }

        public List<Contact> GetAllContacts()
        {
            // Open DB Connection
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=ContactsDb2022;Integrated Security=True;Pooling=False";
                conn.Open();

                // prepare the sql select stmt
                string sqlSelect = $"select * from contacts";
                SqlCommand cmd = new SqlCommand(sqlSelect, conn);

                // execute the statement
                SqlDataReader reader = cmd.ExecuteReader();

                List<Contact> contacts = new List<Contact>();

                while (reader.Read())
                {
                    // process the returned data
                    Contact c = new Contact();
                    c.ContactID = (int)(reader[0]);
                    c.Name = reader[1].ToString();
                    c.Mobile = reader[2].ToString();
                    c.Email = reader[3].ToString();
                    c.Location = reader[4].ToString();
                    contacts.Add(c);
                }
                return contacts;
            }
            finally
            {
                conn.Close();
            }
            
        }

        public Contact GetContact(int id)
        {
            // Open DB Connection
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=ContactsDb2022;Integrated Security=True;Pooling=False";
                conn.Open();

                // prepare the sql select stmt
                string sqlSelect = $"select * from contacts where contactid = {id}";
                SqlCommand cmd = new SqlCommand(sqlSelect, conn);

                // execute the statement
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                // process the returned data
                Contact c = new Contact();
                c.ContactID = (int)(reader[0]);
                c.Name = reader[1].ToString();
                c.Mobile = reader[2].ToString();
                c.Email = reader[3].ToString();
                c.Location = reader[4].ToString();

                return c;
            }
            finally
            {
                conn.Close();
            }
        }

        public Contact GetContactByName(string nameToSearch)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=ContactsDb2022;Integrated Security=True;Pooling=False";
                conn.Open();

                // prepare the sql select stmt
                string sqlSelect = $"select * from contacts where name = '{nameToSearch}'";
                SqlCommand cmd = new SqlCommand(sqlSelect, conn);

                // execute the statement
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                // process the returned data
                Contact c = new Contact();
                c.ContactID = (int)(reader[0]);
                c.Name = reader[1].ToString();
                c.Mobile = reader[2].ToString();
                c.Email = reader[3].ToString();
                c.Location = reader[4].ToString();

                return c;
            }
            finally
            {
                conn.Close();
            } 
        }

        public int GetContactCount()
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=ContactsDb2022;Integrated Security=True;Pooling=False";
                conn.Open();

                string sqlcount = $"select count(*) from contacts";
                SqlCommand cmd = new SqlCommand(sqlcount, conn);
                int count = (int)cmd.ExecuteScalar();
                return count;
            }
            finally
            {
                conn.Close();
            }
            
        }

        public List<Contact> GetContactsByLocation(string location)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=ContactsDb2022;Integrated Security=True;Pooling=False";
                conn.Open();
                string sqlSelect = $"select * from contacts where Location = '{location}'";
                SqlCommand cmd = new SqlCommand(sqlSelect, conn);

                SqlDataReader reader = cmd.ExecuteReader();
                List<Contact> contacts = new List<Contact>();

                while (reader.Read())
                {
                    Contact c = new Contact();
                    c.ContactID = (int)(reader[0]);
                    c.Name = reader[1].ToString();
                    c.Mobile = reader[2].ToString();
                    c.Email = reader[3].ToString();
                    c.Location = reader[4].ToString();
                    contacts.Add(c);
                }

                return contacts;
            }
            finally { 
            conn.Close();
            }
            
        }

        public void Save(Contact contactToSave)
        {
            // Open DB Connection
            
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=ContactsDb2022;Integrated Security=True;Pooling=False";
                conn.Open();

                // prepare the sql insert statement
                string sqlInsert = $"insert into contacts values('{contactToSave.Name}','{contactToSave.Mobile}','{contactToSave.Email}','{contactToSave.Location}')";

                // send the sql command to db
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = sqlInsert;
                cmd.ExecuteNonQuery();
            }

            // close the db connection
            finally
            {
                conn.Close();
            }
        }

        public void Update(Contact contactToUpdate)
        {
            SqlConnection conn = new SqlConnection();
            try
            {
                conn.ConnectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=ContactsDb2022;Integrated Security=True;Pooling=False";
                conn.Open();

                // prepare the sql insert statement
                string sqlupdate = $"update contacts set name='{contactToUpdate.Name}',mobile='{contactToUpdate.Mobile}',email='{contactToUpdate.Email}',location='{contactToUpdate.Location}' where contactID={contactToUpdate.ContactID}";

                // send the sql command to db
                SqlCommand cmd = new SqlCommand(sqlupdate,conn);
                cmd.ExecuteNonQuery();
            }

            // close the db connection
            finally
            {
                conn.Close();
            }
        }
    }
}
