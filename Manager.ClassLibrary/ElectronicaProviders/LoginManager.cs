using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Electronica.Repository;
using Electronica.Manager.ElectronicaDto;
using Electronica.Entity;

namespace Electronica.Manager.ElectronicaProviders
{
    public class LoginManager
    {
        public ParticipantDto CheckLogin(LoginDto objLoginDto)
        {
            ParticipantDto objCheck = new ParticipantDto();
            try
            {



                LoginDal objLoginDal = new LoginDal();
                User objLogin = new User();
                objLogin.Email = Convert.ToString(objLoginDto.Email);
                objLogin.Password = Convert.ToString(objLoginDto.Password);
                User objNew = new User();
                objNew = objLoginDal.CheckLogin(objLogin);

               
                objCheck.Education = objNew.Education;
                objCheck.Email = objNew.Email;
                objCheck.FirstName = objNew.FirstName;
                objCheck.LastName = objNew.LastName;
                objCheck.Mobile = objNew.Mobile;
                objCheck.UserID = objNew.UserID;
            }
            catch (FormatException ex)
            {
                throw ex;

            }
            return objCheck;
        }
    }
}