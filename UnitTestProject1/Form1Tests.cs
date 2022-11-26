using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows;
using System;
using System.Reflection;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
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
    }
}
