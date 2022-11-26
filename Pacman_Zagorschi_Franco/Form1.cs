using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pacman_Zagorschi_Franco
{
    public partial class Form1 : Form
    {
        //dichiarazione variabili
        public int leftghost1, leftghost2, leftghost3, leftghost4, left;
        public int topghost1, topghost2, topghost3, topghost4, top;
        public int next, direzione, temp = 1;
        public bool pacturn, ghost1turn, ghost2turn, ghost3turn, ghost4turn, start, ghost1puomangiare, ghost2puomangiare, ghost3puomangiare, ghost4puomangiare, g1mangiato, g2mangiato, g3mangiato, g4mangiato;
        public bool dir1, dir2, dir3, dir4, c, Supermod, Supermod1, Supermod2, Supermod3, Supermod4, v1, v2, v3, v4, tresec = true;
        public int random1, random2, random3, random4, vita = 3, tic4, tic5, tic6, point;

        private void label254_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label255_Click(object sender, EventArgs e)
        {

        }

        private void label254_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label142_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        public int prec1, prec2, prec3, prec4, startdirection = 1, ghost1velocity = 2, ghost2velocity = 2, ghost3velocity = 2, ghost4velocity = 2;
        public Random rand = new Random();
        public List<object> oggetti = new List<object>();
        //fine dichiarazione variabili

        //inizializzazione della Form1
        public Form1()
        {
            InitializeComponent();
            oggetti.Add(label4);
            oggetti.Add(label5);
            oggetti.Add(label6);
            oggetti.Add(label7);
            oggetti.Add(label8);
            oggetti.Add(label9);
            oggetti.Add(label10);
            oggetti.Add(label11);
            oggetti.Add(label12);
            oggetti.Add(label13);
            oggetti.Add(label14);
            oggetti.Add(label15);
            oggetti.Add(label16);
            oggetti.Add(label17);
            oggetti.Add(label18);
            oggetti.Add(label19);
            oggetti.Add(label20);
            oggetti.Add(label21);
            oggetti.Add(label22);
            oggetti.Add(label23);
            oggetti.Add(label24);
            oggetti.Add(label25);
            oggetti.Add(label26);
            oggetti.Add(label27);
            oggetti.Add(label28);
            oggetti.Add(label29);
            oggetti.Add(label30);
            oggetti.Add(label31);
            oggetti.Add(label32);
            oggetti.Add(label33);
            oggetti.Add(label34);
            oggetti.Add(label35);
            oggetti.Add(label36);
            oggetti.Add(label37);
            oggetti.Add(label38);
            oggetti.Add(label39);
            oggetti.Add(label40);
            oggetti.Add(label41);
            oggetti.Add(label42);
            oggetti.Add(label43);
            oggetti.Add(label44);
            oggetti.Add(label45);
            oggetti.Add(label46);
            oggetti.Add(label47);
            oggetti.Add(label48);
            oggetti.Add(label49);
            oggetti.Add(label50);
            oggetti.Add(label51);
            oggetti.Add(label52);
            oggetti.Add(label53);
            oggetti.Add(label54);
            oggetti.Add(label55);
            oggetti.Add(label56);
            oggetti.Add(label57);
            oggetti.Add(label58);
            oggetti.Add(label59);
            oggetti.Add(label60);
            oggetti.Add(label61);
            oggetti.Add(label62);
            oggetti.Add(label63);
            oggetti.Add(label64);
            oggetti.Add(label65);
            oggetti.Add(label66);
            oggetti.Add(label67);
            oggetti.Add(label68);
            oggetti.Add(label69);
            oggetti.Add(label70);
            oggetti.Add(label71);
            oggetti.Add(label72);
            oggetti.Add(label73);
            oggetti.Add(label74);
            oggetti.Add(label75);
            oggetti.Add(label76);
            oggetti.Add(label77);
            oggetti.Add(label78);
            oggetti.Add(label79);
            oggetti.Add(label80);
            oggetti.Add(label81);
            oggetti.Add(label82);
            oggetti.Add(label83);
            oggetti.Add(label84);
            oggetti.Add(label85);
            oggetti.Add(label86);
            oggetti.Add(label87);
            oggetti.Add(label88);
            oggetti.Add(label89);
            oggetti.Add(label90);
            oggetti.Add(label91);
            oggetti.Add(label92);
            oggetti.Add(label93);
            oggetti.Add(label94);
            oggetti.Add(label95);
            oggetti.Add(label96);
            oggetti.Add(label97);
            oggetti.Add(label98);
            oggetti.Add(label99);
            oggetti.Add(label100);
            oggetti.Add(label101);
            oggetti.Add(label102);
            oggetti.Add(label103);
            oggetti.Add(label104);
            oggetti.Add(label105);
            oggetti.Add(label106);
            oggetti.Add(label107);
            oggetti.Add(label108);
            oggetti.Add(label109);
            oggetti.Add(label110);
            oggetti.Add(label111);
            oggetti.Add(label112);
            oggetti.Add(label113);
            oggetti.Add(label114);
            oggetti.Add(label115);
            oggetti.Add(label116);
            oggetti.Add(label117);
            oggetti.Add(label118);
            oggetti.Add(label119);
            oggetti.Add(label120);
            oggetti.Add(label121);
            oggetti.Add(label122);
            oggetti.Add(label123);
            oggetti.Add(label125);
            oggetti.Add(label126);
            oggetti.Add(label127);
            oggetti.Add(label128);
            oggetti.Add(label129);
            oggetti.Add(label130);
            oggetti.Add(label131);
            oggetti.Add(label132);
            oggetti.Add(label133);
            oggetti.Add(label134);
            oggetti.Add(label135);
            oggetti.Add(label136);
            oggetti.Add(label137);
            oggetti.Add(label138);
            oggetti.Add(label139);
            oggetti.Add(label140);
            oggetti.Add(label143);
            oggetti.Add(label144);
            oggetti.Add(label145);
            oggetti.Add(label146);
            oggetti.Add(label147);
            oggetti.Add(label148);
            oggetti.Add(label149);
            oggetti.Add(label150);
            oggetti.Add(label151);
            oggetti.Add(label152);
            oggetti.Add(label153);
            oggetti.Add(label154);
            oggetti.Add(label155);
            oggetti.Add(label156);
            oggetti.Add(label157);
            oggetti.Add(label158);
            oggetti.Add(label159);
            oggetti.Add(label160);
            oggetti.Add(label161);
            oggetti.Add(label162);
            oggetti.Add(label163);
            oggetti.Add(label164);
            oggetti.Add(label165);
            oggetti.Add(label166);
            oggetti.Add(label167);
            oggetti.Add(label168);
            oggetti.Add(label169);
            oggetti.Add(label170);
            oggetti.Add(label171);
            oggetti.Add(label172);
            oggetti.Add(label173);
            oggetti.Add(label174);
            oggetti.Add(label175);
            oggetti.Add(label176);
            oggetti.Add(label177);
            oggetti.Add(label178);
            oggetti.Add(label179);
            oggetti.Add(label180);
            oggetti.Add(label181);
            oggetti.Add(label182);
            oggetti.Add(label183);
            oggetti.Add(label184);
            oggetti.Add(label185);
            oggetti.Add(label186);
            oggetti.Add(label187);
            oggetti.Add(label188);
            oggetti.Add(label189);
            oggetti.Add(label190);
            oggetti.Add(label191);
            oggetti.Add(label192);
            oggetti.Add(label193);
            oggetti.Add(label194);
            oggetti.Add(label195);
            oggetti.Add(label196);
            oggetti.Add(label197);
            oggetti.Add(label198);
            oggetti.Add(label199);
            oggetti.Add(label200);
            oggetti.Add(label201);
            oggetti.Add(label202);
            oggetti.Add(label203);
            oggetti.Add(label204);
            oggetti.Add(label205);
            oggetti.Add(label206);
            oggetti.Add(label207);
            oggetti.Add(label208);
            oggetti.Add(label209);
            oggetti.Add(label210);
            oggetti.Add(label211);
            oggetti.Add(label212);
            oggetti.Add(label213);
            oggetti.Add(label214);
            oggetti.Add(label215);
            oggetti.Add(label216);
            oggetti.Add(label217);
            oggetti.Add(label218);
            oggetti.Add(label219);
            oggetti.Add(label220);
            oggetti.Add(label221);
            oggetti.Add(label222);
            oggetti.Add(label223);
            oggetti.Add(label224);
            oggetti.Add(label225);
            oggetti.Add(label226);
            oggetti.Add(label227);
            oggetti.Add(label228);
            oggetti.Add(label229);
            oggetti.Add(label230);
            oggetti.Add(label231);
            oggetti.Add(label232);
            oggetti.Add(label233);
            oggetti.Add(label234);
            oggetti.Add(label235);
            oggetti.Add(label236);
            oggetti.Add(label237);
            oggetti.Add(label238);
            oggetti.Add(label239);
            oggetti.Add(label240);
            oggetti.Add(label241);
            oggetti.Add(label242);
            oggetti.Add(label243);
            oggetti.Add(label244);
            oggetti.Add(label245);
            oggetti.Add(label246);
            oggetti.Add(label247);
            oggetti.Add(label248);
            oggetti.Add(label249);
            oggetti.Add(label250);
            oggetti.Add(label251);
            oggetti.Add(label252);
            oggetti.Add(label256);
            oggetti.Add(label257);
            oggetti.Add(label258);
            oggetti.Add(label259);
            oggetti.Add(label260);
            oggetti.Add(label261);
            oggetti.Add(label262);
            oggetti.Add(label263);
            oggetti.Add(label264);
            oggetti.Add(label265);
            oggetti.Add(label266);
            oggetti.Add(label267);
            oggetti.Add(label268);
            oggetti.Add(label269);
            oggetti.Add(label270);
            oggetti.Add(label271);
            oggetti.Add(label272);
            oggetti.Add(label273);
            oggetti.Add(label274);
            oggetti.Add(label275);
            oggetti.Add(label276);
            oggetti.Add(label277);
            oggetti.Add(label278);
            oggetti.Add(label279);
            oggetti.Add(label280);
            oggetti.Add(label281);
            oggetti.Add(label282);
            oggetti.Add(label283);
            oggetti.Add(label284);
            oggetti.Add(label285);
            oggetti.Add(label286);
            oggetti.Add(label287);
            oggetti.Add(label288);
            oggetti.Add(label289);
            oggetti.Add(label290);
            oggetti.Add(label291);
            oggetti.Add(label292);
            oggetti.Add(label293);
            oggetti.Add(label294);
            oggetti.Add(label295);
            oggetti.Add(label296);
            oggetti.Add(label297);
            oggetti.Add(label298);
            oggetti.Add(label299);
            oggetti.Add(label300);
            oggetti.Add(label301);
            oggetti.Add(label302);
            oggetti.Add(label303);
            oggetti.Add(label304);
            oggetti.Add(label305);
            oggetti.Add(label306);
            oggetti.Add(label307);
            oggetti.Add(label308);
            oggetti.Add(label309);
            oggetti.Add(label310);
            oggetti.Add(label311);
            oggetti.Add(label312);
            oggetti.Add(label313);
            oggetti.Add(label314);
            oggetti.Add(label315);
            oggetti.Add(label316);
            oggetti.Add(label317);
            oggetti.Add(label318);
            oggetti.Add(label319);
            oggetti.Add(label320);
            oggetti.Add(label321);
            oggetti.Add(label322);
            oggetti.Add(label323);
            oggetti.Add(label324);
            oggetti.Add(label325);
            oggetti.Add(label326);
            oggetti.Add(label327);
            oggetti.Add(label328);
            oggetti.Add(label329);
            oggetti.Add(label330);
            oggetti.Add(label331);
            oggetti.Add(label332);
            oggetti.Add(label333);
            oggetti.Add(label334);
            oggetti.Add(label335);
            oggetti.Add(label336);
            oggetti.Add(label337);
            oggetti.Add(label338);
            oggetti.Add(label339);
            oggetti.Add(label340);
            oggetti.Add(label341);
        }

        //avvio del gioco
        public void button1_Click(object sender, EventArgs e)
        {
            start = true;
            life();
            points();
            panel1.Visible = false;
            resetall();
        }

        //input
        public void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) next = 1;
            if (e.KeyCode == Keys.Right) next = 2;
            if (e.KeyCode == Keys.Up) next = 3;
            if (e.KeyCode == Keys.Down) next = 4;
            if (e.KeyCode == Keys.Escape) Close();
            temp = next;
        }

        public System.Drawing.Bitmap Get_Button1_Image()
        {
            return (System.Drawing.Bitmap)button1.Image;
        }
        //stile bottone1
        public void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Image = Properties.Resources.playgame;
        }

        //stile bottone1
        public void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Image = Properties.Resources.playgame2;
        }

        //timer1
        public void timer1_Tick(object sender, EventArgs e)
        {
            if (pacman.Enabled)
            {
                direction();
                freedirection();
            }
            if (ghost1.Enabled || ghost2.Enabled || ghost3.Enabled || ghost4.Enabled)
            {
                ghost();
            }
            if (c) control();
            supermod();
            points();
            collision();
        }

        //timer2
        public void timer2_Tick(object sender, EventArgs e)
        {
            label3.Visible = false;
            timer1.Enabled = true;
            timer2.Enabled = false;
            c = true;
        }

        //Getter function to access Label3
        public Label getLabel3()
        {
            return label3;
        }

        //timer3
        public void timer3_Tick(object sender, EventArgs e)
        {
            if (ghost2.Top == 180) startdirection = 2;
            if (ghost2.Top == 192) startdirection = 1;
            if (startdirection == 1)
            {
                ghost2.Top--;
                ghost4.Top--;
            }
            if (startdirection == 2)
            {
                ghost2.Top++;
                ghost4.Top++;
            }
        }

        //timer4
        public void timer4_Tick(object sender, EventArgs e)
        {
            tic4++;
            if (ghost3.Top > 150 && tic4 > 100) { prec1 = 3; ghost3.Top--; }
            if (ghost3.Top == 150) timer4.Enabled = false;
        }

        //timer5
        public void timer5_Tick(object sender, EventArgs e)
        {
            tic5++;
            if (ghost2.Left > 153 && ghost2.Left < 176 && tic5 > 300) ghost2.Left++;
            if (ghost2.Top > 150 && ghost2.Left == 176) { ghost2.Top--; }
            if (ghost2.Top == 150) { timer6.Enabled = true; timer5.Enabled = false; }
        }

        //timer6
        public void timer6_Tick(object sender, EventArgs e)
        {
            tic6++;
            if (ghost4.Left > 176 && ghost4.Left < 200 && tic6 > 100) ghost4.Left--;
            if (ghost4.Top > 150 && ghost4.Left == 176) { ghost4.Top--; }
            if (ghost4.Top == 150) timer6.Enabled = false;
        }

        public void powermod_Tick(object sender, EventArgs e)
        {
            tresec = false;
            if (!g1mangiato)
            {
                v1 = false;
                ghost1puomangiare = true;
                Supermod1 = false;
                ghost1velocity = 2;
            }
            if (!g2mangiato)
            {
                v2 = false;
                ghost2puomangiare = true;
                Supermod2 = false;
                ghost2velocity = 2;
            }
            if (!g3mangiato)
            {
                v3 = false;
                ghost3puomangiare = true;
                Supermod3 = false;
                ghost3velocity = 2;
            }
            if (!g4mangiato)
            {
                v4 = false;
                ghost4puomangiare = true;
                Supermod4 = false;
                ghost4velocity = 2;
            }
            Supermod = false;
            powermod.Enabled = false;
            powermod1.Enabled = false;
            if (prec1 == 1 && !g1mangiato) { if (ghost1.Left % 2 == 0) leftghost1 = ghost1velocity; ghost1.Image = Properties.Resources.rdx; }
            if (prec1 == 2 && !g1mangiato) { if (ghost1.Left % 2 == 0) leftghost1 = -ghost1velocity; ghost1.Image = Properties.Resources.rsx; }
            if (prec1 == 3 && !g1mangiato) { if (ghost1.Top % 2 == 0) topghost1 = -ghost1velocity; ghost1.Image = Properties.Resources.rup; }
            if (prec1 == 4 && !g1mangiato) { if (ghost1.Top % 2 == 0) topghost1 = ghost1velocity; ghost1.Image = Properties.Resources.rdown; }

            if (prec2 == 1 && !g2mangiato) { if (ghost2.Left % 2 == 0) leftghost2 = ghost2velocity; ghost2.Image = Properties.Resources.adx; }
            if (prec2 == 2 && !g2mangiato) { if (ghost2.Left % 2 == 0) leftghost2 = -ghost2velocity; ghost2.Image = Properties.Resources.asx; }
            if (prec2 == 3 && !g2mangiato) { if (ghost2.Top % 2 == 0) topghost2 = -ghost2velocity; ghost2.Image = Properties.Resources.aup; }
            if (prec2 == 4 && !g2mangiato) { if (ghost2.Top % 2 == 0) topghost2 = ghost2velocity; ghost2.Image = Properties.Resources.adown; }

            if (prec3 == 1 && !g3mangiato) { if (ghost3.Left % 2 == 0) leftghost3 = ghost3velocity; ghost3.Image = Properties.Resources.vdx; }
            if (prec3 == 2 && !g3mangiato) { if (ghost3.Left % 2 == 0) leftghost3 = -ghost3velocity; ghost3.Image = Properties.Resources.vsx; }
            if (prec3 == 3 && !g3mangiato) { if (ghost3.Top % 2 == 0) topghost3 = -ghost3velocity; ghost3.Image = Properties.Resources.vup; }
            if (prec3 == 4 && !g3mangiato) { if (ghost3.Top % 2 == 0) topghost3 = ghost3velocity; ghost3.Image = Properties.Resources.vdown; }

            if (prec4 == 1 && !g4mangiato) { if (ghost4.Left % 2 == 0) leftghost4 = ghost4velocity; ghost4.Image = Properties.Resources.gdx; }
            if (prec4 == 2 && !g4mangiato) { if (ghost4.Left % 2 == 0) leftghost4 = -ghost4velocity; ghost4.Image = Properties.Resources.gsx; }
            if (prec4 == 3 && !g4mangiato) { if (ghost4.Top % 2 == 0) topghost4 = -ghost4velocity; ghost4.Image = Properties.Resources.gup; }
            if (prec4 == 4&& !g4mangiato) { if (ghost4.Top % 2 == 0) topghost4 = ghost4velocity; ghost1.Image = Properties.Resources.gdown; }
        }

        //timer8
        public void timer8_Tick(object sender, EventArgs e)
        {
            pacman.SetBounds(pacman.Left, pacman.Top, 0, 0);
            g1mangiato = false;
            g2mangiato = false;
            g3mangiato = false;
            g4mangiato = false;
            v1 = false;
            v2 = false;
            v3 = false;
            v4 = false;
            ghost1puomangiare = true;
            ghost2puomangiare = true;
            ghost3puomangiare = true;
            ghost4puomangiare = true;
            ghost1.Visible = false;
            ghost2.Visible = false;
            ghost3.Visible = false;
            ghost4.Visible = false;
            pacman.Visible = false;
            tic4 = 0;
            tic5 = 0;
            tic6 = 0;
            Supermod = false;
            Supermod1 = false;
            Supermod2 = false;
            Supermod3 = false;
            Supermod4 = false;
            ghost1velocity = 2;
            ghost2velocity = 2;
            ghost3velocity = 2;
            ghost4velocity = 2;
            vita--;
            life();
            prec1 = 0;
            prec2 = 0;
            prec3 = 0;
            prec4 = 0;
            startdirection = 1;
            dir1 = false;
            dir2 = false;
            dir3 = false;
            dir4 = false;
            c = false;
            next = 0;
            temp = 1;
            direzione = 0;
            pacman.Left = 24;
            pacman.Top = 364;
            ghost1.Left = 176;
            ghost1.Top = 150;
            ghost2.Left = 154;
            ghost2.Top = 185;
            ghost3.Left = 176;
            ghost3.Top = 185;
            ghost4.Left = 199;
            ghost4.Top = 185;
            leftghost1 = 0;
            leftghost2 = 0;
            leftghost3 = 0;
            leftghost4 = 0;
            topghost1 = 0;
            topghost2 = 0;
            topghost3 = 0;
            topghost4 = 0;
            left = 0;
            top = 0;
            timer8.Enabled = false;
            pacman.Image = Properties.Resources._1dx;
            ghost1.Image = Properties.Resources.rup;
            ghost2.Image = Properties.Resources.aup;
            ghost3.Image = Properties.Resources.vup;
            ghost4.Image = Properties.Resources.gup;
            ghost1.Visible = true;
            ghost2.Visible = true;
            ghost3.Visible = true;
            ghost4.Visible = true;
            pacman.SetBounds(pacman.Left, pacman.Top, 22, 22);
            pacman.Visible = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
            timer8.Interval = 1900;
        }

        public void timer9_Tick(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
            button1.Visible = true;
            timer9.Enabled = false;
        }

        public void resetall()
        {
            g1mangiato = false;
            g2mangiato = false;
            g3mangiato = false;
            g4mangiato = false;
            v1 = false;
            v2 = false;
            v3 = false;
            v4 = false;
            ghost1puomangiare = true;
            ghost2puomangiare = true;
            ghost3puomangiare = true;
            ghost4puomangiare = true;
            label124.Visible = false;
            label141.Visible = false;
            pacman.SetBounds(pacman.Left, pacman.Top, 22, 22);
            tic4 = 0;
            tic5 = 0;
            tic6 = 0;
            Supermod = false;
            Supermod1 = false;
            Supermod2 = false;
            Supermod3 = false;
            Supermod4 = false;
            ghost1velocity = 2;
            ghost2velocity = 2;
            ghost3velocity = 2;
            ghost4velocity = 2;
            life();
            prec1 = 0;
            prec2 = 0;
            prec3 = 0;
            prec4 = 0;
            startdirection = 1;
            dir1 = false;
            dir2 = false;
            dir3 = false;
            dir4 = false;
            c = false;
            next = 0;
            temp = 1;
            direzione = 0;
            pacman.Left = 24;
            pacman.Top = 364;
            ghost1.Left = 176;
            ghost1.Top = 150;
            ghost2.Left = 154;
            ghost2.Top = 185;
            ghost3.Left = 176;
            ghost3.Top = 185;
            ghost4.Left = 199;
            ghost4.Top = 185;
            leftghost1 = 0;
            leftghost2 = 0;
            leftghost3 = 0;
            leftghost4 = 0;
            topghost1 = 0;
            topghost2 = 0;
            topghost3 = 0;
            topghost4 = 0;
            left = 0;
            top = 0;
            pacman.Image = Properties.Resources._1dx;
            ghost1.Image = Properties.Resources.rup;
            ghost2.Image = Properties.Resources.aup;
            ghost3.Image = Properties.Resources.vup;
            ghost4.Image = Properties.Resources.gup;
            timer1.Enabled = false;
            timer4.Enabled = false;
            timer5.Enabled = false;
            timer6.Enabled = false;
            timer7.Enabled = false;
            timer8.Enabled = false;
            powermod.Enabled = false;
            powermod1.Enabled = false;
            if (start)
            {
                timer2.Enabled = true;
                timer3.Enabled = true;
            }
            start = false;
            for (int i = 0; i < 332; i++) ((Label)oggetti[i]).Visible = true;
        }
        //timer7
        public void timer7_Tick(object sender, EventArgs e)
        {
            timer7.Enabled = false;
            panel1.Visible = true;
            attendo.Enabled = true;
        }

        //timer attendo
        public void attendo_Tick(object sender, EventArgs e)
        {
            resetall();
            attendo.Enabled = false;
        }

        //movimento iniziale dei fantasmini
        public void control()
        {
            if (ghost2.Top == 185) { timer3.Enabled = false; timer4.Enabled = true; c = false; timer5.Enabled = true; }
        }

        // controllo delle vite
        public void life()
        {
            if (vita == 3)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
            }
            if (vita == 2)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
            }
            if (vita == 1)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
            }
        }
        public void supermod()
        {
            if (pacman.Bounds.IntersectsWith(label173.Bounds) && label173.Visible == true) supermod2();
            if (pacman.Bounds.IntersectsWith(label307.Bounds) && label307.Visible == true) supermod2();
            if (pacman.Bounds.IntersectsWith(label220.Bounds) && label220.Visible == true) supermod2();
            if (pacman.Bounds.IntersectsWith(label71.Bounds) && label71.Visible == true) supermod2();
        }
        public void supermod2()
        {
            if (!g1mangiato)
            {
                v1 = false;
                ghost1velocity = 2;
                Supermod1 = true;
                ghost1.Image = Properties.Resources.crazy;
                ghost1puomangiare = true;
            }
            if (!g2mangiato)
            {
                v2 = false;
                ghost2velocity = 2;
                Supermod2 = true;
                ghost2.Image = Properties.Resources.crazy;
                ghost2puomangiare = true;
            }
            if (!g3mangiato)
            {
                v3 = false;
                ghost3velocity = 2;
                Supermod3 = true;
                ghost3.Image = Properties.Resources.crazy;
                ghost3puomangiare = true;
            }
            if (!g4mangiato)
            {
                v4 = false;
                ghost4velocity = 2;
                Supermod4 = true;
                ghost4.Image = Properties.Resources.crazy;
                ghost4puomangiare = true;
            }
            powermod.Enabled = false;
            powermod1.Enabled = false;
            powermod1.Enabled = true;
            tresec = false;
            powermod.Enabled = true;
            Supermod = true;
        }
        public void powermod1_Tick(object sender, EventArgs e)
        {
            tresec = true;
            powermod1.Enabled = false;

        }
        //collisioni tra i personaggi
        public void collision()
        {
            if (pacman.Bounds.IntersectsWith(ghost1.Bounds) || pacman.Bounds.IntersectsWith(ghost2.Bounds) || pacman.Bounds.IntersectsWith(ghost3.Bounds) || pacman.Bounds.IntersectsWith(ghost4.Bounds))
            {
                if (pacman.Bounds.IntersectsWith(ghost1.Bounds) && !Supermod1) mangiato();
                if (pacman.Bounds.IntersectsWith(ghost2.Bounds) && !Supermod2) mangiato();
                if (pacman.Bounds.IntersectsWith(ghost3.Bounds) && !Supermod3) mangiato();
                if (pacman.Bounds.IntersectsWith(ghost4.Bounds) && !Supermod4) mangiato();
                if (Supermod)
                {
                    if (pacman.Bounds.IntersectsWith(ghost1.Bounds) && !Supermod1) mangiato(); 
                    if (pacman.Bounds.IntersectsWith(ghost2.Bounds) && !Supermod2) mangiato();
                    if (pacman.Bounds.IntersectsWith(ghost3.Bounds) && !Supermod3) mangiato();
                    if (pacman.Bounds.IntersectsWith(ghost4.Bounds) && !Supermod4) mangiato();
                }
                if (pacman.Bounds.IntersectsWith(ghost1.Bounds) && ghost1puomangiare && Supermod1)
                {
                    g1mangiato = true;
                    v1 = true;
                    ghost1puomangiare = false;
                    timer1.Enabled = false;
                    ghostmangiato.Enabled = true;
                    ghost1velocity = 4;
                }
                if (pacman.Bounds.IntersectsWith(ghost2.Bounds) && ghost2puomangiare && Supermod2)
                {
                    g2mangiato = true;
                    v2 = true;
                    ghost2puomangiare = false;
                    timer1.Enabled = false;
                    ghostmangiato.Enabled = true;
                    ghost2velocity = 4;
                }
                if (pacman.Bounds.IntersectsWith(ghost3.Bounds) && ghost3puomangiare && Supermod3)
                {
                    g3mangiato = true;
                    v3 = true;
                    ghost3puomangiare = false;
                    timer1.Enabled = false;
                    ghostmangiato.Enabled = true;
                    ghost3velocity = 4;
                }
                if (pacman.Bounds.IntersectsWith(ghost4.Bounds) && ghost4puomangiare && Supermod4)
                {
                    g4mangiato = true;
                    v4 = true;
                    ghost4puomangiare = false;
                    timer1.Enabled = false;
                    ghostmangiato.Enabled = true;
                    ghost4velocity = 4;
                }
            }
        }

        public void ghostmangiato_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            ghostmangiato.Enabled = false;
        }
        //pacman è stato mangiato
        public void mangiato()
        {
            pacman.Image = Properties.Resources.pacmorto;
            if (vita - 1 <= 0)
            {
                label124.Visible = true;
                finepartita();
            }
            else
            {
                top = 0;
                left = 0;
                topghost1 = 0;
                topghost2 = 0;
                topghost3 = 0;
                topghost4 = 0;
                leftghost1 = 0;
                leftghost2 = 0;
                leftghost3 = 0;
                leftghost4 = 0;
                timer1.Enabled = false;
                timer4.Enabled = false;
                timer5.Enabled = false;
                timer6.Enabled = false;
                pacturn = false;
                ghost1turn = false;
                ghost2turn = false;
                ghost3turn = false;
                ghost4turn = false;
                timer8.Enabled = true;
            }
        }

        //controllo dei punti
        public void points()
        {
            for (int i = 0; i < 332; i++)
            {
                if (((Label)oggetti[i]).Visible == true && pacman.Bounds.IntersectsWith(((Label)oggetti[i]).Bounds))
                {
                    point += 1;
                    ((Label)oggetti[i]).Visible = false;
                }
            }
            score.Text = point.ToString();
            if (point >= 332) { finepartita(); label141.Visible = true; }
        }

        //fine partita
        public void finepartita()
        {
            point = 0;
            vita = 3;
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = false;
            timer5.Enabled = false;
            timer6.Enabled = false;
            powermod1.Enabled = false;
            powermod.Enabled = false;
            timer7.Enabled = true;
        }
        //cambio direzione di pacman
        public void freedirection()
        {
            switch (direzione)
            {
                case 1:
                    if (next == 2)
                    {
                        left = 2;
                        pacman.Image = Properties.Resources.pacdx;
                        direzione = next;
                        temp = next;
                    }
                    break;

                case 2:
                    if (next == 1)
                    {
                        left = -2;
                        pacman.Image = Properties.Resources.pacsx;
                        direzione = next;
                        temp = next;
                    }
                    break;

                case 3:
                    if (next == 4)
                    {
                        top = 2;
                        pacman.Image = Properties.Resources.pacdown;
                        direzione = next;
                        temp = next;
                    }
                    break;

                case 4:
                    if (next == 3)
                    {
                        top = -2;
                        pacman.Image = Properties.Resources.pacup;
                        direzione = next;
                        temp = next;
                    }
                    break;
            }
        }
        //cambio direzione dei fantasmini e pacman
        public void leftright(int i, int y, int n, int m)
        {
            //turno di ghost1
            if (ghost1turn)
            {
                if (Supermod1 && !ghost1puomangiare)
                {
                    if (ghost1.Left < 180 && ghost1.Top == 150 || ghost1.Left > 170 && ghost1.Top == 150) { ghost1velocity = 2; Supermod1 = false; v1 = false; ghost1puomangiare = true; g1mangiato = false; }
                    else
                    {
                        if (ghost1.Top < 150) { if (n == 1 && m == 1) n = 0; }
                        if (ghost1.Top > 150) { if (n == 1 && m == 1) m = 0; }
                        if (ghost1.Left < 176) { if (i == 1 && y == 1) i = 0; }
                        if (ghost1.Left > 176) { if (i == 1 && y == 1) y = 0; }
                    }
                }
                topghost1 = 0;
                leftghost1 = 0;
                while (!dir1)
                {
                    random1 = rand.Next(1, 5);
                    if (random1 == 1 && !dir1 && random1 != prec1) if (i == 1) { leftghost1 = -ghost1velocity; dir1 = true; if (!Supermod1 && ghost1puomangiare) ghost1.Image = Properties.Resources.rsx; else if (!tresec || g1mangiato) { if (!tresec) ghost1.Image = Properties.Resources.crazy; if(g1mangiato) ghost1.Image = Properties.Resources.msx; } else ghost1.Image = Properties.Resources.tempo; }
                    if (random1 == 2 && !dir1 && random1 != prec1) if (y == 1) { leftghost1 = ghost1velocity; dir1 = true; if (!Supermod1 && ghost1puomangiare) ghost1.Image = Properties.Resources.rdx; else if (!tresec || g1mangiato) { if (!tresec) ghost1.Image = Properties.Resources.crazy; if (g1mangiato) ghost1.Image = Properties.Resources.mdx; } else ghost1.Image = Properties.Resources.tempo; }
                    if (random1 == 3 && !dir1 && random1 != prec1) if (m == 1) { topghost1 = ghost1velocity; dir1 = true; if (!Supermod1 && ghost1puomangiare) ghost1.Image = Properties.Resources.rdown; else if (!tresec || g1mangiato) { if (!tresec) ghost1.Image = Properties.Resources.crazy; if (g1mangiato) ghost1.Image = Properties.Resources.mdown; } else ghost1.Image = Properties.Resources.tempo; }
                    if (random1 == 4 && !dir1 && random1 != prec1) if (n == 1) { topghost1 = -ghost1velocity; dir1 = true; if (!Supermod1 && ghost1puomangiare ) ghost1.Image = Properties.Resources.rup; else if (!tresec || g1mangiato) { if (!tresec) ghost1.Image = Properties.Resources.crazy; if (g1mangiato) ghost1.Image = Properties.Resources.mup1; } else ghost1.Image = Properties.Resources.tempo; }
                }
                if (random1 == 1) prec1 = 2;
                if (random1 == 2) prec1 = 1;
                if (random1 == 3) prec1 = 4;
                if (random1 == 4) prec1 = 3;
                dir1 = false;
            }
            //turno di ghost2
            if (ghost2turn)
            {
                if (Supermod2 && !ghost2puomangiare)
                {
                    if (ghost2.Left < 180 && ghost2.Top == 150 || ghost2.Left > 170 && ghost2.Top == 150) { ghost2velocity = 2; Supermod2 = false; v2 = false; ghost2puomangiare = true; g2mangiato = false; }
                    else
                    {
                        if (ghost2.Top < 150) { if (n == 1 && m == 1) n = 0; }
                        if (ghost2.Top > 150) { if (n == 1 && m == 1) m = 0; }
                        if (ghost2.Left < 176) { if (i == 1 && y == 1) i = 0; }
                        if (ghost2.Left > 176) { if (i == 1 && y == 1) y = 0; }
                    }
                }
                topghost2 = 0;
                leftghost2 = 0;
                while (!dir2)
                {
                    random2 = rand.Next(1, 5);
                    if (random2 == 1 && !dir2 && random2 != prec2) if (i == 1) { leftghost2 = -ghost2velocity; dir2 = true; if (!Supermod2 && ghost2puomangiare ) ghost2.Image = Properties.Resources.asx; else if(!tresec || g2mangiato) { if (!tresec) ghost2.Image = Properties.Resources.crazy; if (g2mangiato) ghost2.Image = Properties.Resources.msx; } else ghost2.Image = Properties.Resources.tempo; }
                    if (random2 == 2 && !dir2 && random2 != prec2) if (y == 1) { leftghost2 = ghost2velocity; dir2 = true; if (!Supermod2 && ghost2puomangiare ) ghost2.Image = Properties.Resources.adx; else if (!tresec || g2mangiato) { if (!tresec) ghost2.Image = Properties.Resources.crazy; if (g2mangiato) ghost2.Image = Properties.Resources.mdx; } else ghost2.Image = Properties.Resources.tempo; }
                    if (random2 == 3 && !dir2 && random2 != prec2) if (m == 1) { topghost2 = ghost2velocity; dir2 = true; if (!Supermod2 && ghost2puomangiare ) ghost2.Image = Properties.Resources.adown; else if (!tresec || g2mangiato) { if (!tresec) ghost2.Image = Properties.Resources.crazy; if (g2mangiato) ghost2.Image = Properties.Resources.mdown; } else ghost2.Image = Properties.Resources.tempo; }
                    if (random2 == 4 && !dir2 && random2 != prec2) if (n == 1) { topghost2 = -ghost2velocity; dir2 = true; if (!Supermod2 && ghost2puomangiare ) ghost2.Image = Properties.Resources.aup; else if (!tresec || g2mangiato) { if (!tresec) ghost2.Image = Properties.Resources.crazy; if (g2mangiato) ghost2.Image = Properties.Resources.mup1; } else ghost2.Image = Properties.Resources.tempo; }
                }
                if (random2 == 1) prec2 = 2;
                if (random2 == 2) prec2 = 1;
                if (random2 == 3) prec2 = 4;
                if (random2 == 4) prec2 = 3;
                dir2 = false;
            }
            //turno di ghost3
            if (ghost3turn)
            {
                if (Supermod3 && !ghost3puomangiare)
                {
                    if (ghost3.Left < 180 && ghost3.Top == 150 || ghost3.Left > 170 && ghost3.Top == 150) { ghost3velocity = 2; Supermod3 = false; v3 = false; ghost3puomangiare = true; g3mangiato = false; }
                    else
                    {
                        if (ghost3.Top > 150) { if (n == 1 && m == 1) m = 0; }
                        if (ghost3.Top < 150) { if (n == 1 && m == 1) n = 0; }
                        if (ghost3.Left < 176) { if (i == 1 && y == 1) i = 0; }
                        if (ghost3.Left > 176) { if (i == 1 && y == 1) y = 0; }
                    }
                }
                topghost3 = 0;
                leftghost3 = 0;
                while (!dir3)
                {
                    random3 = rand.Next(1, 5);
                    if (random3 == 1 && !dir3 && random3 != prec3) if (i == 1) { leftghost3 = -ghost3velocity; dir3 = true; if (!Supermod3 && ghost3puomangiare) ghost3.Image = Properties.Resources.vsx; else if (!tresec || g3mangiato) { if (!tresec) ghost3.Image = Properties.Resources.crazy; if (g3mangiato) ghost3.Image = Properties.Resources.msx; } else ghost3.Image = Properties.Resources.tempo; }
                    if (random3 == 2 && !dir3 && random3 != prec3) if (y == 1) { leftghost3 = ghost3velocity; dir3 = true; if (!Supermod3 && ghost3puomangiare) ghost3.Image = Properties.Resources.vdx; else if (!tresec || g3mangiato) { if (!tresec) ghost3.Image = Properties.Resources.crazy; if (g3mangiato) ghost3.Image = Properties.Resources.mdx; } else ghost3.Image = Properties.Resources.tempo; }
                    if (random3 == 3 && !dir3 && random3 != prec3) if (m == 1) { topghost3 = ghost3velocity; dir3 = true; if (!Supermod3 && ghost3puomangiare) ghost3.Image = Properties.Resources.vdown; else if(!tresec || g3mangiato) { if (!tresec) ghost3.Image = Properties.Resources.crazy; if (g3mangiato) ghost3.Image = Properties.Resources.mdown; } else ghost3.Image = Properties.Resources.tempo; }
                    if (random3 == 4 && !dir3 && random3 != prec3) if (n == 1) { topghost3 = -ghost3velocity; dir3 = true; if (!Supermod3 && ghost3puomangiare) ghost3.Image = Properties.Resources.vup; else if (!tresec || g3mangiato) { if (!tresec) ghost3.Image = Properties.Resources.crazy; if (g3mangiato) ghost3.Image = Properties.Resources.mup1; } else ghost3.Image = Properties.Resources.tempo; }
                }
                if (random3 == 1) prec3 = 2;
                if (random3 == 2) prec3 = 1;
                if (random3 == 3) prec3 = 4;
                if (random3 == 4) prec3 = 3;
                dir3 = false;
            }
            //turno di ghost4
            if (ghost4turn)
            {
                if (Supermod4 && !ghost4puomangiare)
                {
                    if (ghost4.Left < 180 && ghost4.Top == 150 || ghost4.Left > 170 && ghost4.Top == 150) { ghost4velocity = 2; Supermod4 = false; v4 = false; ghost4puomangiare = true; g4mangiato = false; }
                    else
                    {
                        if (ghost4.Top > 150) { if (n == 1 && m == 1) m = 0; }
                        if (ghost4.Top < 150) { if (n == 1 && m == 1) n = 0; }
                        if (ghost4.Left < 176) { if (i == 1 && y == 1) i = 0; }
                        if (ghost4.Left > 176) { if (i == 1 && y == 1) y = 0; }
                    }
                }
                topghost4 = 0;
                leftghost4 = 0;
                while (!dir4)
                {
                    random4 = rand.Next(1, 5);
                    if (random4 == 1 && !dir4 && random4 != prec4) if (i == 1) { leftghost4 = -ghost4velocity; dir4 = true; if (!Supermod4 && ghost4puomangiare) ghost4.Image = Properties.Resources.gsx; else if (!tresec || g4mangiato) { if (!tresec) ghost4.Image = Properties.Resources.crazy; if (g4mangiato) ghost4.Image = Properties.Resources.msx; } else ghost4.Image = Properties.Resources.tempo; }
                    if (random4 == 2 && !dir4 && random4 != prec4) if (y == 1) { leftghost4 = ghost4velocity; dir4 = true; if (!Supermod4 && ghost4puomangiare) ghost4.Image = Properties.Resources.gdx; else if (!tresec || g4mangiato) { if (!tresec) ghost4.Image = Properties.Resources.crazy; if (g4mangiato) ghost4.Image = Properties.Resources.mdx; } else ghost4.Image = Properties.Resources.tempo; }
                    if (random4 == 3 && !dir4 && random4 != prec4) if (m == 1) { topghost4 = ghost4velocity; dir4 = true; if (!Supermod4 && ghost4puomangiare) ghost4.Image = Properties.Resources.gdown; else if (!tresec || g4mangiato) { if (!tresec) ghost4.Image = Properties.Resources.crazy; if (g4mangiato) ghost4.Image = Properties.Resources.mdown; } else ghost4.Image = Properties.Resources.tempo; }
                    if (random4 == 4 && !dir4 && random4 != prec4) if (n == 1) { topghost4 = -ghost4velocity; dir4 = true; if (!Supermod4 && ghost4puomangiare) ghost4.Image = Properties.Resources.gup; else if (!tresec || g4mangiato) { if (!tresec) ghost4.Image = Properties.Resources.crazy; if (g4mangiato) ghost4.Image = Properties.Resources.mup1; } else ghost4.Image = Properties.Resources.tempo; }
                }
                if (random4 == 1) prec4 = 2;
                if (random4 == 2) prec4 = 1;
                if (random4 == 3) prec4 = 4;
                if (random4 == 4) prec4 = 3;
                dir4 = false;
            }
            //turno di pacman
            if (pacturn)
            {
                top = 0;
                left = 0;
                if (temp == 1 && i == 1 || temp == 2 && y == 1 || temp == 3 && n == 1 || temp == 4 && m == 1)
                {
                    next = temp;
                }
                if (next == 1 && i == 1)
                {
                    left = -2;
                    pacman.Image = Properties.Resources.pacsx;
                    direzione = next;
                }
                if (next == 2 && y == 1)
                {
                    left = 2;
                    pacman.Image = Properties.Resources.pacdx;
                    direzione = next;
                }
                if (next == 3 && n == 1)
                {
                    top = -2;
                    pacman.Image = Properties.Resources.pacup;
                    direzione = next;
                }
                if (next == 4 && m == 1)
                {
                    top = 2;
                    pacman.Image = Properties.Resources.pacdown;
                    direzione = next;
                }
                if (top == 0 && left == 0)
                {
                    temp = next;
                    next = direzione;
                    if (next == 1) pacman.Image = Properties.Resources._1sx;
                    if (next == 2) pacman.Image = Properties.Resources._1dx;
                    if (next == 3) pacman.Image = Properties.Resources._1up;
                    if (next == 4) pacman.Image = Properties.Resources._1down;
                }
            }
        }

        //effettivo cambio direzione di pacman
        public void direction()
        {
            pacturn = true;
            a(pacman.Left, pacman.Top);
            pacman.Left += left;
            pacman.Top += top;
        }

        //Getter function to access Pacman
        public PictureBox getPacman()
        {
            return pacman;
        }

        //incrocio sulla mappa
        public void a(int left, int top)
        {
            if (pacturn)
            {
                switch (left)
                {
                    case 174:
                        if (top == 148) { leftright(1, 1, 0, 0); break; }
                        break;
                    case 24:
                        if (top == 364) { leftright(0, 1, 1, 0); break; }
                        if (top == 328) { leftright(0, 1, 0, 1); break; }
                        if (top == 292) { leftright(0, 1, 1, 0); break; }
                        if (top == 256) { leftright(0, 1, 0, 1); break; }
                        if (top == 112) { leftright(0, 1, 1, 0); break; }
                        if (top == 76) { leftright(0, 1, 1, 1); break; }
                        if (top == 28) { leftright(0, 1, 0, 1); break; }
                        break;
                    case 48:
                        if (top == 328) { leftright(1, 1, 1, 0); break; }
                        if (top == 292) { leftright(1, 0, 0, 1); break; }
                        break;
                    case 84:
                        if (top == 256) { leftright(1, 1, 1, 1); break; }
                        if (top == 328) { leftright(1, 0, 1, 0); break; }
                        if (top == 292) { leftright(0, 1, 1, 1); break; }
                        if (top == 184) { leftright(1, 1, 1, 1); break; }
                        if (top == 112) { leftright(1, 0, 1, 1); break; }
                        if (top == 28) { leftright(1, 1, 0, 1); break; }
                        if (top == 76) { leftright(1, 1, 1, 1); break; }
                        break;
                    case 120:
                        if (top == 292) { leftright(1, 1, 0, 1); break; }
                        if (top == 328) { leftright(0, 1, 1, 0); break; }
                        if (top == 256) { leftright(1, 1, 1, 0); break; }
                        if (top == 220) { leftright(0, 1, 1, 1); break; }
                        if (top == 76) { leftright(1, 1, 0, 1); break; }
                        if (top == 112) { leftright(0, 1, 1, 0); break; }
                        if (top == 148) { leftright(0, 1, 0, 1); break; }
                        if (top == 184) { leftright(1, 0, 1, 1); break; }
                        break;
                    case 156:
                        if (top == 328) { leftright(1, 0, 0, 1); break; }
                        if (top == 364) { leftright(1, 1, 1, 0); break; }
                        if (top == 256) { leftright(1, 0, 0, 1); break; }
                        if (top == 292) { leftright(1, 1, 1, 0); break; }
                        if (top == 76) { leftright(1, 1, 1, 0); break; }
                        if (top == 112) { leftright(1, 0, 0, 1); break; }
                        if (top == 148) { leftright(1, 1, 1, 0); break; }
                        if (top == 28) { leftright(1, 0, 0, 1); break; }
                        break;
                    case 192:
                        if (top == 292) { leftright(1, 1, 1, 0); break; }
                        if (top == 256) { leftright(0, 1, 0, 1); break; }
                        if (top == 364) { leftright(1, 1, 1, 0); break; }
                        if (top == 328) { leftright(0, 1, 0, 1); break; }
                        if (top == 28) { leftright(0, 1, 0, 1); break; }
                        if (top == 76) { leftright(1, 1, 1, 0); break; }
                        if (top == 112) { leftright(0, 1, 0, 1); break; }
                        if (top == 148) { leftright(1, 1, 1, 0); break; }
                        break;
                    case 228:
                        if (top == 256) { leftright(1, 1, 1, 0); break; }
                        if (top == 328) { leftright(1, 0, 1, 0); break; }
                        if (top == 292) { leftright(1, 1, 0, 1); break; }
                        if (top == 220) { leftright(1, 0, 1, 1); break; }
                        if (top == 184) { leftright(0, 1, 1, 1); break; }
                        if (top == 76) { leftright(1, 1, 0, 1); break; }
                        if (top == 112) { leftright(1, 0, 1, 0); break; }
                        if (top == 148) { leftright(1, 0, 0, 1); break; }
                        break;
                    case 264:
                        if (top == 256) { leftright(1, 1, 1, 1); break; }
                        if (top == 292) { leftright(1, 0, 1, 1); break; }
                        if (top == 328) { leftright(0, 1, 1, 0); break; }
                        if (top == 184) { leftright(1, 1, 1, 1); break; }
                        if (top == 112) { leftright(0, 1, 1, 1); break; }
                        if (top == 28) { leftright(1, 1, 0, 1); break; }
                        if (top == 76) { leftright(1, 1, 1, 1); break; }
                        break;
                    case 324:
                        if (top == 256) { leftright(1, 0, 0, 1); break; }
                        if (top == 292) { leftright(1, 0, 1, 0); break; }
                        if (top == 328) { leftright(1, 0, 0, 1); break; }
                        if (top == 364) { leftright(1, 0, 1, 0); break; }
                        if (top == 112) { leftright(1, 0, 1, 0); break; }
                        if (top == 76) { leftright(1, 0, 1, 1); break; }
                        if (top == 28) { leftright(1, 0, 0, 1); break; }
                        break;
                    case 300:
                        if (top == 292) { leftright(0, 1, 0, 1); break; }
                        if (top == 328) { leftright(1, 1, 1, 0); break; }
                        break;
                    case 374:
                        if (top == 184) { transport(0, 1); break; }
                        break;
                    case -26:
                        if (top == 184) { transport(1, 0); break; }
                        break;
                }
            }
            else
            {
                switch (left)
                {
                    case 176:
                        if (top == 150) { leftright(1, 1, 0, 0); break; }
                        break;
                    case 26:
                        if (top == 366) { leftright(0, 1, 1, 0); break; }
                        if (top == 330) { leftright(0, 1, 0, 1); break; }
                        if (top == 294) { leftright(0, 1, 1, 0); break; }
                        if (top == 258) { leftright(0, 1, 0, 1); break; }
                        if (top == 114) { leftright(0, 1, 1, 0); break; }
                        if (top == 78) { leftright(0, 1, 1, 1); break; }
                        if (top == 30) { leftright(0, 1, 0, 1); break; }
                        break;
                    case 50:
                        if (top == 330) { leftright(1, 1, 1, 0); break; }
                        if (top == 294) { leftright(1, 0, 0, 1); break; }
                        break;
                    case 86:
                        if (top == 258) { leftright(1, 1, 1, 1); break; }
                        if (top == 330) { leftright(1, 0, 1, 0); break; }
                        if (top == 294) { leftright(0, 1, 1, 1); break; }
                        if (top == 186) { leftright(1, 1, 1, 1); break; }
                        if (top == 114) { leftright(1, 0, 1, 1); break; }
                        if (top == 30) { leftright(1, 1, 0, 1); break; }
                        if (top == 78) { leftright(1, 1, 1, 1); break; }
                        break;
                    case 122:
                        if (top == 294) { leftright(1, 1, 0, 1); break; }
                        if (top == 330) { leftright(0, 1, 1, 0); break; }
                        if (top == 258) { leftright(1, 1, 1, 0); break; }
                        if (top == 222) { leftright(0, 1, 1, 1); break; }
                        if (top == 78) { leftright(1, 1, 0, 1); break; }
                        if (top == 114) { leftright(0, 1, 1, 0); break; }
                        if (top == 150) { leftright(0, 1, 0, 1); break; }
                        if (top == 186) { leftright(1, 0, 1, 1); break; }
                        break;
                    case 158:
                        if (top == 330) { leftright(1, 0, 0, 1); break; }
                        if (top == 366) { leftright(1, 1, 1, 0); break; }
                        if (top == 258) { leftright(1, 0, 0, 1); break; }
                        if (top == 294) { leftright(1, 1, 1, 0); break; }
                        if (top == 78) { leftright(1, 1, 1, 0); break; }
                        if (top == 114) { leftright(1, 0, 0, 1); break; }
                        if (top == 150) { leftright(1, 1, 1, 0); break; }
                        if (top == 30) { leftright(1, 0, 0, 1); break; }
                        break;
                    case 194:
                        if (top == 294) { leftright(1, 1, 1, 0); break; }
                        if (top == 258) { leftright(0, 1, 0, 1); break; }
                        if (top == 366) { leftright(1, 1, 1, 0); break; }
                        if (top == 330) { leftright(0, 1, 0, 1); break; }
                        if (top == 30) { leftright(0, 1, 0, 1); break; }
                        if (top == 78) { leftright(1, 1, 1, 0); break; }
                        if (top == 114) { leftright(0, 1, 0, 1); break; }
                        if (top == 150) { leftright(1, 1, 1, 0); break; }
                        break;
                    case 230:
                        if (top == 258) { leftright(1, 1, 1, 0); break; }
                        if (top == 330) { leftright(1, 0, 1, 0); break; }
                        if (top == 294) { leftright(1, 1, 0, 1); break; }
                        if (top == 222) { leftright(1, 0, 1, 1); break; }
                        if (top == 186) { leftright(0, 1, 1, 1); break; }
                        if (top == 78) { leftright(1, 1, 0, 1); break; }
                        if (top == 114) { leftright(1, 0, 1, 0); break; }
                        if (top == 150) { leftright(1, 0, 0, 1); break; }
                        break;
                    case 266:
                        if (top == 258) { leftright(1, 1, 1, 1); break; }
                        if (top == 294) { leftright(1, 0, 1, 1); break; }
                        if (top == 330) { leftright(0, 1, 1, 0); break; }
                        if (top == 186) { leftright(1, 1, 1, 1); break; }
                        if (top == 114) { leftright(0, 1, 1, 1); break; }
                        if (top == 30) { leftright(1, 1, 0, 1); break; }
                        if (top == 78) { leftright(1, 1, 1, 1); break; }
                        break;
                    case 326:
                        if (top == 258) { leftright(1, 0, 0, 1); break; }
                        if (top == 294) { leftright(1, 0, 1, 0); break; }
                        if (top == 330) { leftright(1, 0, 0, 1); break; }
                        if (top == 366) { leftright(1, 0, 1, 0); break; }
                        if (top == 114) { leftright(1, 0, 1, 0); break; }
                        if (top == 78) { leftright(1, 0, 1, 1); break; }
                        if (top == 30) { leftright(1, 0, 0, 1); break; }
                        break;
                    case 302:
                        if (top == 294) { leftright(0, 1, 0, 1); break; }
                        if (top == 330) { leftright(1, 1, 1, 0); break; }
                        break;
                    case 376:
                        if (top == 186) { transport(0, 1); break; }
                        break;
                    case -28:
                        if (top == 186) { transport(1, 0); break; }
                        break;
                }
            }
            pacturn = false;
            ghost1turn = false;
            ghost2turn = false;
            ghost3turn = false;
            ghost4turn = false;
        }

        //teletrasporto dei personaggi
        public void transport(int i, int n)
        {
            if (pacturn)
            {
                if (i == 0) pacman.Left = -26;
                if (n == 0) pacman.Left = 374;
            }
            if (ghost1turn)
            {
                if (i == 0) ghost1.Left = -26;
                if (n == 0) ghost1.Left = 374;
            }
            if (ghost2turn)
            {
                if (i == 0) ghost2.Left = -26;
                if (n == 0) ghost2.Left = 374;
            }
            if (ghost3turn)
            {
                if (i == 0) ghost3.Left = -26;
                if (n == 0) ghost3.Left = 374;
            }
            if (ghost4turn)
            {
                if (i == 0) ghost4.Left = -26;
                if (n == 0) ghost4.Left = 374;
            }
        }

        //Getter function to get ghost.Left values
        public int[] getCharacterLeft()
        {
            return new[] { pacman.Left, ghost1.Left, ghost2.Left, ghost3.Left, ghost4.Left };
        }

        //effettiva modifica della posizione dei fantasmini
        public void ghost()
        {
            if (ghost1.Enabled == true)
            {
                ghost1.Left += leftghost1;
                ghost1.Top += topghost1;
                ghost1turn = true;
                a(ghost1.Left, ghost1.Top);
            }
            if (ghost2.Enabled == true)
            {
                ghost2.Left += leftghost2;
                ghost2.Top += topghost2;
                ghost2turn = true;
                a(ghost2.Left, ghost2.Top);
            }
            if (ghost3.Enabled == true)
            {
                ghost3.Left += leftghost3;
                ghost3.Top += topghost3;
                ghost3turn = true;
                a(ghost3.Left, ghost3.Top);
            }
            if (ghost4.Enabled == true)
            {
                ghost4.Left += leftghost4;
                ghost4.Top += topghost4;
                ghost4turn = true;
                a(ghost4.Left, ghost4.Top);
            }
        }
    }
}
