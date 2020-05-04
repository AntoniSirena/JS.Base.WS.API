﻿using JS.Base.WS.API.Base;
using JS.Base.WS.API.DBContext;
using JS.Base.WS.API.DTO.Common;
using JS.Base.WS.API.Helpers;
using JS.Base.WS.API.Models.Authorization;
using JS.Base.WS.API.Models.PersonProfile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace JS.Base.WS.API.Controllers
{
    [RoutePrefix("api/common")]
    [Authorize]
    public class CommonController : ApiController
    {
        MyDBcontext db = new MyDBcontext();
        long currenntUserId = CurrentUser.GetId();

        [HttpGet]
        [Route("GetGenders")]
        public List<GenderDto> GetGenders()
        {
            List<GenderDto> genders = db.Genders.Where(x => x.IsActive == true).Select(y => new GenderDto
            {
                Id = y.Id,
                Description = y.Description,
                ShortName = y.ShortName
            }).ToList();

            return genders;
        }




        #region Models

        public class InfoCurrentUser
        {
            public string UserName { get; set; }
            public string Password { get; set; }
            public string Name { get; set; }
            public string SurName { get; set; }
            public string EmailAddress { get; set; }
        }

        public class InfoCurrentPerson
        {
            public string FirstName { get; set; }
            public string SecondName { get; set; }
            public string SurName { get; set; }
            public string SecondSurname { get; set; }
            public string BirthDate { get; set; }
            public string FullName { get; set; }
            public int GenderId { get; set; }
        }

        #endregion

    }
}
