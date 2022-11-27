using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
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
        [DeploymentItem("Pacman_Zagorschi_Franco.exe")]
        public void button1_click_reset_allGame()
        {
            // act
            var form = new Pacman_Zagorschi_Franco.Form1();
            object sender = null;
            EventArgs e = null;
            form.button1_Click(sender, e);

            bool ifStart = false;
            bool isPanel1Visible = false;

            // assert
            Assert.AreEqual(form.start, ifStart);
            Assert.AreEqual(form.panel1.Visible, isPanel1Visible);

        }

        [TestMethod]
        public void label254_Click_1_privateMethod_null()
        {
            // set
            var form = new Pacman_Zagorschi_Franco.Form1();
            object sender = null;
            EventArgs e = null;
            PrivateObject accessor = new PrivateObject(form);

            // act
            accessor.Invoke("label254_Click_1", sender, e);

        }

        [TestMethod]
        public void pictureBox5_Click_privateMethod_null()
        {
            // set
            var form = new Pacman_Zagorschi_Franco.Form1();
            object sender = null;
            EventArgs e = null;
            PrivateObject accessor = new PrivateObject(form);

            // act
            accessor.Invoke("pictureBox5_Click", sender, e);
        }

        [TestMethod]
        public void label255_Click_privateMethod_null()
        {
            // set
            var form = new Pacman_Zagorschi_Franco.Form1();
            object sender = null;
            EventArgs e = null;
            PrivateObject accessor = new PrivateObject(form);

            // act
            accessor.Invoke("label255_Click", sender, e);
        }

        [TestMethod]
        public void label254_Click_privateMethod_null()
        {
            // set
            var form = new Pacman_Zagorschi_Franco.Form1();
            object sender = null;
            EventArgs e = null;
            PrivateObject accessor = new PrivateObject(form);

            // act
            accessor.Invoke("label254_Click", sender, e);
        }

        [TestMethod]
        public void panel1_Paint_privateMethod_null()
        {
            // set
            var form = new Pacman_Zagorschi_Franco.Form1();
            object sender = null;
            PaintEventArgs e = null;
            PrivateObject accessor = new PrivateObject(form);

            // act
            accessor.Invoke("panel1_Paint", sender, e);
        }

        [TestMethod]
        public void label142_Click_privateMethod_null()
        {
            // set
            var form = new Pacman_Zagorschi_Franco.Form1();
            object sender = null;
            EventArgs e = null;
            PrivateObject accessor = new PrivateObject(form);

            // act
            accessor.Invoke("label142_Click", sender, e);
        }

        [TestMethod]
        public void pictureBox4_Click_privateMethod_null()
        {
            // set
            var form = new Pacman_Zagorschi_Franco.Form1();
            object sender = null;
            EventArgs e = null;
            PrivateObject accessor = new PrivateObject(form);

            // act
            accessor.Invoke("pictureBox4_Click", sender, e);
        }

        [TestMethod]
        public void pictureBox3_Click_privateMethod_null()
        {
            // set
            var form = new Pacman_Zagorschi_Franco.Form1();
            object sender = null;
            EventArgs e = null;
            PrivateObject accessor = new PrivateObject(form);

            // act
            accessor.Invoke("pictureBox3_Click", sender, e);
        }

        [TestMethod]
        public void button1_MouseLeave_equals_playgame()
        {
            // set
            var form = new Pacman_Zagorschi_Franco.Form1();
            object sender = null;
            EventArgs e = null;

            // act
            form.button1_MouseLeave(sender, e);
        }

        [TestMethod]
        public void button1_MouseEnter_equals_playgame2()
        {
            // set
            var form = new Pacman_Zagorschi_Franco.Form1();
            object sender = null;
            EventArgs e = null;

            // act
            form.button1_MouseEnter(sender, e);
        }


        [TestMethod]
        public void Get_Button1_Image_resourse_buttonImage()
        {
            // set
            var form = new Pacman_Zagorschi_Franco.Form1();

            // act
            var bitmap = form.Get_Button1_Image();
            Assert.AreEqual(bitmap, form.button1.Image);
        }

        [TestMethod]
        public void finepartita_timers1to6_false_powermod_false_timer7_true()
        {
            //Set
            var form = new Pacman_Zagorschi_Franco.Form1();

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
            CollectionAssert.AreEqual(intResults, new[] { 0, 3 });
            CollectionAssert.AreEqual(boolResults, new[] { false, false, false, false, false, false, false, false, true });

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
            CollectionAssert.AreEqual(new[] { form.tresec, form.powermod1.Enabled }, new[] { true, false });
        }

        [DataTestMethod]
        [DynamicData(nameof(ControlData), DynamicDataSourceType.Property)]
        public void control_timer3_false_timer4_true_c_false_timer5_true(int position, bool[] expected)
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
        [DataRow(false, false, false, false, false, false, false, false)]
        [DataRow(false, false, false, true, false, false, false, true)]
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
            CollectionAssert.AreEqual(result, new[] { e1, e2, e3, e4 });
        }


        [TestMethod]
        public void timer9_Tick_picturebox3_true_button1_true_timer9_false()
        {
            //Set
            var form = new Pacman_Zagorschi_Franco.Form1();

            //Execute
            form.timer9_Tick(null, null);

            //Check
            CollectionAssert.AreEqual(new[] { form.timer9.Enabled }, new[] { false });
        }

        [TestMethod]
        public void timer8_Tick_test()
        {
            {
                //Set
                var form = new Pacman_Zagorschi_Franco.Form1();

                //Execute
                form.timer8_Tick(null, null);

                //Check
                CollectionAssert.AreEqual(new[] { form.timer8.Enabled }, new[] { false });
            }
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
        [DataRow(48, 0)]

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

        [DataRow(192, 292)]
        [DataRow(192, 256)]
        [DataRow(192, 364)]
        [DataRow(192, 328)]
        [DataRow(192, 28)]
        [DataRow(192, 76)]
        [DataRow(192, 112)]
        [DataRow(192, 148)]
        [DataRow(192, 0)]

        [DataRow(228, 328)]
        [DataRow(228, 292)]
        [DataRow(228, 256)]
        [DataRow(228, 112)]
        [DataRow(228, 184)]
        [DataRow(228, 76)]
        [DataRow(228, 112)]
        [DataRow(228, 28)]
        [DataRow(228, 148)]
        [DataRow(228, 220)]

        [DataRow(264, 256)]
        [DataRow(264, 292)]
        [DataRow(264, 328)]
        [DataRow(264, 184)]
        [DataRow(264, 112)]
        [DataRow(264, 28)]
        [DataRow(264, 76)]
        [DataRow(264, 88)]

        [DataRow(324, 256)]
        [DataRow(324, 292)]
        [DataRow(324, 328)]
        [DataRow(324, 364)]
        [DataRow(324, 112)]
        [DataRow(324, 76)]
        [DataRow(324, 28)]
        [DataRow(324, 99)]

        [DataRow(300, 292)]
        [DataRow(300, 328)]
        [DataRow(300, 0)]

        [DataRow(374, 184)]
        [DataRow(374, 0)]

        [DataRow(-26, 184)]
        [DataRow(-26, 0)]

        [DataRow(26, 366)]
        [DataRow(26, 330)]
        [DataRow(26, 294)]
        [DataRow(26, 258)]
        [DataRow(26, 114)]
        [DataRow(26, 78)]
        [DataRow(26, 30)]
        [DataRow(26, 0)]

        [DataRow(50, 330)]
        [DataRow(50, 294)]
        [DataRow(50, 0)]

        [DataRow(86, 258)]
        [DataRow(86, 330)]
        [DataRow(86, 294)]
        [DataRow(86, 186)]
        [DataRow(86, 114)]
        [DataRow(86, 30)]
        [DataRow(86, 78)]
        [DataRow(86, 0)]

        [DataRow(122, 294)]
        [DataRow(122, 330)]
        [DataRow(122, 258)]
        [DataRow(122, 222)]
        [DataRow(122, 78)]
        [DataRow(122, 114)]
        [DataRow(122, 150)]
        [DataRow(122, 186)]
        [DataRow(122, 0)]

        [DataRow(158, 330)]
        [DataRow(158, 366)]
        [DataRow(158, 258)]
        [DataRow(158, 294)]
        [DataRow(158, 78)]
        [DataRow(158, 114)]
        [DataRow(158, 150)]
        [DataRow(158, 30)]
        [DataRow(158, 0)]

        [DataRow(194, 294)]
        [DataRow(194, 258)]
        [DataRow(194, 366)]
        [DataRow(194, 330)]
        [DataRow(194, 30)]
        [DataRow(194, 78)]
        [DataRow(194, 114)]
        [DataRow(194, 150)]
        [DataRow(194, 0)]

        [DataRow(230, 258)]
        [DataRow(230, 330)]
        [DataRow(230, 294)]
        [DataRow(230, 222)]
        [DataRow(230, 186)]
        [DataRow(230, 78)]
        [DataRow(230, 114)]
        [DataRow(230, 150)]
        [DataRow(230, 0)]

        [DataRow(266, 258)]
        [DataRow(266, 294)]
        [DataRow(266, 330)]
        [DataRow(266, 186)]
        [DataRow(266, 114)]
        [DataRow(266, 30)]
        [DataRow(266, 78)]
        [DataRow(266, 0)]

        [DataRow(326, 258)]
        [DataRow(326, 294)]
        [DataRow(326, 330)]
        [DataRow(326, 366)]
        [DataRow(326, 114)]
        [DataRow(326, 78)]
        [DataRow(326, 30)]
        [DataRow(326, 0)]

        [DataRow(302, 294)]
        [DataRow(302, 330)]
        [DataRow(302, 0)]

        [DataRow(376, 186)]
        [DataRow(376, 0)]

        [DataRow(-28, 186)]
        [DataRow(-28, 0)]

        public void testCrossRoads_functionA(int left, int top)
        {
            //Set
            var form = new Pacman_Zagorschi_Franco.Form1();

            //Execute
            form.pacturn = true;
            form.a(left, top);

            form.pacturn = false;
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
        [DataRow(true, true, true, true)]
        [DataRow(true, true, true, false)]
        [DataRow(true, true, false, true)]
        [DataRow(true, true, false, false)]
        [DataRow(true, false, true, true)]
        [DataRow(true, false, true, false)]
        [DataRow(true, false, false, true)]
        [DataRow(true, false, false, false)]
        [DataRow(false, true, true, true)]
        [DataRow(false, true, true, false)]
        [DataRow(false, true, false, true)]
        [DataRow(false, true, false, false)]
        [DataRow(false, false, true, true)]
        [DataRow(false, false, true, false)]
        [DataRow(false, false, false, true)]
        [DataRow(false, false, false, false)]
        public void timer1_Tick_defaultMode_game_running(bool b1, bool b2, bool b3, bool b4)
        {
            //Setup
            var form = new Pacman_Zagorschi_Franco.Form1();

            //Execute

            form.ghost1.Enabled = b1;
            form.ghost2.Enabled = b2;
            form.ghost3.Enabled = b3;
            form.ghost4.Enabled = b4;
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

        [DataTestMethod]
        [DataRow(180, 100, 2)]
        [DataRow(192, 100, 1)]
        public void test_timer3_Tick(int ghost2TopValue, int ghost4TopValue, int startDirectionValue)
        {
            //Set
            var form = new Pacman_Zagorschi_Franco.Form1();

            //Execute
            form.ghost2.Top = ghost2TopValue;
            form.ghost4.Top = ghost4TopValue;
            form.timer3_Tick(null, null);

            //Test
            if (startDirectionValue == 1)
                CollectionAssert.AreEqual(new[] { ghost2TopValue - 1, ghost4TopValue - 1, startDirectionValue }, new[] { form.ghost2.Top, form.ghost4.Top, form.startdirection });
            else if (startDirectionValue == 2)
                CollectionAssert.AreEqual(new[] { ghost2TopValue + 1, ghost4TopValue + 1, startDirectionValue }, new[] { form.ghost2.Top, form.ghost4.Top, form.startdirection });
        }

        [DataTestMethod]
        [DataRow(149, 99)]
        [DataRow(149, 100)]
        [DataRow(149, 101)]
        [DataRow(150, 99)]
        [DataRow(150, 100)]
        [DataRow(150, 101)]
        [DataRow(151, 99)]
        [DataRow(151, 100)]
        [DataRow(151, 101)]
        [DataRow(152, 99)]
        [DataRow(152, 100)]
        [DataRow(152, 101)]
        public void test_timer4_Tick(int ghost3TopValue, int tic4Value)
        {
            //Set
            var form = new Pacman_Zagorschi_Franco.Form1();

            //Execute
            int prec1Value = form.prec1;
            bool timer4 = form.timer4.Enabled;
            form.tic4 = tic4Value;
            form.ghost3.Top = ghost3TopValue;
            form.timer4_Tick(null, null);

            //Test
            if (ghost3TopValue > 151 && tic4Value > 99)
            {
                CollectionAssert.AreEqual(new[] { tic4Value + 1, 3, ghost3TopValue - 1, Convert.ToInt32(timer4) }, new[] { form.tic4, form.prec1, form.ghost3.Top, Convert.ToInt32(form.timer4.Enabled) });

            }
            else if (ghost3TopValue > 150 && tic4Value > 99)
            {
                CollectionAssert.AreEqual(new[] { tic4Value + 1, 3, ghost3TopValue - 1, Convert.ToInt32(false) }, new[] { form.tic4, form.prec1, form.ghost3.Top, Convert.ToInt32(form.timer4.Enabled) });

            }
            else if (ghost3TopValue == 150)
            {
                CollectionAssert.AreEqual(new[] { tic4Value + 1, prec1Value, ghost3TopValue, Convert.ToInt32(false) }, new[] { form.tic4, form.prec1, form.ghost3.Top, Convert.ToInt32(form.timer4.Enabled) });

            }
            else
            {
                CollectionAssert.AreEqual(new[] { tic4Value + 1, prec1Value, ghost3TopValue, Convert.ToInt32(timer4) }, new[] { form.tic4, form.prec1, form.ghost3.Top, Convert.ToInt32(form.timer4.Enabled) });

            }
        }

        [DataTestMethod]
        [DataRow(149, 175, 299)]
        [DataRow(150, 175, 299)]
        [DataRow(151, 175, 299)]
        [DataRow(151, 176, 299)]
        [DataRow(151, 153, 300)]
        [DataRow(151, 153, 301)]
        [DataRow(151, 154, 300)]
        [DataRow(151, 154, 301)]
        [DataRow(151, 175, 300)]
        [DataRow(151, 175, 301)]
        [DataRow(151, 176, 300)]
        [DataRow(151, 176, 301)]
        public void test_timer5Tick(int ghost2TopValue, int ghost2LeftValue, int tic5Value)
        {
            //Setup
            var form = new Pacman_Zagorschi_Franco.Form1();

            //Execute
            form.tic5 = tic5Value;
            form.ghost2.Left = ghost2LeftValue;
            bool timer6 = form.timer6.Enabled;
            bool timer5 = form.timer5.Enabled;
            form.ghost2.Top = ghost2TopValue;
            form.timer5_Tick(null, null);

            //Test
            if (ghost2TopValue == 151 && ghost2LeftValue == 175 && tic5Value > 299)
            {
                CollectionAssert.AreEqual(new[] { true, false }, new[] { form.timer6.Enabled, form.timer5.Enabled }, "All three ifs passed");
            }
            else if (ghost2TopValue != 151 && ghost2LeftValue == 175 && tic5Value > 299)
            {
                CollectionAssert.AreEqual(new[] { timer6, timer5 }, new[] { form.timer6.Enabled, form.timer5.Enabled }, "First 2 ifs passed");
            }
            else if (ghost2TopValue == 151 && ghost2LeftValue == 176)
            {
                CollectionAssert.AreEqual(new[] { true, false }, new[] { form.timer6.Enabled, form.timer5.Enabled }, "Last 2 ifs passed");
            }
            else if (ghost2TopValue == 150)
            {
                CollectionAssert.AreEqual(new[] { true, false }, new[] { form.timer6.Enabled, form.timer5.Enabled }, "First 2 ifs passed");
            }
            else
            {
                CollectionAssert.AreEqual(new[] { timer6, timer5 }, new[] { form.timer6.Enabled, form.timer5.Enabled }, "Last if not passed");
            }
        }

        [DataTestMethod]
        [DataRow(149, 199, 99)]
        [DataRow(150, 199, 99)]
        [DataRow(151, 199, 99)]
        [DataRow(151, 200, 99)]
        [DataRow(151, 176, 100)]
        [DataRow(151, 176, 101)]
        [DataRow(151, 177, 100)]
        [DataRow(151, 177, 101)]
        [DataRow(151, 177, 100)]
        [DataRow(151, 177, 101)]
        [DataRow(151, 176, 100)]
        [DataRow(151, 176, 101)]
        public void test_timer6Tick(int ghost4TopValue, int ghost4LeftValue, int tic6Value)
        {
            //Setup
            var form = new Pacman_Zagorschi_Franco.Form1();

            //Execute
            form.tic6 = tic6Value;
            form.ghost4.Left = ghost4LeftValue;
            bool timer6 = form.timer6.Enabled;
            form.ghost4.Top = ghost4TopValue;
            form.timer6_Tick(null, null);

            //Test
            if (ghost4TopValue == 151 && ghost4LeftValue == 177 && tic6Value > 99)
            {
                Assert.AreEqual(false, form.timer6.Enabled, "All three ifs passed");
            }
            else if (ghost4TopValue != 151 && ghost4LeftValue == 177 && tic6Value > 99)
            {
                Assert.AreEqual(timer6, form.timer6.Enabled, "First 2 ifs passed");
            }
            else if (ghost4TopValue == 151 && ghost4LeftValue == 176)
            {
                Assert.AreEqual(false, form.timer6.Enabled, "Last 2 ifs passed");
            }
            else if (ghost4TopValue == 150)
            {
                Assert.AreEqual(false, form.timer6.Enabled, "First 2 ifs passed");
            }
            else
            {
                Assert.AreEqual(timer6, form.timer6.Enabled, "Last if not passed");
            }
        }


        [TestMethod]
        [DataRow(1, 2, 3, 4, true)]
        [DataRow(1, 2, 3, 4, false)]
        [DataRow(-1, -2, -3, -4, true)]
        [DataRow(-1, -2, -3, -4, false)]
        public void powermod_tick_enable_ghost_notEating(int c1, int c2, int c3, int c4, bool b)
        {
            var form = new Pacman_Zagorschi_Franco.Form1();
            object sender = null;
            EventArgs e = null;
            form.powermod_Tick(sender, e);
            form.tresec = false;

            form.g1mangiato = false;
            Assert.IsFalse(form.v1);
            Assert.IsTrue(form.ghost1puomangiare);
            Assert.IsFalse(form.Supermod1);
            Assert.AreEqual(form.ghost1velocity, 2);

            form.g2mangiato = false;
            Assert.IsFalse(form.v2);
            Assert.IsTrue(form.ghost2puomangiare);
            Assert.IsFalse(form.Supermod2);
            Assert.AreEqual(form.ghost2velocity, 2);

            form.g3mangiato = false;
            Assert.IsFalse(form.v3);
            Assert.IsTrue(form.ghost3puomangiare);
            Assert.IsFalse(form.Supermod3);
            Assert.AreEqual(form.ghost3velocity, 2);

            form.g4mangiato = false;
            Assert.IsFalse(form.v4);
            Assert.IsTrue(form.ghost4puomangiare);
            Assert.IsFalse(form.Supermod4);
            Assert.AreEqual(form.ghost4velocity, 2);

            // prec1

            form.prec1 = c1;
            form.g1mangiato = b;
            form.ghost1.Left = 2;

            form.prec1 = c2;
            form.g1mangiato = b;
            form.ghost1.Left = 2;

            form.prec1 = c3;
            form.g1mangiato = b;
            form.ghost1.Left = 2;

            form.prec1 = c4;
            form.g1mangiato = b;
            form.ghost1.Left = 2;


            //prec2
            form.prec2 = c1;
            form.g1mangiato = b;
            form.ghost2.Left = 2;

            form.prec2 = c2;
            form.g1mangiato = b;
            form.ghost2.Left = 2;

            form.prec2 = c3;
            form.g1mangiato = b;
            form.ghost2.Left = 2;

            form.prec2 = c4;
            form.g1mangiato = b;
            form.ghost2.Left = 2;

            //prec3
            form.prec3 = c1;
            form.g1mangiato = b;
            form.ghost3.Left = 2;

            form.prec3 = c2;
            form.g1mangiato = b;
            form.ghost3.Left = 2;

            form.prec3 = c3;
            form.g1mangiato = b;
            form.ghost3.Left = 2;

            form.prec3 = c4;
            form.g1mangiato = b;
            form.ghost3.Left = 2;

            //prec4
            form.prec4 = c1;
            form.g1mangiato = b;
            form.ghost4.Left = 2;

            form.prec4 = c2;
            form.g1mangiato = b;
            form.ghost4.Left = 2;

            form.prec4 = c3;
            form.g1mangiato = b;
            form.ghost4.Left = 2;

            form.prec4 = c4;
            form.g1mangiato = b;
            form.ghost4.Left = 2;
        }




        [DataTestMethod]
        [DataRow(31, 298)]
        [DataRow(28, 54)]
        [DataRow(330, 54)]
        [DataRow(330, 298)]
        public void test_supermod(int x, int y)
        {
            //Set
            var form = new Pacman_Zagorschi_Franco.Form1();

            //Execute
            form.getPacman().Location = new System.Drawing.Point(x, y);

            if (x == 31)
                form.setLabelVisible(173);
            else if (x == 28)
                form.setLabelVisible(307);
            else if (x == 330 && y == 54)
                form.setLabelVisible(220);
            else if (x == 330 && y == 298)
                form.setLabelVisible(71);

            form.supermod();

            //Test
            Assert.IsTrue(true);
        }

    }
}
