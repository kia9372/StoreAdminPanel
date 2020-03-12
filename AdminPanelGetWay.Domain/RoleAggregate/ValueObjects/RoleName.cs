using AdminPanelGetWay.Domain.BaseFramework;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace AdminPanelGetWay.Domain.Aggregates.ValueObjects
{
    public class RoleName : ValueObject<RoleName>
    {
        public string RoleNameFa { get;  set; }
        public string RoleNameEn { get;  set; }

        public RoleName(string RoleNameFa, string RoleNameEn)
        {
            this.SetRoleNameFa(RoleNameFa);
            this.SetRoleNameEn(RoleNameEn);
        }
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return RoleNameFa;
            yield return RoleNameEn;
        }

        public void SetRoleNameFa(string RoleNameFa)
        {
            if (string.IsNullOrWhiteSpace(RoleNameFa))
                throw new ArgumentException("The RoleNameFa Cannot be Null", nameof(RoleNameFa));

            //if (Regex.IsMatch(RoleNameFa, @"^[\u0600-\u06FF]+$"))
            //    throw new ArgumentException("The RoleNameFa Mustbe the Persian", nameof(RoleNameEn));
            this.RoleNameFa = RoleNameFa;
        }

        public void SetRoleNameEn(string RoleNameEn)
        {
            //if (Regex.IsMatch(RoleNameEn, @"^[\u0000-\u007F]+$"))
            //    throw new ArgumentException("The RoleNameEn Mustbe the English", nameof(RoleNameEn));

            if (string.IsNullOrWhiteSpace(RoleNameEn))
                throw new ArgumentException("The RoleNameEn Cannot be Null", nameof(RoleNameEn));

            this.RoleNameEn = RoleNameEn;
        }
    }
}
