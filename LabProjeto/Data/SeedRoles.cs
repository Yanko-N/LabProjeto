﻿using Microsoft.AspNetCore.Identity;

namespace LabProjeto.Data
{
    public static class SeedRoles
    {
        public static void Seed(RoleManager<IdentityRole> roleManager)
        {

            if (roleManager.Roles.Any() == false)
            {
                roleManager.CreateAsync(new IdentityRole("Admin")).Wait();
                roleManager.CreateAsync(new IdentityRole("Funcionario")).Wait();
                roleManager.CreateAsync(new IdentityRole("Cliente")).Wait();


            }
        }

    }
}
