using System.Security.Claims;

namespace PilotApp.Security
{
    public static class ClaimsIdentityExt
    {
        public static string TENANTID = "PilotApp.TenantId";

        public static void AddTenantId(this ClaimsIdentity claims, object tenantId)
        {
            claims.AddClaim(new Claim(TENANTID, tenantId?.ToString(), null, "PilotApp"));
        }

        public static bool IsTenantIdClaim(this ClaimsIdentity claims, string claimName)
        {
            return claimName == TENANTID;
        }
    }
}