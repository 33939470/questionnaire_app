using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 问卷调查.BLL;

namespace 问卷调查.Business
{
    /// <summary>
    /// 菜单信息逻辑操作层
    /// </summary>
   public class MenuInfoOption
    {
        MainPageOptionBLL MainPageBLL = new MainPageOptionBLL();

        /// <summary>
        /// 根据用户ID返回菜单对象
        /// </summary>
        public List<MenuInfo> GetMenuByUserID(int UserID)
        {
            List<UserRole> userRoles = MainPageBLL.GetByUserID(UserID).AsNoTracking().ToList();
            List<MenuInfo> menus = new List<MenuInfo>();
            foreach (UserRole userRole in userRoles)
            {
                List<MenuInfo> menuList = GetMenuByRoleID(userRole.RoleTypeID);
                foreach (MenuInfo m in menuList)
                {
                    if (!menus.Contains(m))
                    {
                        menus.Add(m);
                    }
                }
            }
            return menus;
        }


        /// <summary>
        /// 根据角色ID返回菜单对象
        /// </summary>
        /// <param name="ID">角色ID</param>
        public List<MenuInfo> GetMenuByRoleID(int RoleTypeID)
        {
            List<int> MenuIDs = MainPageBLL.GetMenusByRoleID(RoleTypeID).ToList();
            List<MenuInfo> Menus = new List<MenuInfo>();
            foreach (int MenuID in MenuIDs)
            {
                MenuInfo m = MainPageBLL.GetByID(MenuID);
                Menus.Add(m);
            }
            return Menus;
        }
        /// <summary>
        /// 根据用户ID和上级菜单返回菜单对象
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <param name="MenuID">一级菜单ID</param>
        public List<MenuInfo> GetSubMenuByUserID(string UserID, string MenuID)
        {
            List<UserRole> userRoles = MainPageBLL.GetByUserID(UserID).AsNoTracking().ToList();
            List<MenuInfo> menus = new List<MenuInfo>();
            foreach (UserRole userRole in userRoles)
            {
                List<MenuInfo> menu = GetMenuByRoleID(userRole.RoleTypeID);
                foreach (MenuInfo m in menu)
                {
                    if (!menus.Contains(m) && m.MenuID.ToString() == MenuID)
                    {
                        menus.Add(m);
                    }
                }
            }
            return menus;
        }
        /// <summary>
        /// 根据菜单ID返回菜单对象
        /// </summary>
        /// <param name="ID">菜单ID</param>
        public MenuInfo GetMenuByMenuID(int ID)
        {
            return MainPageBLL.GetByID(ID);
        }
        /// <summary>
        /// 根据父级菜单ID返回菜单对象集合
        /// </summary>
        /// <param name="ID">角色ID</param>
        public List<MenuInfo> GetMenuByParentID(int ParentID)
        {
            List<int> MenuIDs = MainPageBLL.GetMenusByParentID(ParentID).ToList();
            List<MenuInfo> Menus = new List<MenuInfo>();
            foreach (int MenuID in MenuIDs)
            {
                MenuInfo m = MainPageBLL.GetByID(MenuID);
                Menus.Add(m);
            }
            return Menus;
        }
      


    }
}
