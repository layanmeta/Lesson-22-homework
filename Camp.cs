using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_22
{
    class Camp
    {
        private readonly int m_id;
        public int m_Latitude {get; private set; }
        public int m_Longitude { get; set; }
        public int m_Number_Of_People { get; set;}
        public int m_Number_Of_Tents { get; set; }
        public int m_Number_Of_Flashlights { get; set; }
        private static int m_Last_CamplD = 0;
      
        public Camp(int m_id, int m_latitude, int m_longitude, int m_number_Of_People, int m_number_Of_Tents, int m_number_Of_Flashlights)
        {
            this.m_id = m_id;
           this.m_Latitude = m_latitude;
            this.m_Longitude = m_longitude;
            this.m_Number_Of_People = m_number_Of_People;
            this.m_Number_Of_Tents = m_number_Of_Tents;
            this.m_Number_Of_Flashlights = m_number_Of_Flashlights;
        }
     

        public override string ToString()
        {
            return $"id : {m_id}, {m_Latitude}, {m_Longitude}, number of people : {m_Number_Of_People}, number of flashlights : {m_Number_Of_Flashlights}, number of tents : {m_Number_Of_Tents}, last camp id : {m_Last_CamplD}";
        }

        public static bool operator ==(Camp c1 , Camp c2)
        {
           if(ReferenceEquals(c1, null) && ReferenceEquals(c2, null))
           {
                return true;
           }

            if (ReferenceEquals(c1, null) || ReferenceEquals(c2, null))
            {
                return false;
            }
            return c1.m_id == c2.m_id;
        }

        public static bool operator !=(Camp c1, Camp c2)
        {
            return !(c1.m_id == c2.m_id);
        }

        public static bool operator >(Camp c1, Camp c2)
        {
            return c1.m_Number_Of_People > c2.m_Number_Of_People;
        }
        public static bool operator <(Camp c1, Camp c2)
        {
            return c1.m_Number_Of_People < c2.m_Number_Of_People;
        }
        

        public override bool Equals(object obj)
        {
            Camp camp = obj as Camp;
            return this == camp;
        }
        public int GetHasCode()
        {
            return m_id;
        }
        

    }
}
