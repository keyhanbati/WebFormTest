using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebFormTest
{
    public interface IUserContext
    {
        int GetCurrentUserId();
        List<string> GetCurrentUserRoles();
        List<int> CountryDivition();
        int? ReferenceId();
        int? ReferenceTypeId();
        string GetBranchBuyerCode();
        int? OrganizationTypeId();

        //Dictionary<string,List<string>> GetUserClaims();
    }
}
