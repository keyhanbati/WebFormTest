using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web; 

namespace WebFormTest
{
    public class UserContext : IUserContext
    {
        public int GetCurrentUserId()
        {
            return (int)HttpContext.Current.GetCurrentUserID();
        }

        public List<string> GetCurrentUserRoles()
        {
            var rolesJson = HttpContext.Current.Items[CustomeClaimType.UserRoles] as string;
            if (string.IsNullOrEmpty(rolesJson))
                return new List<string>();

            var data = rolesJson.Split(',').ToList();
            return data;
        }

        public List<int> CountryDivition()
        {
            var divitionstring = HttpContext.Current.Items[CustomeClaimType.CountryDivisions] as string;

            var division = new List<int>();
            if (!string.IsNullOrEmpty(divitionstring))
                division = divitionstring.Split(',').Select(s => int.Parse(s)).ToList();


            return division;
        }

        public int? ReferenceId()
        {
            var referenceIdString = HttpContext.Current.Items[CustomeClaimType.ReferenceId] as string;
            return int.TryParse(referenceIdString, out var ReferenceId) ? ReferenceId : (int?)null;
        }

        public int? ReferenceTypeId()
        {
            var referenceTypeIdstring = HttpContext.Current.Items[CustomeClaimType.ReferenceTypeId] as string;
            return int.TryParse(referenceTypeIdstring, out var ReferenceTypeId) ? ReferenceTypeId : (int?)null;
        }

        public string GetBranchBuyerCode()
        {
            throw new System.NotImplementedException();
        }

        public int? OrganizationTypeId()
        {
            var organizationTypeIdString = HttpContext.Current.Items[CustomeClaimType.OrganizationType] as string;
            return int.TryParse(organizationTypeIdString, out var organizationTypeId) ? organizationTypeId : (int?)null;
        }
    }

    public class CustomeClaimType
    {
        public const string CountryDivisions = nameof(CountryDivisions);
        public const string ReferenceId = nameof(ReferenceId);
        public const string ReferenceTypeId = nameof(ReferenceTypeId);
        public const string UserRoles = nameof(UserRoles);
        public const string PersonId = nameof(PersonId);
        public const string OrganizationType = nameof(OrganizationType);
    }

    public static class ExtentionMethos
    {

        public static void SetCurrentUserID(this HttpContext context, long userId)
        {
            context.Items["CurrentUserId"] = userId;
        }

        public static long GetCurrentUserID(this HttpContext context)
        {
            if (context.Request.IsAuthenticated)
            {
                return Conversions.ToLong(context.Items["CurrentUserId"]);
            }

            return 0L;
        }
    }
}