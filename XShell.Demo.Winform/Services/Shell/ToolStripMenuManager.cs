﻿using System.Windows.Forms;
using XShell.Demo.Winform.Controls;
using XShell.Services;

namespace XShell.Demo.Winform.Services.Shell
{
    public class ToolStripMenuManager : AbstractMenuManager<XToolStripMenuItem>
    {
        private readonly MenuStrip menu;

        public ToolStripMenuManager(MenuStrip menu)
        {
            this.menu = menu;
        }

        #region Overrides of AbstractMenuManager<LightToolStripMenuItem>

        protected override XToolStripMenuItem CreateMenuItem(XToolStripMenuItem parent)
        {
            var item = new XToolStripMenuItem();
            
            if (parent == null)
                menu.Items.Add(item);
            else parent.DropDownItems.Add(item);

            return item;
        }

        protected override void DeleteMenuItem(XToolStripMenuItem parent, XToolStripMenuItem item)
        {
            if(parent == null)
                menu.Items.Remove(item);
            else parent.DropDownItems.Remove(item);
        }

        #endregion
    }
}
