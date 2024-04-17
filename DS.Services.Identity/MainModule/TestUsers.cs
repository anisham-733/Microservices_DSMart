// Copyright (c) Duende Software. All rights reserved.
// See LICENSE in the project root for license information.


using IdentityModel;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text.Json;
using Duende.IdentityServer;
using Duende.IdentityServer.Test;

namespace IdentityServerHost.Quickstart.UI
{
    public class TestUsers
    {
        public static List<TestUser> Users
        {
            get
            {
                var address = new
                {
                    street_address = "Sector Chi4",
                    locality = "Greater Noida",
                    postal_code = 201212,
                    country = "India"
                };
                
                return new List<TestUser>
                {
                    new TestUser
                    {
                        SubjectId = "818727",
                        Username = "deepak",
                        Password = "deepak",
                        Claims =
                        {
                            new Claim(JwtClaimTypes.Name, "Deepak Singh"),
                            new Claim(JwtClaimTypes.GivenName, "Deepak"),
                            new Claim(JwtClaimTypes.FamilyName, "Singh"),
                            new Claim(JwtClaimTypes.Email, "Deepak.singh@hanu.com"),
                            new Claim(JwtClaimTypes.EmailVerified, "true", ClaimValueTypes.Boolean),
                            new Claim(JwtClaimTypes.WebSite, "http://deepak.com"),
                            new Claim(JwtClaimTypes.Address, JsonSerializer.Serialize(address), IdentityServerConstants.ClaimValueTypes.Json)
                        }
                    },
                    new TestUser
                    {
                        SubjectId = "88421113",
                        Username = "munesh",
                        Password = "munesh",
                        Claims =
                        {
                            new Claim(JwtClaimTypes.Name, "Munesh"),
                            new Claim(JwtClaimTypes.GivenName, "Kumar"),
                            new Claim(JwtClaimTypes.FamilyName, "Munesh"),
                            new Claim(JwtClaimTypes.Email, "Munesh@hanu.com"),
                            new Claim(JwtClaimTypes.EmailVerified, "true", ClaimValueTypes.Boolean),
                            new Claim(JwtClaimTypes.WebSite, "http://munesh.com"),
                            new Claim(JwtClaimTypes.Address, JsonSerializer.Serialize(address), IdentityServerConstants.ClaimValueTypes.Json)
                        }
                    }
                };
            }
        }
    }
}