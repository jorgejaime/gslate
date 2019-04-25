using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Jorge.Gslate.Model.DomainModels;
using Jorge.Gslate.Services.VieModels.User;

namespace Jorge.Gslate.Services.Mapping
{
    public static class UserMapping
    {
        public static IEnumerable<UserView> ToUserViewList(this IEnumerable<User> list)
        {
            return Mapper.Map<List<UserView>>(list);
        }

        public static UserView ToUserView(this User model)
        {
            return Mapper.Map<UserView>(model);
        }


        public static IEnumerable<User> ToUserList(this IEnumerable<UserView> list)
        {
            return Mapper.Map<List<User>>(list);
        }

        public static User ToUser(this UserView model)
        {
            return Mapper.Map<User>(model);
        }
    }
}
