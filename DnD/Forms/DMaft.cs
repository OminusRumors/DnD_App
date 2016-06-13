﻿using DnD_App;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnD
{
    public partial class DMaft : Form
    {
        Character npc1;
        Character npc2;
        Trap trap1;
        Trap trap2;
        public DMaft(DnDServer server, Game game)
        {
            InitializeComponent();
            int[] stats = new int[] { 4, 4, 4, 4, 4, 4 };
            npc1 = new Character("npc1", stats, 4, new Weapon(5, 2, 3, 2), 100);
            npc2 = new Character("npc2", stats, 5, new Weapon(6, 1, 2, 1), 100);
            trap1 = new Trap(0, 4, 2);
            trap2 = new Trap(1, 4, 2);
        }
    }
}
