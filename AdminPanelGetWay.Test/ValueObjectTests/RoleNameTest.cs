using AdminPanelGetWay.Domain.Aggregates.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AdminPanelGetWay.Test.ValueObjectTests
{
    public class RoleNameTest
    {
        [Fact]
        public void ShuldRoleNameNotNull()
        {
            var roleName = new RoleName("ادمین", "Admin");
            Assert.NotNull(roleName.RoleNameFa);
            Assert.NotNull(roleName.RoleNameEn);
        }

        [Fact]
        public void ShuldReturnExxceptionRoleNameFa()
        {
            var roleName = new RoleName("", "Admin");
            Assert.Throws<ArgumentException>(()=>roleName.SetRoleNameFa(""));
        }
        [Fact]
        public void ShuldReturnExxceptionRoleNameEn()
        {
            var roleName = new RoleName("ادمین", "");
            Assert.Throws<ArgumentException>(() => roleName.SetRoleNameEn(""));
        }
    }
}
