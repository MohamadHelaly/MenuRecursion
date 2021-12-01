using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuRecursion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Menu> lstMenu = new List<Menu>()
        {

            new Menu() {Id =1, Title = "الرئيسية", Url = "home", OrderIndex =1, ParentId =1, Status= true},
            new Menu() {Id =2, Title = "حول الكلية", Url = "about", OrderIndex =2, ParentId =2, Status= true},
            new Menu() {Id =3, Title = "نبذه عن الكلية", Url = "aboutus", OrderIndex =1, ParentId =2, Status= true},
            new Menu() {Id =4, Title = "الرؤية", Url = "vision", OrderIndex =2, ParentId =2, Status= true},
            new Menu() {Id =5, Title = "الشؤون الاكاديمية", Url = "#", OrderIndex =3, ParentId =5, Status= true},
            new Menu() {Id =6, Title = "الدبلوم المهني المتوسط", Url = "#", OrderIndex =1, ParentId =5, Status= true},
            new Menu() {Id =7, Title = "الدبلوم المهني المتخصص", Url = "#", OrderIndex =2, ParentId =5, Status= true},
            new Menu() {Id =8, Title = "تخصص التجميل والعناية بالبشرة", Url = "#", OrderIndex =1, ParentId =6, Status= true},
            new Menu() {Id =9, Title = "تخصص تكنولوجيا المتحكمات الدقيقة", Url = "#", OrderIndex =2, ParentId =6, Status= true},
            new Menu() {Id =10, Title = "تخصص تكنولوجيا المتحكمات الدقيقة 1", Url = "#", OrderIndex =1, ParentId =9, Status= true},
            new Menu() {Id =11, Title = "تخصص تكنولوجيا المتحكمات الدقيقة 2", Url = "#", OrderIndex =2, ParentId =9, Status= true},

        };
        public List<Menu> FullMenuObject = new List<Menu>();

        private void btnDrawMenu_Click(object sender, EventArgs e)
        {
            FullMenuObject = new List<Menu>();
            txtMenu.Text = string.Empty;

            //Get Ordered List of Menu
            List<Menu> lstParentLevel01 = lstMenu.Where(x => x.Id == x.ParentId).ToList();
            foreach (var menu in lstParentLevel01)
            {
                Menu node = new Menu() { Id = menu.Id, Title = menu.Title, Url = menu.Url, ParentId = menu.ParentId, OrderIndex = menu.OrderIndex, Status = menu.Status };
                node.SubMenu = GetChilds(menu);
                FullMenuObject.Add(node);
            }

            //Draw Menu
            foreach (var menu in FullMenuObject)
            {
                txtMenu.AppendText(DrawMenu(menu, 1));
            }
        }

        public List<Menu> GetChilds(Menu menu)
        {
            List<Menu> result = new List<Menu>();
            List<Menu> subMenu = lstMenu.Where(x => x.ParentId == menu.Id && x.Id != menu.Id).ToList();
            foreach (var men in subMenu)
            {
                Menu newItem = new Menu() { Id = men.Id, Title = men.Title, Url = men.Url, ParentId = men.ParentId, OrderIndex = men.OrderIndex, Status = men.Status };
                result.Add(newItem);
                newItem.SubMenu = GetChilds(men);
            }
            return result;
        }

        public string DrawMenu(Menu menu, int level)
        {
            string prefix = string.Empty;
            for (int i = 0; i < level * level; i++)
                prefix += "-";
            prefix += ">";

            string result = "[Level:" + level.ToString() + "]" + prefix + menu.Title + System.Environment.NewLine;
            foreach (var subMenu in menu.SubMenu)
            {
                result += DrawMenu(subMenu, level += 1);
                level -= 1;
            }

            return result;
        }


    }
}
