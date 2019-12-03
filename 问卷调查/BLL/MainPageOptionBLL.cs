using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 问卷调查.BLL
{
    public   class MainPageOptionBLL
    {

       static  paper_QuestionnaireEntities context = new paper_QuestionnaireEntities();

        public IQueryable<UserInfo> entitiesUseinfo  ;//用户信息
        public  IQueryable<UserRole> entitiesUserRole= context.UserRole;//角色
        public  IQueryable<MenuInfo> entitiesMenuInfo = context.MenuInfo;//角色;
          // public IQueryable<MenuInfo> entitiesMenuInfo1;//菜单

        /// <summary>
        /// 根据用户ID返回用户角色对象
        /// </summary>
        /// <param name="ID">用户ID</param>
        public  IQueryable<UserRole> GetByUserID(int UserID)
        {
            //query语法
            //var users = from u in context.UserInfo
            // where u.userName == "admin"
            //select u;
            //method语法
         
            var users2 = context.UserRole.Where<UserRole>(user => user.UserID ==UserID);
            entitiesUserRole = users2;
            return users2;
        }

        /// <summary>
        /// 根据角色ID返回一级菜单ID列表
        /// </summary>
        /// <param name="RoleID">角色ID</param>
        public  IQueryable<int> GetMenusByRoleID(int RoleTypeID)
        {
            entitiesMenuInfo = context.MenuInfo;
            return entitiesMenuInfo.Where(x => x.RoleTypeID == RoleTypeID&&x.leven==1).Select(o => o.MenuID);
        }

        /// <summary>
        /// 根据父级菜单ID返回菜单ID列表
        /// </summary>
        /// <param name="RoleID">角色ID</param>
        public IQueryable<int> GetMenusByParentID(int ParentID)
        {
            entitiesMenuInfo = context.MenuInfo;
            return entitiesMenuInfo.Where(x => x.ParentID== ParentID).Select(o => o.MenuID);
        }

        /// <summary>
        /// 根据菜单ID返回菜单对象
        /// </summary>
        /// <param name="ID">菜单ID</param>
        public MenuInfo GetByID(int ID)
        {
            entitiesMenuInfo = context.MenuInfo;
            return entitiesMenuInfo.Where(x => x.MenuID == ID).FirstOrDefault();
        }

        /// <summary>
        /// 根据用户ID返回用户角色对象
        /// </summary>
        /// <param name="ID">用户ID</param>
        public IQueryable<UserRole> GetByUserID(string UserID)
        {
            return entitiesUserRole.Where(x => x.UserID.ToString() == UserID);
        }
    }
}
