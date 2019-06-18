//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
//
//     Produced by Entity Framework Visual Editor
//     https://github.com/msawczyn/EFDesigner
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Identity_EF6NetFramework
{
   public partial class ApplicationUser : Microsoft.AspNet.Identity.EntityFramework.IdentityUser<String, Microsoft.AspNet.Identity.EntityFramework.IdentityUserLogin<String>, Microsoft.AspNet.Identity.EntityFramework.IdentityUserRole<String>, Microsoft.AspNet.Identity.EntityFramework.IdentityUserClaim<String>>
   {
      partial void Init();

      /// <summary>
      /// Default constructor. Protected due to required properties, but present because EF needs it.
      /// </summary>
      protected ApplicationUser(): base()
      {
         Init();
      }

      /// <summary>
      /// Public constructor with required data
      /// </summary>
      /// <param name="emailconfirmed">Gets or sets a value that indicates whether the email is confirmed</param>
      /// <param name="phonenumberconfirmed">Gets or sets the value that indicates whether the phone number is confirmed. The default is false</param>
      /// <param name="twofactorenabled">Gets or sets a value that indicates whether two-factor authentication is enabled for the user</param>
      /// <param name="lockoutenabled">Gets or sets a value that indicates whether lockout enabled for this user</param>
      /// <param name="accessfailedcount">Gets or sets the number of failures for the purposes of lockout</param>
      /// <param name="username">Gets or sets the user name</param>
      public ApplicationUser(string username, bool emailconfirmed = false, bool phonenumberconfirmed = false, bool twofactorenabled = false, bool lockoutenabled = false, int accessfailedcount = 0)
      {
         this.EmailConfirmed = emailconfirmed;
         this.PhoneNumberConfirmed = phonenumberconfirmed;
         this.TwoFactorEnabled = twofactorenabled;
         this.LockoutEnabled = lockoutenabled;
         this.AccessFailedCount = accessfailedcount;
         if (string.IsNullOrEmpty(username)) throw new ArgumentNullException(nameof(username));
         this.UserName = username;
         Init();
      }

      /// <summary>
      /// Static create function (for use in LINQ queries, etc.)
      /// </summary>
      /// <param name="emailconfirmed">Gets or sets a value that indicates whether the email is confirmed</param>
      /// <param name="phonenumberconfirmed">Gets or sets the value that indicates whether the phone number is confirmed. The default is false</param>
      /// <param name="twofactorenabled">Gets or sets a value that indicates whether two-factor authentication is enabled for the user</param>
      /// <param name="lockoutenabled">Gets or sets a value that indicates whether lockout enabled for this user</param>
      /// <param name="accessfailedcount">Gets or sets the number of failures for the purposes of lockout</param>
      /// <param name="username">Gets or sets the user name</param>
      public static new ApplicationUser Create(string username, bool emailconfirmed = false, bool phonenumberconfirmed = false, bool twofactorenabled = false, bool lockoutenabled = false, int accessfailedcount = 0)
      {
         return new ApplicationUser(username, emailconfirmed, phonenumberconfirmed, twofactorenabled, lockoutenabled, accessfailedcount);
      }

      /*************************************************************************
       * Persistent properties
       *************************************************************************/

      public DateTime? CreateDate { get; set; }

   }
}

