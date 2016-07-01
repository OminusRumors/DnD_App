using DnD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnD
{
    public partial class DMpre : Form
    {
        IObject[,] storage;
        IObject tempHolder;
        List<Trap> traps = new List<Trap> { };
        int gridWidth=20;
        int gridHeight=11;
        SaveLoadCharacter slc = new SaveLoadCharacter();
        GameServer server;
        int spawny = 0;
        int spawnx = 0;
        EventHandler click;
        string background = null;

        public DMpre()
        {
            InitializeComponent();
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;

            server = new GameServer();
            lbHostIp.Text = server.GetLocalIPAddress();
            server.StartServer();

            storage = new IObject[gridWidth, gridHeight];
            pbGameGrid.Width = 900;
            pbGameGrid.Height = 495;
            pbGameGrid.Update();
            traps.Add(new Trap("Barricade", 0, true, false));
            traps.Add(new Trap("Pit", 20, true, true));
            traps.Add(new Trap("Pendulum", 5, false, true));
            foreach(Trap t in traps)
            {
                lbHazards.Items.Add(t.TrapId);
            }
           
            lbHazards.SetSelected(0, true);

            //int[] stats = new int[] { 4, 4, 4, 4, 4, 4 };
            //player1 = new Character("player1", stats, 10, new Weapon(10, 2, 3, 2), 200);
            //player2 = new Character("player2", stats, 11, new Weapon(10, 2, 3, 2), 300);
            //npc1 = new Character("npc1", stats, 4, new Weapon(5, 2, 3, 2), 100);
            //npc2 = new Character("npc2", stats, 5, new Weapon(6, 1, 2, 1), 100);
            //trap1 = new Trap(0, 4, 2);
            //trap2 = new Trap(1, 4, 2);
        }


        private void btnPlaceNPCs_Click(object sender, EventArgs e)
        {
            if(click != null)
                pbGameGrid.Click -= click;
            click = new EventHandler(pbGameGrid_Click);
            pbGameGrid.Click += click;
            Character c = slc.DeSerializeObject<Character>("../Debug/" + lbNPCs.SelectedItem.ToString());
            tempHolder = c;
            
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            /*
            Dictionary<Character, Point> charDict = new Dictionary<Character, Point>();
            charDict.Add(player1, new Point(50, 50));
            charDict.Add(player2, new Point(100, 50));

            Dictionary<Character, Point> npcDict = new Dictionary<Character, Point>();
            npcDict.Add(npc1, new Point(100, 100));
            npcDict.Add(npc2, new Point(50, 100));

            //Game game = new Game(charDict, npcDict, new Dictionary<Trap, Point> { { trap1, new Point(25, 25) } });
            //DMaft form = new DMaft(server, game);
            */
            
            server.Game.SetSpawn(spawnx,spawny);
            DMaft form = new DMaft(server.Game);
            form.Show();
        }

        private void btnAddNPC_Click(object sender, EventArgs e)
        {
            CharacterForm cf = new CharacterForm();
            cf.Show();
        }

        private void DMpre_Activated(object sender, EventArgs e)
        {
            lbNPCs.Items.Clear();
            string[] characters = Directory.GetFiles("../Debug", "*.char").Select(path => Path.GetFileName(path)).ToArray();
            foreach (var character in characters)
            {
                lbNPCs.Items.Add(character);
            }
            lbNPCs.SetSelected(0, true);
        }

        private void pbGameGrid_Click(object sender, EventArgs e)
        {
            var mouseClick = e as MouseEventArgs;
            int x = mouseClick.X;
            int y = mouseClick.Y;
            int gridx = x / 45;
            int gridy = y / 45;

            storage[gridx, gridy] = tempHolder;
            pbGameGrid.Invalidate();
        }

        private void pbGameGrid_Paint(object sender, PaintEventArgs e)
        {
            if (background != null)
            {
                Bitmap back = ResizeImage((Bitmap)Image.FromFile(background), Convert.ToInt32(pbGameGrid.Width*3.14), Convert.ToInt32(pbGameGrid.Height*3.14));
                e.Graphics.DrawImage(back, new Point(0, 0));
            }

            int width = pbGameGrid.Width;
            int height = pbGameGrid.Height;

            int cubeWidth = width / gridWidth;
            int cubeHeight = height / gridHeight;
            int i = 1;
            while (i<=gridWidth)
            {
                e.Graphics.DrawLine(new Pen(Color.Black, 1), new Point(cubeWidth * i, 0), new Point(cubeWidth * i, height));
                i++;
            }
            i = 1;
            while (i <= gridHeight)
            {
                e.Graphics.DrawLine(new Pen(Color.Black, 1), new Point(0, cubeHeight*i), new Point(width, cubeHeight*i));
                i++;
            }

            for(int j = 0;j<gridHeight;j++)
            {
                for(int k = 0; k<gridWidth;k++)
                {
                    if(storage[k, j] != null && storage[k,j].GetType() == typeof(Character))
                    {
                        Bitmap image = ResizeImage((Bitmap)Image.FromFile("../debug/finished/Warrior.bmp"),130,130);
                        e.Graphics.DrawImage(image,new Point(k*cubeWidth+1,j*cubeHeight+1));
                    }
                }
            }

            Bitmap spawn = ResizeImage((Bitmap)Image.FromFile("../debug/finished/Tent.bmp"), 130, 130);
            e.Graphics.DrawImage(spawn, new Point(spawnx * cubeWidth + 1, spawny * cubeHeight + 1));

            string path = "";
            for (int j = 0; j < gridHeight; j++)
            {
                for (int k = 0; k < gridWidth; k++)
                {
                    if (storage[k, j] != null && storage[k, j].GetType() == typeof(Trap))
                    {
                        Trap t = (Trap)storage[k, j];
                        switch (t.TrapId) {
                            case "Barricade":
                                path = "../debug/finished/Barricade.bmp";
                                    break;
                            case "Pit":
                                path = "../debug/finished/Pit.bmp";
                                break;
                            case "Pendulum":
                                path = "../debug/finished/Pendulum.bmp";
                                break;
                        }

                        Bitmap image = ResizeImage((Bitmap)Image.FromFile(path), 130, 130);
                        e.Graphics.DrawImage(image, new Point(k * cubeWidth + 1, j * cubeHeight + 1));
                    }
                }
            }

        }

        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        private void btnRemoveNPCs_Click(object sender, EventArgs e)
        {
            if (click != null)
                pbGameGrid.Click -= click;
            click = new EventHandler(pbGameGrid_Click);
            pbGameGrid.Click += click;
            tempHolder = null;
        }

        private void btnPlayerSpawn_Click(object sender, EventArgs e)
        {
            if (click != null)
                pbGameGrid.Click -= click;
            click = new EventHandler(Spawn_Click);
            pbGameGrid.Click += click;

        }

        private void Spawn_Click(object sender,EventArgs e)
        {
            var mouseClick = e as MouseEventArgs;
            int x = mouseClick.X;
            int y = mouseClick.Y;
            int gridx = x / 45;
            int gridy = y / 45;

            spawnx = gridx;
            spawny = gridy;
            pbGameGrid.Invalidate();
        }

        private void btnPlaceHazards_Click(object sender, EventArgs e)
        {
            if (click != null)
                pbGameGrid.Click -= click;
            click = new EventHandler(pbGameGrid_Click);
            pbGameGrid.Click += click;
            tempHolder = traps[lbHazards.SelectedIndex];
        }

        private void btnSelectMap_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                background = open.FileName;

            }
            pbGameGrid.Invalidate();
        }

        private void DMpre_Load(object sender, EventArgs e)
        {

        }
    }
}
