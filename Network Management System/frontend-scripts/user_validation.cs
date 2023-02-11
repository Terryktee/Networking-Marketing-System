/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Network_Management_System;
using System.Windows.Forms;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Network_Management_System.frontend_scripts
{
    class validation
    {
        
    //Global EmailValidator
    static void EmailValidator()
        {
             [Required]
            [EmailAddress]
            [RegularExpression("w+")]
            private string email {  get; set; }
        
        }
        //Validation for login_input
        static void LoginValidation()
    {
            [Required]
             private string Username{get;set;}
            [Required]
            [EmailAddress]
            public string Email { get; set; }
            [Required]
            [RegularExpression("W+")]
            public string Password { get; set; }
        }
        // validation for signupinput

        static void signupinput()
{

            [Required]
            [RegularExpression("w+")]
            public string Username { set; get; }

            [Required]
            [Range(1,9999)]
            public string Name { get; set; }

            [Range(1, 15)]

            public int Experience { set; get; }
            [Required]
            public string Country { set; get; }

            [Required]
            public string Plan { set; get; }

           [Required]
              [EmailAddress]
              public string Email { set; get; }

            [Required]
            [Range(10, 15)]
            [RegularExpression("w+")]
            public string Password { set; get; }

            [Required]
            [Range(10,20)]
            public int phone_number{get;set;}
        }
//password change

private static void NewPasswordValidation()
{ 
            [Required]
            [RegularExpression("T+"]
            [Compare("Equals")]
            public string password { get; set; }
            [Required]
            [RegularExpression]
            [Compare]
            public string password { set; get; }
        }

       private static void ewallet_withdraw()
{

            [Required]
            [Range(1, 10)]
            public int withdrawel_id { set; get; }

            [Required]
            [RegularExpression]
            public string name { set; get; }

            [Required]
            [Range(1, 20)]
            public int bank_account{ set; get; }
            [Required]
            [Range(1000,9999)]
            public string E_pin{ set; get; }

            [Required]
            [Range(1,99999)]
            public int amount { set; get; }
        }


        static void epurchase()
{

            [Required]
            [Range(1, 10)]
            public int purchase_id{ set; get; }

            [Required]
            public int commission { set; get; }

            [Required]
            [Range(1000,)]
            public string e_pin { set; get; }

            [Required]
            [Range]
            public int amount { set; get; }
        }
    }
}*/