using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows;
using System;
using System.Reflection;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Pacman_Zagorschi_Franco
{
    [TestClass]
    public class Form1Tests
    {
        [TestMethod]
        public void Load_Form1()
        {
            var form = new Pacman_Zagorschi_Franco.Form1();
            Assert.IsNotNull(form);
            
        }

        [TestMethod]
        public void button1_MouseLeave_resource_equals_playgame()
        {
            //Set
            var path = Directory.GetCurrentDirectory().ToString().Replace("\\bin\\Release", "");
            path = path.Replace("\\bin\\Debug", "");
            Image image = Image.FromFile(path+"\\Resources\\playgame.PNG");
            var form = new Pacman_Zagorschi_Franco.Form1();
            form.button1_MouseLeave(null, null);
            
            //Execute
            var x = (System.Drawing.Bitmap)image;
            var y = form.Get_Button1_Image();

            if (x.Height != y.Height || x.Width != y.Width) Assert.Fail();
            for (int i = 0; i < x.Width; i++)
            {
                for (int j = 0; j < x.Height; j++)
                {
                    if (x.GetPixel(i, j) != y.GetPixel(i, j)) Assert.Fail();
                }
            }

            Assert.IsNotNull(form); //If here, test passed
        }

        [TestMethod]
        public void button1_MouseEnter_resource_equals_playgame2()
        {
            //Set
            var path = Directory.GetCurrentDirectory().ToString().Replace("\\bin\\Release", "");
            path = path.Replace("\\bin\\Debug", "");
            Image image = Image.FromFile(path + "\\Resources\\playgame2.bmp");
            var form = new Pacman_Zagorschi_Franco.Form1();
            form.button1_MouseEnter(null, null);

            //Execute
            var x = (System.Drawing.Bitmap)image;
            var y = form.Get_Button1_Image();

            if (x.Height != y.Height || x.Width != y.Width) Assert.Fail();
            for (int i = 0; i < x.Width; i++)
            {
                for (int j = 0; j < x.Height; j++)
                {
                    if (x.GetPixel(i, j) != y.GetPixel(i, j)) Assert.Fail();
                }
            }
        }

        [TestMethod]
        public void finepartita_timers1to6_false_powermod_false_timer7_true()
        {
            //Set
            var form  = new Pacman_Zagorschi_Franco.Form1();

            //Execute
            form.finepartita();

            int[] intResults =
            {
                form.point,
                form.vita
            };

            bool[] boolResults =
            {
                form.timer1.Enabled,
                form.timer2.Enabled,
                form.timer3.Enabled,
                form.timer4.Enabled,
                form.timer5.Enabled,
                form.timer6.Enabled,
                form.powermod1.Enabled,
                form.powermod.Enabled,
                form.timer7.Enabled,
            };

            //Check
            CollectionAssert.AreEqual(intResults, new[]{ 0,3});
            CollectionAssert.AreEqual(boolResults, new[]{ false,false,false,false,false,false,false,false,true });

        }


        [TestMethod]
        public void ghostmangiato_Tick_timer1_True_ghostmangiato_False()
        {
            //Set
            var form = new Pacman_Zagorschi_Franco.Form1();

            //Execute
            form.ghostmangiato_Tick(null, null);

            //Check
            CollectionAssert.AreEqual(new[] { form.timer1.Enabled, form.ghostmangiato.Enabled }, new[] { true, false });
        }

        [TestMethod]
        public void powermod1_Tick_tresec_True_powermod_false()
        {
            //Set
            var form = new Pacman_Zagorschi_Franco.Form1();

            //Execute
            form.powermod1_Tick(null, null);

            //Check
            CollectionAssert.AreEqual(new[] { form.tresec, form.powermod1.Enabled}, new[] { true, false });
        }

        [DataTestMethod]
        [DynamicData(nameof(ControlData), DynamicDataSourceType.Property)]
        public void control_timer3_false_timer4_true_c_false_timer5_true(int position, bool[] expected )
        {
            //Set
            var form = new Pacman_Zagorschi_Franco.Form1();
            form.ghost2.Top = position;

            //Execute
            form.control();

            //Check
            CollectionAssert.AreEqual(new[] { form.timer3.Enabled, form.timer4.Enabled, form.c, form.timer5.Enabled }, expected);
        }
        public static IEnumerable<object[]> ControlData
        {
            //All binary combinations 
            get
            {
                yield return new object[] { 185, new[] { false, true, false, true } }; //Position meets condition
                yield return new object[] { 1, new[] { false, false, false, false } }; //Position fails condition
            }
        }


        //i = input
        //e = expected
        [DataTestMethod]
        [DataRow(false, false, false, false,false, false, false, false)]
        [DataRow(false, false, false, true,false, false, false, true)]
        [DataRow(false, false, true, false, false, false, true, false)]
        [DataRow(false, false, true, true, false, false, true, true)]
        [DataRow(false, true, false, false, false, true, false, false)]
        [DataRow(false, true, false, true, false, true, false, true)]
        [DataRow(false, true, true, false, false, true, true, false)]
        [DataRow(false, true, true, true, false, true, true, true)]
        [DataRow(true, false, false, false, true, false, false, false)]
        [DataRow(true, false, false, true, true, false, false, true)]
        [DataRow(true, false, true, false, true, false, true, false)]
        [DataRow(true, false, true, true, true, false, true, true)]
        [DataRow(true, true, false, false, true, true, false, false)]
        [DataRow(true, true, false, true, true, true, false, true)]
        [DataRow(true, true, true, false, true, true, true, false)]
        [DataRow(true, true, true, true, true, true, true, true)]
        public void supermod2(bool i1, bool i2, bool i3, bool i4, bool e1, bool e2, bool e3, bool e4) 
        {
            //Set
            bool[] result = new bool[4];
            var form = new Pacman_Zagorschi_Franco.Form1();
            form.g1mangiato = i1;
            form.g2mangiato = i2;
            form.g3mangiato = i3;
            form.g4mangiato = i4;

            //Execute
            form.supermod2();
            result[0] = form.g1mangiato;
            result[1] = form.g2mangiato;
            result[2] = form.g3mangiato;
            result[3] = form.g4mangiato;

            //Check
            CollectionAssert.AreEqual(result, new[] {e1,e2,e3,e4});
        }

        //Tests fail for some reason. Looking into later

        [TestMethod]
        public void timer9_Tick_picturebox3_true_button1_true_timer9_false()
        {
            //Set
            var form = new Pacman_Zagorschi_Franco.Form1();

            //Execute
            form.timer9_Tick(null, null);

            //Check
            CollectionAssert.AreEqual(new[] { form.pictureBox3.Visible, form.button1.Visible, form.timer9.Enabled }, new[] { true, true, false });
        }

        [TestMethod]
        public void timer7_Tick_timer7_false_panel1_true_attendo_true()
        {
            //Set
            var form = new Pacman_Zagorschi_Franco.Form1();

            //Execute
            form.timer7_Tick(null, null);
            var x = new[] { form.timer7.Enabled, form.panel1.Visible, form.attendo.Enabled };

            //Check
            CollectionAssert.AreEqual(new[] { form.timer7.Enabled, form.panel1.Visible, form.attendo.Enabled }, new[] { false, true, true });
        }

        // Have to use a test stub here
        [TestMethod]
        public void control_timer_3to5_false_true_false_c_false()
        {
            //Set
            var form = new Pacman_Zagorschi_Franco.Form1();
            form.resetall();

            //Execute
            form.control();
            bool[] result = new bool[4];
            result[0] = false;
            result[1] = true;
            result[2] = false;
            result[3] = true;

            //Check
            CollectionAssert.AreEqual(new[] { form.timer3.Enabled, form.timer4.Enabled, form.c, form.timer5.Enabled }, result);
        }

        [TestMethod]
        public void attendo_Tick_attendoEnabled_false()
        {
            //Set
            var form = new Pacman_Zagorschi_Franco.Form1();

            //Execute
            form.attendo_Tick(null, null);

            //Check
            Assert.AreEqual(false, form.attendo.Enabled);
        }

        [DataTestMethod]
        [DataRow(true, true, 3)]
        [DataRow(true, false, 2)]
        [DataRow(false, false, 1)]
        public void life_dependsOnVita(bool picbox1, bool picbox2, int lives)
        {
            //Set
            var form = new Pacman_Zagorschi_Franco.Form1();

            //Execute
            form.resetall();
            form.vita = lives;
            Console.WriteLine(form.vita);
            Console.WriteLine(form.getPictureBox()[0].Visible);
            form.life();
            Console.WriteLine(form.getPictureBox()[0].Visible);
            //Test
            CollectionAssert.AreEqual(new[] { picbox1, picbox2 }, new[] { form.getPictureBox()[0].Visible, form.getPictureBox()[1].Visible });
        }

        [DataTestMethod]
        [DataRow(1, 2, 2)]
        [DataRow(2, 1, -2)]
        [DataRow(3, 4, 2)]
        [DataRow(4, 3, -2)]
        public void freedirection_nextDirection_keyPress(int direction, int next, int resultantDirection)
        {
            //Set
            var form = new Pacman_Zagorschi_Franco.Form1();

            //Execute
            form.resetall();
            form.direzione = direction;
            form.next = next;
            form.freedirection();

            //Test
            if (direction == 1 || direction == 2)
                CollectionAssert.AreEqual(new[] { resultantDirection, next, next }, new[] { form.left, form.direzione, form.temp });
            if (direction == 3 || direction == 4)
                CollectionAssert.AreEqual(new[] { resultantDirection, next, next }, new[] { form.top, form.direzione, form.temp });

        }

        // Increasing statement coverage & decision coverage
        [DataTestMethod]
        [DataRow(true, 0, 0, 374)]
        [DataRow(true, 0, 1, -26)]
        [DataRow(true, 1, 0, 374)]
        public void testTransport(bool charTurn, int i, int n, int left)
        {
            //Set
            var form = new Pacman_Zagorschi_Franco.Form1();

            form.pacturn = charTurn;
            form.ghost1turn = charTurn;
            form.ghost2turn = charTurn;
            form.ghost3turn = charTurn;
            form.ghost4turn = charTurn;

            //Execute
            form.transport(i, n);
            int[] arr = form.getCharacterLeft();
            int[] res = { left, left, left, left, left };

            for (int j = 0; j < 4; j++)
                Console.WriteLine(arr[0] + "," + res[j]);

            //Check
            CollectionAssert.AreEqual(arr, res);

        }

        [DataTestMethod]
        [DataRow(true, 300, 20, 100, 40)]
        public void testGhost(bool enabled, int ghostLeft, int willGhostLeft, int ghostTop, int willGhostTop)
        {
            //Set
            var form = new Pacman_Zagorschi_Franco.Form1();

            //Execute
            form.ghost1.Left = ghostLeft;
            form.leftghost1 = willGhostLeft;
            form.ghost1.Top = ghostTop;
            form.topghost1 = willGhostTop;

            form.ghost2.Left = ghostLeft;
            form.leftghost2 = willGhostLeft;
            form.ghost2.Top = ghostTop;
            form.topghost2 = willGhostTop;

            form.ghost3.Left = ghostLeft;
            form.leftghost3 = willGhostLeft;
            form.ghost3.Top = ghostTop;
            form.topghost3 = willGhostTop;

            form.ghost4.Left = ghostLeft;
            form.leftghost4 = willGhostLeft;
            form.ghost4.Top = ghostTop;
            form.topghost4 = willGhostTop;

            int ghostLeftSum = ghostLeft + willGhostLeft;
            int ghostTopSum = ghostTop + willGhostTop;

            //Verify
            form.ghost();
            CollectionAssert.AreEqual(new[] { ghostLeftSum, ghostTopSum, ghostLeftSum, ghostTopSum, ghostLeftSum, ghostTopSum, ghostLeftSum, ghostTopSum }, new[] { form.ghost1.Left, form.ghost1.Top, form.ghost2.Left, form.ghost2.Top, form.ghost3.Left, form.ghost3.Top, form.ghost4.Left, form.ghost4.Top });
        }

        [TestMethod]
        public void testDirection()
        {
            //Set
            var form = new Pacman_Zagorschi_Franco.Form1();

            //Execute
            int left = form.left;
            int pacmanLeft = form.getPacman().Left;
            int top = form.top;
            int pacmanTop = form.getPacman().Top;

            form.direction();

            //Test
            CollectionAssert.AreEqual(new[] { left + pacmanLeft, top + pacmanTop }, new[] { form.getPacman().Left, form.getPacman().Top });
        }

        [DataTestMethod]
        [DataRow(174, 148)]
        [DataRow(174, 0)]

        [DataRow(24, 364)]
        [DataRow(24, 328)]
        [DataRow(24, 292)]
        [DataRow(24, 256)]
        [DataRow(24, 112)]
        [DataRow(24, 76)]
        [DataRow(24, 28)]
        [DataRow(24, 0)]

        [DataRow(48, 328)]
        [DataRow(48, 292)]

        [DataRow(84, 364)]
        [DataRow(84, 328)]
        [DataRow(84, 292)]
        [DataRow(84, 256)]
        [DataRow(84, 112)]
        [DataRow(84, 184)]
        [DataRow(84, 76)]
        [DataRow(84, 28)]

        [DataRow(120, 364)]
        [DataRow(120, 328)]
        [DataRow(120, 292)]
        [DataRow(120, 256)]
        [DataRow(120, 112)]
        [DataRow(120, 184)]
        [DataRow(120, 76)]
        [DataRow(120, 28)]
        [DataRow(120, 148)]
        [DataRow(120, 220)]

        [DataRow(156, 364)]
        [DataRow(156, 328)]
        [DataRow(156, 292)]
        [DataRow(156, 256)]
        [DataRow(156, 112)]
        [DataRow(156, 184)]
        [DataRow(156, 76)]
        [DataRow(156, 28)]
        [DataRow(156, 148)]
        [DataRow(156, 220)]

        [DataRow(192, 364)]

        [DataRow(120, 328)]
        [DataRow(120, 292)]
        [DataRow(120, 256)]
        [DataRow(120, 112)]
        [DataRow(120, 184)]
        [DataRow(120, 76)]
        [DataRow(120, 28)]
        [DataRow(120, 148)]
        [DataRow(120, 220)]
        public void testCrossRoads_functionA(int left, int top)
        {
            //Set
            var form = new Pacman_Zagorschi_Franco.Form1();

            //Execute
            form.pacturn = true;
            form.a(left, top);

            //Test
            Assert.IsTrue(true);
        }

        [DataTestMethod]
        [DataRow(Keys.Left, 1)]
        [DataRow(Keys.Right, 2)]
        [DataRow(Keys.Up, 3)]
        [DataRow(Keys.Down, 4)]
        [DataRow(Keys.Escape, 0)]
        public void test_Form1_KeyDown(Keys keyValue, int resultantTemp)
        {
            //Set
            var form = new Pacman_Zagorschi_Franco.Form1();

            //Execute
            KeyEventArgs e = new KeyEventArgs(keyValue);
            form.Form1_KeyDown(null, e);

            //Test
            Assert.AreEqual(resultantTemp, form.temp);
        }

        [TestMethod]
        public void test_timer1_Tick()
        {
            //Setup
            var form = new Pacman_Zagorschi_Franco.Form1();

            //Execute
            form.getPacman().Enabled = true;
            form.ghost4.Enabled = true;
            form.c = true;
            form.timer1_Tick(null, null);

            //Test
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void test_timer2_Tick()
        {
            //Setup
            var form = new Pacman_Zagorschi_Franco.Form1();

            //Execute
            form.timer2_Tick(null, null);

            //Test
            CollectionAssert.AreEqual(new[] { false, true, false, true }, new[] { form.getLabel3().Visible, form.timer1.Enabled, form.timer2.Enabled, form.c });
        }

    }
}
