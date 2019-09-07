using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCDemoFolderStructure.Models
{
    public class UserModel
    {
        public UserModel() { }


        public UserModel(int id, string name, string email, string nm, string pass, string gender, string url, int sid)
        {

            this.UserId = id;
            this.UserName = name;
            this.UserImageUrl = url;
            this.Password = pass;
            this.MobileNumber = nm;
            this.StateId = new StateModel() { StateId = sid };
            this.EmailId = email;
            this.Gender = gender;
            //this.StateId.CountryId = new CountryModel();
        }

        [Key]
        public int UserId { get; set; }
        [Required(ErrorMessage="Enter user name.")]
        [Display(Name="User Name*")]
        public string UserName { get; set; }

        [Required(ErrorMessage="Enter EmailId.")]
        [Display(Name ="EmailId*")]
        [DataType(DataType.EmailAddress)]
        public string EmailId { get; set; }

        [Required(ErrorMessage = "Enter Password.")]
        [Display(Name = "Password*")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Enter Confirm Password.")]
        [Display(Name = "Confirm Password*")]
        [Compare("Password",ErrorMessage ="Please Enter the correct password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
        public string MobileNumber { get; set; }
        public string UserImageUrl { get; set; }
        public string Gender { get; set; }
        public StateModel StateId { get; set; }
        public List<StateModel> GetStates
        {
            get
            {
                return new List<StateModel>()
                {
                    new StateModel()
                    {
                        StateId = 1,
                        StateName = "RAJ",
                    },
                    new StateModel()
                    {
                        StateId = 2,
                        StateName = "Guj",
                    },
                };
            }
        }
    }
}