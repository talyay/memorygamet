using MemoryGame.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class Form : System.Windows.Forms.Form
    {// משתנים גלובלים
        Random rnd = new Random();
        Random location = new Random();
        List<Point> points = new List<Point>();//רשימה שמכילה נקודות של תמונות
        PictureBox pendingImage1;// מאחסן את התמונה הראשונה שהפכו
        PictureBox pendingImage2;// מאחסן את התמונה השניה שהפכו

        public Form()
        {
            InitializeComponent();
           

        }

        private void btname1_Click(object sender, EventArgs e)
        {
            pOne.Text = txtbx1.Text;
        }
        private void btname2_Click(object sender, EventArgs e)
        {
            pTwo.Text = txtbx2.Text;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private void button1_Click(object sender, EventArgs e) //המסך שמונה על חמש  
        {
            foreach (PictureBox picture in gameholder.Controls)
            {
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            foreach (PictureBox picture in gameholder.Controls) // עבור כול תמונה
            {

                picture.Enabled = false;// לא ניתן לגעת בהן כי הן הפוכות (ניתן לראות את התמנה
                points.Add(picture.Location); // מערבב את המיקומים 
            }
            foreach (PictureBox picture in gameholder.Controls) //צריך פוראיצ שונים ולא להכניס באותו אחד כי אם נכניס באותו אחד הפונקציית ראנדום לא תעבוד
            {
                int next = location.Next(points.Count);
                Point p = points[next];
                picture.Location = p;
                points.Remove(p);
            }
            scorecounter1.Visible = true; scorecounter2.Visible = true;
            timer1.Start();
            timer2.Start();
            label2.Visible = true;
            label1.Visible = true;
            gameholder.Visible = true;
            btn1.Hide();
            btn3.Hide();
            btn2.Hide();
            lbl.Hide();
            btname2.Hide();
            btname1.Hide();
            txtbx2.Hide();
            txtbx1.Hide();
            LblName1.Visible = true;
            pTwo.Visible = true;
            pOne.Visible = true;
           // btnewGame.Visible = true;
            LblName1.Visible = true; LblName2.Visible = true; LblNikod1.Visible = true; LblNikod2.Visible = true; gameholder.Visible = true;
        }

        private void btn2_Click(object sender, EventArgs e)//מסך 4 על 4
        {
            foreach (PictureBox picture in gameholder.Controls)
            {
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            PictureBox[] arrpic = new PictureBox[16]; // מערך תמונות כדי שלא יערבב את התמונות עם כול התמונות בלוח
            arrpic[0] = pic6; arrpic[1] = pic7; arrpic[2] = pic10; arrpic[3] = pic11; arrpic[4] = pic14; arrpic[5] = pic15; arrpic[6] = pic18; arrpic[7] = pic19;
            arrpic[8] = DuPic6; arrpic[9] = DuPic7; arrpic[10] = DuPic10; arrpic[11] = DuPic11; arrpic[12] = DuPic14; arrpic[13] = DuPic15; arrpic[14] = DuPic18; arrpic[15] = DuPic19;

            foreach (PictureBox picture in arrpic) 
            {
                picture.Enabled = false;// לא ניתן לגעת בהן כי הן הפוכות (ניתן לראות את התמנה
                points.Add(picture.Location); // מערבב את המיקומים 
            }
            foreach (PictureBox picture in arrpic) //צריך פוראיצ שונים ולא להכניס באותו אחד כי אם נכניס באותו אחד הפונקציית ראנדום לא תעבוד
            {
                int next = location.Next(points.Count);
                Point p = points[next];
                picture.Location = p;
                points.Remove(p);
            }
            scorecounter1.Visible = true; scorecounter2.Visible = true;
            timer1.Start();
            timer2.Start();
            label2.Visible = true;
            label1.Visible = true;

            gameholder.Visible = true;
            foreach (PictureBox picture in gameholder.Controls)
            {
                picture.Hide();
            }
            pic6.Visible = true; pic7.Visible = true; pic10.Visible = true; pic11.Visible = true; pic14.Visible = true; pic15.Visible = true; pic18.Visible = true; pic19.Visible = true; DuPic6.Visible = true; DuPic7.Visible = true; DuPic10.Visible = true; DuPic11.Visible = true; DuPic14.Visible = true; DuPic15.Visible = true; DuPic18.Visible = true; DuPic19.Visible = true;
            gameholder.Visible = true;
            btn1.Hide();
            btn3.Hide();
            btn2.Hide();
            lbl.Hide();
            btname2.Hide();
            btname1.Hide();
            txtbx2.Hide();
            txtbx1.Hide();
            LblName1.Visible = true;
            pTwo.Visible = true;
            pOne.Visible = true;
          //  btnewGame.Visible = true;
            LblName1.Visible = true; LblName2.Visible = true; LblNikod1.Visible = true; LblNikod2.Visible = true; gameholder.Visible = true;
        }

        private void btn3_Click(object sender, EventArgs e)//מסך ארבע על5 
        {

            foreach (PictureBox picture in gameholder.Controls)
            {
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            PictureBox[] arrpic = new PictureBox[20]; // מערך תמונות כדי שלא יערבב את התמונות עם כול התמונות בלוח
            arrpic[0] = pic6; arrpic[1] = pic5; arrpic[2] = pic10; arrpic[3] = pic9; arrpic[4] = pic14; arrpic[5] = pic13; arrpic[6] = pic18; arrpic[7] = pic17;
            arrpic[8] = DuPic6; arrpic[9] = DuPic5; arrpic[10] = DuPic10; arrpic[11] = DuPic9; arrpic[12] = DuPic14; arrpic[13] = DuPic13; arrpic[14] = DuPic18; arrpic[15] = DuPic17;
            arrpic[16] = DuPic1; arrpic[17] = DuPic2; arrpic[18] = pic1; arrpic[19] = pic2;
            foreach (PictureBox picture in arrpic)
            {
                picture.Enabled = false;// לא ניתן לגעת בהן כי הן הפוכות (ניתן לראות את התמנה
                points.Add(picture.Location); // מערבב את המיקומים 
            }
            foreach (PictureBox picture in arrpic) //צריך פוראיצ שונים ולא להכניס באותו אחד כי אם נכניס באותו אחד הפונקציית ראנדום לא תעבוד
            {
                int next = location.Next(points.Count);
                Point p = points[next];
                picture.Location = p;
                points.Remove(p);
            }
            scorecounter1.Visible = true; scorecounter2.Visible = true;
            timer1.Start();
            timer2.Start();
            label2.Visible = true;
            label1.Visible = true;
            gameholder.Visible = true;
            foreach (PictureBox picture in gameholder.Controls)
            {
                picture.Hide();
            }
            DuPic2.Visible = true; DuPic1.Visible = true; pic2.Visible = true; pic1.Visible = true; pic6.Visible = true; pic5.Visible = true; pic10.Visible = true; pic9.Visible = true; pic14.Visible = true; pic13.Visible = true; pic18.Visible = true; pic17.Visible = true; DuPic6.Visible = true; DuPic5.Visible = true; DuPic10.Visible = true; DuPic9.Visible = true; DuPic14.Visible = true; DuPic13.Visible = true; DuPic18.Visible = true; DuPic17.Visible = true;
            gameholder.Visible = true;
            btn1.Hide();
            btn3.Hide();
            btn2.Hide();
            lbl.Hide();
            btname2.Hide();
            btname1.Hide();
            txtbx2.Hide();
            txtbx1.Hide();
            LblName1.Visible = true;
            pTwo.Visible = true;
            pOne.Visible = true;
          //  btnewGame.Visible = true;
            LblName1.Visible = true; LblName2.Visible = true; LblNikod1.Visible = true; LblNikod2.Visible = true; gameholder.Visible = true;


        }

       
        private void btnewGame_Click(object sender, EventArgs e) // לא צלח 
        {
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop(); // טימר עוצר
            foreach (PictureBox picture in gameholder.Controls)// מגדירים לכול התמונות
            {
                picture.Enabled = true;// ניתן לגעת בהן כי חלפו 5 שניות והן התהפכו
                picture.Cursor = Cursors.Hand;// העכבר הופך ליד כי זה יפה וגם שהשינוי שאפשר כעט לגעת יהיה חזותי
                picture.BackgroundImage = Properties.Resources.back;
                picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;// כול התמונות מתהפכות
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            int timer = Convert.ToInt32(label1.Text); // משנים את ערך התווית למספר כי הוא בעצם סטרינג
            timer = timer - 1; // מתחילים לספור לאחור
            label1.Text = Convert.ToString(timer); // מציג את הזמן שבטימר והופך לסטרינג כי הזממן הוא מספר ומספר שלם זה אינט
            if (timer == 0) // כאשר מגיע לאפס
            {
                timer2.Stop(); // טימר 2 עוצר
                label1.Hide();
                label2.Hide();
            }

        }

        bool one = true;
        bool two = false;

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Stop();// עוצר את הטימר
            pendingImage1.Image = Properties.Resources.back;// הופך את התמונה הראשונה
            pendingImage2.Image = Properties.Resources.back;// הופך את התמונה השניה
            pendingImage1 = null;// מרוקן את התמונה המחליפה
            pendingImage2 = null;// מרוקן את התמונה השניה המחליפה
            if (one == true)
            {
                one = false;
                two = true;
            }
            if (one == false)
            {
                two = false;
                one = true;
            }
        }
         
    #region CARDS
    private void pic1_Click_1(object sender, EventArgs e)
        {
            foreach (PictureBox picture in gameholder.Controls)
            {
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            pic1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pic1.Image = Properties.Resources.pic1;// כאשר לוחצים על התמונה היא משתנה מהתמונת רקע לתמונה שהיא
           
            if (pendingImage1 == null)// אם המחליף הראשון ריק
            {
                pendingImage1 = pic1;// מכניסים לתוכו את התמונה שנלחצה ראשונה
            }
            else if (pendingImage1 != null && pendingImage2 == null)// אם הוא מלא והמחליף השני ריק 
            {
                pendingImage2 = pic1;// מכניסים למחליף השני את התמונה שנלחצה והיא התמונה שנלחצה שניה
            }
            if (pendingImage1 != null && pendingImage2 != null)// אם שני המחליפים מלאים 
            {// בודקים אם יש להם אותו טאג///////////////////
                if (pendingImage1.Tag == pendingImage2.Tag) // אם כן 
                {
                    pendingImage2 = null;// מרוקנים את שני המחליפי
                    pendingImage1 = null;
                    pic1.Enabled = false; //בכדי שלא נוכל ללחוץ עליהם שוב לאחר שהתהפכו
                    DuPic1.Enabled = false;
                    if (one == true)
                    {
                        scorecounter1.Text = Convert.ToString(Convert.ToInt32(scorecounter1.Text) + 10); // מעלים ניקוד
                        one = false;//מכבים את אחד
                        two = true;
                    }
                    else
                        if (one == false)
                    {
                        scorecounter2.Text = Convert.ToString(Convert.ToInt32(scorecounter2.Text) + 10); // מעלים ניקוד
                        one = true;//מכבים את אחד
                        two = false;
                    }

                }
                else // אם הטגים לא שווים
                {
                    timer3.Start(); // מפעילים את טיימר שלוש שהוא 3 שניות ואז 2 תמונות מתהפכות חזרה וכולי
                }
            }
        }

        private void DuPic1_Click_1(object sender, EventArgs e)
        {
            DuPic1.Image = Properties.Resources.pic1;
            if (pendingImage1 == null)
            {
                pendingImage1 = DuPic1;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = DuPic1;
            }
            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage2 = null;
                    pendingImage1 = null;
                    pic1.Enabled = false;
                    DuPic1.Enabled = false;
                    if (one == true)
                    {
                        scorecounter1.Text = Convert.ToString(Convert.ToInt32(scorecounter1.Text) + 10); // מעלים ניקוד
                        one = false;//מכבים את אחד
                        two = true;
                    }
                    else
                        if (one == false)
                    {
                        scorecounter2.Text = Convert.ToString(Convert.ToInt32(scorecounter2.Text) + 10); // מעלים ניקוד
                        one = true;//מכבים את אחד
                        two = false;
                    }

                }
                else // אם הטגים לא שווים
                {
                    timer3.Start(); // מפעילים את טיימר שלוש שהוא 3 שניות ואז 2 תמונות מתהפכות חזרה וכולי
                }
            }
        }

        private void pic2_Click(object sender, EventArgs e)
        {
            pic2.Image = Properties.Resources.pic2;
            if (pendingImage1 == null)
            {
                pendingImage1 = pic2;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = pic2;
            }
            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage2 = null;
                    pendingImage1 = null;
                    pic2.Enabled = false; //שלא נוכל ללחוץ עליהם שוב לאחר שהתהפכו
                    DuPic2.Enabled = false;
                    if (one == true)
                    {
                        scorecounter1.Text = Convert.ToString(Convert.ToInt32(scorecounter1.Text) + 10); // מעלים ניקוד
                        one = false;//מכבים את אחד
                        two = true;
                    }
                    else
                       if (one == false)
                    {
                        scorecounter2.Text = Convert.ToString(Convert.ToInt32(scorecounter2.Text) + 10); // מעלים ניקוד
                        one = true;//מכבים את אחד
                        two = false;
                    }

                }
                else // אם הטגים לא שווים
                {
                    timer3.Start(); // מפעילים את טיימר שלוש שהוא 3 שניות ואז 2 תמונות מתהפכות חזרה וכולי
                }
            }
        }

        private void DuPic2_Click(object sender, EventArgs e)
        {
            DuPic2.Image = Properties.Resources.pic2;
            if (pendingImage1 == null)
            {
                pendingImage1 = DuPic2;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = DuPic2;
            }
            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage2 = null;
                    pendingImage1 = null;
                    pic2.Enabled = false; //שלא נוכל ללחוץ עליהם שוב לאחר שהתהפכו
                    DuPic2.Enabled = false;
                    if (one == true)
                    {
                        scorecounter1.Text = Convert.ToString(Convert.ToInt32(scorecounter1.Text) + 10); // מעלים ניקוד
                        one = false;//מכבים את אחד
                        two = true;
                    }
                    else
                       if (one == false)
                    {
                        scorecounter2.Text = Convert.ToString(Convert.ToInt32(scorecounter2.Text) + 10); // מעלים ניקוד
                        one = true;//מכבים את אחד
                        two = false;
                    }

                }
                else // אם הטגים לא שווים
                {
                    timer3.Start(); // מפעילים את טיימר שלוש שהוא 3 שניות ואז 2 תמונות מתהפכות חזרה וכולי
                }
            }
        }

        private void pic3_Click(object sender, EventArgs e)
        {
            pic3.Image = Properties.Resources.pic3;
            if (pendingImage1 == null)
            {
                pendingImage1 = pic3;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = pic3;
            }
            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage2 = null;
                    pendingImage1 = null;
                    pic3.Enabled = false; //שלא נוכל ללחוץ עליהם שוב לאחר שהתהפכו
                    DuPic3.Enabled = false;
                    if (one == true)
                    {
                        scorecounter1.Text = Convert.ToString(Convert.ToInt32(scorecounter1.Text) + 10); // מעלים ניקוד
                        one = false;//מכבים את אחד
                        two = true;
                    }
                    else
                       if (one == false)
                    {
                        scorecounter2.Text = Convert.ToString(Convert.ToInt32(scorecounter2.Text) + 10); // מעלים ניקוד
                        one = true;//מכבים את אחד
                        two = false;
                    }

                }
                else // אם הטגים לא שווים
                {
                    timer3.Start(); // מפעילים את טיימר שלוש שהוא 3 שניות ואז 2 תמונות מתהפכות חזרה וכולי
                }
            }
        }

        private void DuPic3_Click(object sender, EventArgs e)
        {
            DuPic3.Image = Properties.Resources.pic3;
            if (pendingImage1 == null)
            {
                pendingImage1 = DuPic3;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = DuPic3;
            }
            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage2 = null;
                    pendingImage1 = null;
                    pic3.Enabled = false; //שלא נוכל ללחוץ עליהם שוב לאחר שהתהפכו
                    DuPic3.Enabled = false;
                    if (one == true)
                    {
                        scorecounter1.Text = Convert.ToString(Convert.ToInt32(scorecounter1.Text) + 10); // מעלים ניקוד
                        one = false;//מכבים את אחד
                        two = true;
                    }
                    else
                        if (one == false)
                    {
                        scorecounter2.Text = Convert.ToString(Convert.ToInt32(scorecounter2.Text) + 10); // מעלים ניקוד
                        one = true;//מכבים את אחד
                        two = false;
                    }

                }
                else // אם הטגים לא שווים
                {
                    timer3.Start(); // מפעילים את טיימר שלוש שהוא 3 שניות ואז 2 תמונות מתהפכות חזרה וכולי
                }
            }
        }

        private void pic4_Click(object sender, EventArgs e)
        {
            pic4.Image = Properties.Resources.pic4;
            if (pendingImage1 == null)
            {
                pendingImage1 = pic4;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = pic4;
            }
            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage2 = null;
                    pendingImage1 = null;
                    pic4.Enabled = false; //שלא נוכל ללחוץ עליהם שוב לאחר שהתהפכו
                    DuPic4.Enabled = false;
                    if (one == true)
                    {
                        scorecounter1.Text = Convert.ToString(Convert.ToInt32(scorecounter1.Text) + 10); // מעלים ניקוד
                        one = false;//מכבים את אחד
                        two = true;
                    }
                    else
                        if (one == false)
                    {
                        scorecounter2.Text = Convert.ToString(Convert.ToInt32(scorecounter2.Text) + 10); // מעלים ניקוד
                        one = true;//מכבים את אחד
                        two = false;
                    }

                }
                else // אם הטגים לא שווים
                {
                    timer3.Start(); // מפעילים את טיימר שלוש שהוא 3 שניות ואז 2 תמונות מתהפכות חזרה וכולי
                }
            }
        }

        private void DuPic4_Click(object sender, EventArgs e)
        {
            DuPic4.Image = Properties.Resources.pic4;
            if (pendingImage1 == null)
            {
                pendingImage1 = DuPic4;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = DuPic4;
            }
            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage2 = null;
                    pendingImage1 = null;
                    pic4.Enabled = false; //שלא נוכל ללחוץ עליהם שוב לאחר שהתהפכו
                    DuPic4.Enabled = false;
                    if (one == true)
                    {
                        scorecounter1.Text = Convert.ToString(Convert.ToInt32(scorecounter1.Text) + 10); // מעלים ניקוד
                        one = false;//מכבים את אחד
                        two = true;
                    }
                    else
                        if (one == false)
                    {
                        scorecounter2.Text = Convert.ToString(Convert.ToInt32(scorecounter2.Text) + 10); // מעלים ניקוד
                        one = true;//מכבים את אחד
                        two = false;
                    }

                }
                else // אם הטגים לא שווים
                {
                    timer3.Start(); // מפעילים את טיימר שלוש שהוא 3 שניות ואז 2 תמונות מתהפכות חזרה וכולי
                }
            }
        
    }

        private void pic5_Click(object sender, EventArgs e)
        {
            pic5.Image = Properties.Resources.pic5;
            if (pendingImage1 == null)
            {
                pendingImage1 = pic5;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = pic5;
            }
            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage2 = null;
                    pendingImage1 = null;
                    pic5.Enabled = false; //שלא נוכל ללחוץ עליהם שוב לאחר שהתהפכו
                    DuPic5.Enabled = false;
                    if (one == true)
                    {
                        scorecounter1.Text = Convert.ToString(Convert.ToInt32(scorecounter1.Text) + 10); // מעלים ניקוד
                        one = false;//מכבים את אחד
                        two = true;
                    }
                    else
                       if (one == false)
                    {
                        scorecounter2.Text = Convert.ToString(Convert.ToInt32(scorecounter2.Text) + 10); // מעלים ניקוד
                        one = true;//מכבים את אחד
                        two = false;
                    }

                }
                else // אם הטגים לא שווים
                {
                    timer3.Start(); // מפעילים את טיימר שלוש שהוא 3 שניות ואז 2 תמונות מתהפכות חזרה וכולי
                }
            }
        }

        private void DuPic5_Click(object sender, EventArgs e)
        {
            DuPic5.Image = Properties.Resources.pic5;
            if (pendingImage1 == null)
            {
                pendingImage1 = DuPic5;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = DuPic5;
            }
            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage2 = null;
                    pendingImage1 = null;
                    pic5.Enabled = false; //שלא נוכל ללחוץ עליהם שוב לאחר שהתהפכו
                    DuPic5.Enabled = false;
                    if (one == true)
                    {
                        scorecounter1.Text = Convert.ToString(Convert.ToInt32(scorecounter1.Text) + 10); // מעלים ניקוד
                        one = false;//מכבים את אחד
                        two = true;
                    }
                    else
                        if (one == false)
                    {
                        scorecounter2.Text = Convert.ToString(Convert.ToInt32(scorecounter2.Text) + 10); // מעלים ניקוד
                        one = true;//מכבים את אחד
                        two = false;
                    }

                }
                else // אם הטגים לא שווים
                {
                    timer3.Start(); // מפעילים את טיימר שלוש שהוא 3 שניות ואז 2 תמונות מתהפכות חזרה וכולי
                }
            }
        }

        private void pic6_Click(object sender, EventArgs e)
        {
            pic6.Image = Properties.Resources.pic6;
            if (pendingImage1 == null)
            {
                pendingImage1 = pic6;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = pic6;
            }
            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage2 = null;
                    pendingImage1 = null;
                    pic6.Enabled = false; //שלא נוכל ללחוץ עליהם שוב לאחר שהתהפכו
                    DuPic6.Enabled = false;
                    if (one == true)
                    {
                        scorecounter1.Text = Convert.ToString(Convert.ToInt32(scorecounter1.Text) + 10); // מעלים ניקוד
                        one = false;//מכבים את אחד
                        two = true;
                    }
                    else
                                           if (one == false)
                    {
                        scorecounter2.Text = Convert.ToString(Convert.ToInt32(scorecounter2.Text) + 10); // מעלים ניקוד
                        one = true;//מכבים את אחד
                        two = false;
                    }

                }
                else // אם הטגים לא שווים
                {
                    timer3.Start(); // מפעילים את טיימר שלוש שהוא 3 שניות ואז 2 תמונות מתהפכות חזרה וכולי
                }
            }
        }

        private void DuPic6_Click(object sender, EventArgs e)
        {
            DuPic6.Image = Properties.Resources.pic6;
            if (pendingImage1 == null)
            {
                pendingImage1 = DuPic6;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = DuPic6;
            }
            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage2 = null;
                    pendingImage1 = null;
                    pic6.Enabled = false; //שלא נוכל ללחוץ עליהם שוב לאחר שהתהפכו
                    DuPic6.Enabled = false;
                    if (one == true)
                    {
                        scorecounter1.Text = Convert.ToString(Convert.ToInt32(scorecounter1.Text) + 10); // מעלים ניקוד
                        one = false;//מכבים את אחד
                        two = true;
                    }
                    else
                       if (one == false)
                    {
                        scorecounter2.Text = Convert.ToString(Convert.ToInt32(scorecounter2.Text) + 10); // מעלים ניקוד
                        one = true;//מכבים את אחד
                        two = false;
                    }

                }
                else // אם הטגים לא שווים
                {
                    timer3.Start(); // מפעילים את טיימר שלוש שהוא 3 שניות ואז 2 תמונות מתהפכות חזרה וכולי
                }
            }
        }

        private void pic7_Click(object sender, EventArgs e)
        {
            pic7.Image = Properties.Resources.pic7;
            if (pendingImage1 == null)
            {
                pendingImage1 = pic7;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = pic7;
            }
            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage2 = null;
                    pendingImage1 = null;
                    pic7.Enabled = false; //שלא נוכל ללחוץ עליהם שוב לאחר שהתהפכו
                    DuPic7.Enabled = false;
                    if (one == true)
                    {
                        scorecounter1.Text = Convert.ToString(Convert.ToInt32(scorecounter1.Text) + 10); // מעלים ניקוד
                        one = false;//מכבים את אחד
                        two = true;
                    }
                    else
                        if (one == false)
                    {
                        scorecounter2.Text = Convert.ToString(Convert.ToInt32(scorecounter2.Text) + 10); // מעלים ניקוד
                        one = true;//מכבים את אחד
                        two = false;
                    }

                }
                else // אם הטגים לא שווים
                {
                    timer3.Start(); // מפעילים את טיימר שלוש שהוא 3 שניות ואז 2 תמונות מתהפכות חזרה וכולי
                }
            }
        }

        private void DuPic7_Click(object sender, EventArgs e)
        {
            DuPic7.Image = Properties.Resources.pic7;
            if (pendingImage1 == null)
            {
                pendingImage1 = DuPic7;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = DuPic7;
            }
            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage2 = null;
                    pendingImage1 = null;
                    pic7.Enabled = false; //שלא נוכל ללחוץ עליהם שוב לאחר שהתהפכו
                    DuPic7.Enabled = false;
                    if (one == true)
                    {
                        scorecounter1.Text = Convert.ToString(Convert.ToInt32(scorecounter1.Text) + 10); // מעלים ניקוד
                        one = false;//מכבים את אחד
                        two = true;
                    }
                    else
                       if (one == false)
                    {
                        scorecounter2.Text = Convert.ToString(Convert.ToInt32(scorecounter2.Text) + 10); // מעלים ניקוד
                        one = true;//מכבים את אחד
                        two = false;
                    }

                }
                else // אם הטגים לא שווים
                {
                    timer3.Start(); // מפעילים את טיימר שלוש שהוא 3 שניות ואז 2 תמונות מתהפכות חזרה וכולי
                }
            }
        }

        private void pic8_Click(object sender, EventArgs e)
        {
            pic8.Image = Properties.Resources.pic8;
            if (pendingImage1 == null)
            {
                pendingImage1 = pic8;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = DuPic8;
            }
            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage2 = null;
                    pendingImage1 = null;
                    pic8.Enabled = false; //שלא נוכל ללחוץ עליהם שוב לאחר שהתהפכו
                    DuPic8.Enabled = false;
                    if (one == true)
                    {
                        scorecounter1.Text = Convert.ToString(Convert.ToInt32(scorecounter1.Text) + 10); // מעלים ניקוד
                        one = false;//מכבים את אחד
                        two = true;
                    }
                    else
                       if (one == false)
                    {
                        scorecounter2.Text = Convert.ToString(Convert.ToInt32(scorecounter2.Text) + 10); // מעלים ניקוד
                        one = true;//מכבים את אחד
                        two = false;
                    }

                }
                else // אם הטגים לא שווים
                {
                    timer3.Start(); // מפעילים את טיימר שלוש שהוא 3 שניות ואז 2 תמונות מתהפכות חזרה וכולי
                }
            }
        }

        private void DuPic8_Click(object sender, EventArgs e)
        {
            DuPic8.Image = Properties.Resources.pic8;
            if (pendingImage1 == null)
            {
                pendingImage1 = DuPic8;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = DuPic8;
            }
            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage2 = null;
                    pendingImage1 = null;
                    pic8.Enabled = false; //שלא נוכל ללחוץ עליהם שוב לאחר שהתהפכו
                    DuPic8.Enabled = false;
                    if (one == true)
                    {
                        scorecounter1.Text = Convert.ToString(Convert.ToInt32(scorecounter1.Text) + 10); // מעלים ניקוד
                        one = false;//מכבים את אחד
                        two = true;
                    }
                    else
                        if (one == false)
                    {
                        scorecounter2.Text = Convert.ToString(Convert.ToInt32(scorecounter2.Text) + 10); // מעלים ניקוד
                        one = true;//מכבים את אחד
                        two = false;
                    }

                }
                else // אם הטגים לא שווים
                {
                    timer3.Start(); // מפעילים את טיימר שלוש שהוא 3 שניות ואז 2 תמונות מתהפכות חזרה וכולי
                }
            }
        }

        private void pic9_Click(object sender, EventArgs e)
        {

            pic9.Image = Properties.Resources.pic9;
            if (pendingImage1 == null)
            {
                pendingImage1 = pic9;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = pic9;
            }
            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage2 = null;
                    pendingImage1 = null;
                    pic9.Enabled = false; //שלא נוכל ללחוץ עליהם שוב לאחר שהתהפכו
                    DuPic9.Enabled = false;
                    if (one == true)
                    {
                        scorecounter1.Text = Convert.ToString(Convert.ToInt32(scorecounter1.Text) + 10); // מעלים ניקוד
                        one = false;//מכבים את אחד
                        two = true;
                    }
                    else
                       if (one == false)
                    {
                        scorecounter2.Text = Convert.ToString(Convert.ToInt32(scorecounter2.Text) + 10); // מעלים ניקוד
                        one = true;//מכבים את אחד
                        two = false;
                    }

                }
                else // אם הטגים לא שווים
                {
                    timer3.Start(); // מפעילים את טיימר שלוש שהוא 3 שניות ואז 2 תמונות מתהפכות חזרה וכולי
                }
            }
        }

        private void DuPic9_Click(object sender, EventArgs e)
        {
            DuPic9.Image = Properties.Resources.pic9;
            if (pendingImage1 == null)
            {
                pendingImage1 = DuPic9;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = DuPic9;
            }
            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage2 = null;
                    pendingImage1 = null;
                    pic9.Enabled = false; //שלא נוכל ללחוץ עליהם שוב לאחר שהתהפכו
                    DuPic9.Enabled = false;
                    if (one == true)
                    {
                        scorecounter1.Text = Convert.ToString(Convert.ToInt32(scorecounter1.Text) + 10); // מעלים ניקוד
                        one = false;//מכבים את אחד
                        two = true;
                    }
                    else
                       if (one == false)
                    {
                        scorecounter2.Text = Convert.ToString(Convert.ToInt32(scorecounter2.Text) + 10); // מעלים ניקוד
                        one = true;//מכבים את אחד
                        two = false;
                    }

                }
                else // אם הטגים לא שווים
                {
                    timer3.Start(); // מפעילים את טיימר שלוש שהוא 3 שניות ואז 2 תמונות מתהפכות חזרה וכולי
                }
            }
        }

        private void pic10_Click(object sender, EventArgs e)
        {
            pic10.Image = Properties.Resources.pic10;
            if (pendingImage1 == null)
            {
                pendingImage1 = DuPic10;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = DuPic10;
            }
            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage2 = null;
                    pendingImage1 = null;
                    pic10.Enabled = false; //שלא נוכל ללחוץ עליהם שוב לאחר שהתהפכו
                    DuPic10.Enabled = false;
                    if (one == true)
                    {
                        scorecounter1.Text = Convert.ToString(Convert.ToInt32(scorecounter1.Text) + 10); // מעלים ניקוד
                        one = false;//מכבים את אחד
                        two = true;
                    }
                    else
                        if (one == false)
                    {
                        scorecounter2.Text = Convert.ToString(Convert.ToInt32(scorecounter2.Text) + 10); // מעלים ניקוד
                        one = true;//מכבים את אחד
                        two = false;
                    }

                }
                else // אם הטגים לא שווים
                {
                    timer3.Start(); // מפעילים את טיימר שלוש שהוא 3 שניות ואז 2 תמונות מתהפכות חזרה וכולי
                }
            }
        }

        private void DuPic10_Click(object sender, EventArgs e)
        {
            DuPic10.Image = Properties.Resources.pic10;
            if (pendingImage1 == null)
            {
                pendingImage1 = DuPic10;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = DuPic10;
            }
            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage2 = null;
                    pendingImage1 = null;
                    pic10.Enabled = false; //שלא נוכל ללחוץ עליהם שוב לאחר שהתהפכו
                    DuPic10.Enabled = false;
                    if (one == true)
                    {
                        scorecounter1.Text = Convert.ToString(Convert.ToInt32(scorecounter1.Text) + 10); // מעלים ניקוד
                        one = false;//מכבים את אחד
                        two = true;
                    }
                    else
                         if (one == false)
                    {
                        scorecounter2.Text = Convert.ToString(Convert.ToInt32(scorecounter2.Text) + 10); // מעלים ניקוד
                        one = true;//מכבים את אחד
                        two = false;
                    }

                }
                else // אם הטגים לא שווים
                {
                    timer3.Start(); // מפעילים את טיימר שלוש שהוא 3 שניות ואז 2 תמונות מתהפכות חזרה וכולי
                }
            }
        }

        private void pic11_Click(object sender, EventArgs e)
        {
            pic11.Image = Properties.Resources.pic11;
            if (pendingImage1 == null)
            {
                pendingImage1 = pic11;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = pic11;
            }
            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage2 = null;
                    pendingImage1 = null;
                    pic11.Enabled = false; //שלא נוכל ללחוץ עליהם שוב לאחר שהתהפכו
                    DuPic11.Enabled = false;
                    if (one == true)
                    {
                        scorecounter1.Text = Convert.ToString(Convert.ToInt32(scorecounter1.Text) + 10); // מעלים ניקוד
                        one = false;//מכבים את אחד
                        two = true;
                    }
                    else
                        if (one == false)
                    {
                        scorecounter2.Text = Convert.ToString(Convert.ToInt32(scorecounter2.Text) + 10); // מעלים ניקוד
                        one = true;//מכבים את אחד
                        two = false;
                    }

                }
                else // אם הטגים לא שווים
                {
                    timer3.Start(); // מפעילים את טיימר שלוש שהוא 3 שניות ואז 2 תמונות מתהפכות חזרה וכולי
                }
            }
        }

        private void DuPic11_Click(object sender, EventArgs e)
        {
            DuPic11.Image = Properties.Resources.pic11;
            if (pendingImage1 == null)
            {
                pendingImage1 = DuPic11;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = DuPic11;
            }
            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage2 = null;
                    pendingImage1 = null;
                    pic11.Enabled = false; //שלא נוכל ללחוץ עליהם שוב לאחר שהתהפכו
                    DuPic11.Enabled = false;
                    if (one == true)
                    {
                        scorecounter1.Text = Convert.ToString(Convert.ToInt32(scorecounter1.Text) + 10); // מעלים ניקוד
                        one = false;//מכבים את אחד
                        two = true;
                    }
                    else
                        if (one == false)
                    {
                        scorecounter2.Text = Convert.ToString(Convert.ToInt32(scorecounter2.Text) + 10); // מעלים ניקוד
                        one = true;//מכבים את אחד
                        two = false;
                    }

                }
                else // אם הטגים לא שווים
                {
                    timer3.Start(); // מפעילים את טיימר שלוש שהוא 3 שניות ואז 2 תמונות מתהפכות חזרה וכולי
                }
            }
        }

        private void pic12_Click(object sender, EventArgs e)
        {
            pic12.Image = Properties.Resources.pic12;
            if (pendingImage1 == null)
            {
                pendingImage1 = pic12;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = pic12;
            }
            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage2 = null;
                    pendingImage1 = null;
                    pic12.Enabled = false; //שלא נוכל ללחוץ עליהם שוב לאחר שהתהפכו
                    DuPic12.Enabled = false;
                    if (one == true)
                    {
                        scorecounter1.Text = Convert.ToString(Convert.ToInt32(scorecounter1.Text) + 10); // מעלים ניקוד
                        one = false;//מכבים את אחד
                        two = true;
                    }
                    else
                       if (one == false)
                    {
                        scorecounter2.Text = Convert.ToString(Convert.ToInt32(scorecounter2.Text) + 10); // מעלים ניקוד
                        one = true;//מכבים את אחד
                        two = false;
                    }

                }
                else // אם הטגים לא שווים
                {
                    timer3.Start(); // מפעילים את טיימר שלוש שהוא 3 שניות ואז 2 תמונות מתהפכות חזרה וכולי
                }
            }
        }

        private void DuPic12_Click(object sender, EventArgs e)
        {
            DuPic12.Image = Properties.Resources.pic12;
            if (pendingImage1 == null)
            {
                pendingImage1 = DuPic12;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = DuPic12;
            }
            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage2 = null;
                    pendingImage1 = null;
                    pic12.Enabled = false; //שלא נוכל ללחוץ עליהם שוב לאחר שהתהפכו
                    DuPic12.Enabled = false;
                    if (one == true)
                    {
                        scorecounter1.Text = Convert.ToString(Convert.ToInt32(scorecounter1.Text) + 10); // מעלים ניקוד
                        one = false;//מכבים את אחד
                        two = true;
                    }
                    else
                         if (one == false)
                    {
                        scorecounter2.Text = Convert.ToString(Convert.ToInt32(scorecounter2.Text) + 10); // מעלים ניקוד
                        one = true;//מכבים את אחד
                        two = false;
                    }

                }
                else // אם הטגים לא שווים
                {
                    timer3.Start(); // מפעילים את טיימר שלוש שהוא 3 שניות ואז 2 תמונות מתהפכות חזרה וכולי
                }
            }
        }

        private void pic13_Click(object sender, EventArgs e)
        {
            pic13.Image = Properties.Resources.pic13;
            if (pendingImage1 == null)
            {
                pendingImage1 = pic13;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = pic13;
            }
            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage2 = null;
                    pendingImage1 = null;
                    pic13.Enabled = false; //שלא נוכל ללחוץ עליהם שוב לאחר שהתהפכו
                    DuPic13.Enabled = false;
                    if (one == true)
                    {
                        scorecounter1.Text = Convert.ToString(Convert.ToInt32(scorecounter1.Text) + 10); // מעלים ניקוד
                        one = false;//מכבים את אחד
                        two = true;
                    }
                    else
                          if (one == false)
                    {
                        scorecounter2.Text = Convert.ToString(Convert.ToInt32(scorecounter2.Text) + 10); // מעלים ניקוד
                        one = true;//מכבים את אחד
                        two = false;
                    }

                }
                else // אם הטגים לא שווים
                {
                    timer3.Start(); // מפעילים את טיימר שלוש שהוא 3 שניות ואז 2 תמונות מתהפכות חזרה וכולי
                }
            }
        }

        private void DuPic13_Click(object sender, EventArgs e)
        {

            DuPic13.Image = Properties.Resources.pic13;
            if (pendingImage1 == null)
            {
                pendingImage1 = DuPic13;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = DuPic13;
            }
            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage2 = null;
                    pendingImage1 = null;
                    pic13.Enabled = false; //שלא נוכל ללחוץ עליהם שוב לאחר שהתהפכו
                    DuPic13.Enabled = false;
                    if (one == true)
                    {
                        scorecounter1.Text = Convert.ToString(Convert.ToInt32(scorecounter1.Text) + 10); // מעלים ניקוד
                        one = false;//מכבים את אחד
                        two = true;
                    }
                    else
                        if (one == false)
                    {
                        scorecounter2.Text = Convert.ToString(Convert.ToInt32(scorecounter2.Text) + 10); // מעלים ניקוד
                        one = true;//מכבים את אחד
                        two = false;
                    }

                }
                else // אם הטגים לא שווים
                {
                    timer3.Start(); // מפעילים את טיימר שלוש שהוא 3 שניות ואז 2 תמונות מתהפכות חזרה וכולי
                }
            }
        }

        private void pic14_Click(object sender, EventArgs e)
        {
            pic14.Image = Properties.Resources.pic14;
            if (pendingImage1 == null)
            {
                pendingImage1 = pic14;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = pic14;
            }
            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage2 = null;
                    pendingImage1 = null;
                    pic14.Enabled = false; //שלא נוכל ללחוץ עליהם שוב לאחר שהתהפכו
                    DuPic14.Enabled = false;
                    if (one == true)
                    {
                        scorecounter1.Text = Convert.ToString(Convert.ToInt32(scorecounter1.Text) + 10); // מעלים ניקוד
                        one = false;//מכבים את אחד
                        two = true;
                    }
                    else
                       if (one == false)
                    {
                        scorecounter2.Text = Convert.ToString(Convert.ToInt32(scorecounter2.Text) + 10); // מעלים ניקוד
                        one = true;//מכבים את אחד
                        two = false;
                    }

                }
                else // אם הטגים לא שווים
                {
                    timer3.Start(); // מפעילים את טיימר שלוש שהוא 3 שניות ואז 2 תמונות מתהפכות חזרה וכולי
                }
            }
        }

        private void DuPic14_Click(object sender, EventArgs e)
        {
            DuPic14.Image = Properties.Resources.pic14;
            if (pendingImage1 == null)
            {
                pendingImage1 = DuPic14;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = DuPic14;
            }
            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage2 = null;
                    pendingImage1 = null;
                    pic14.Enabled = false; //שלא נוכל ללחוץ עליהם שוב לאחר שהתהפכו
                    DuPic14.Enabled = false;
                    if (one == true)
                    {
                        scorecounter1.Text = Convert.ToString(Convert.ToInt32(scorecounter1.Text) + 10); // מעלים ניקוד
                        one = false;//מכבים את אחד
                        two = true;
                    }
                    else
                         if (one == false)
                    {
                        scorecounter2.Text = Convert.ToString(Convert.ToInt32(scorecounter2.Text) + 10); // מעלים ניקוד
                        one = true;//מכבים את אחד
                        two = false;
                    }

                }
                else // אם הטגים לא שווים
                {
                    timer3.Start(); // מפעילים את טיימר שלוש שהוא 3 שניות ואז 2 תמונות מתהפכות חזרה וכולי
                }
            }
        }

        private void pic15_Click(object sender, EventArgs e)
        {
            pic15.Image = Properties.Resources.pic15;
            if (pendingImage1 == null)
            {
                pendingImage1 = pic15;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = pic15;
            }
            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage2 = null;
                    pendingImage1 = null;
                    pic15.Enabled = false; //שלא נוכל ללחוץ עליהם שוב לאחר שהתהפכו
                    DuPic15.Enabled = false;
                    if (one == true)
                    {
                        scorecounter1.Text = Convert.ToString(Convert.ToInt32(scorecounter1.Text) + 10); // מעלים ניקוד
                        one = false;//מכבים את אחד
                        two = true;
                    }
                    else
                         if (one == false)
                    {
                        scorecounter2.Text = Convert.ToString(Convert.ToInt32(scorecounter2.Text) + 10); // מעלים ניקוד
                        one = true;//מכבים את אחד
                        two = false;
                    }

                }
                else // אם הטגים לא שווים
                {
                    timer3.Start(); // מפעילים את טיימר שלוש שהוא 3 שניות ואז 2 תמונות מתהפכות חזרה וכולי
                }
            }
        }

        private void DuPic15_Click(object sender, EventArgs e)
        {
            DuPic15.Image = Properties.Resources.pic15;
            if (pendingImage1 == null)
            {
                pendingImage1 = DuPic15;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = DuPic15;
            }
            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage2 = null;
                    pendingImage1 = null;
                    pic15.Enabled = false; //שלא נוכל ללחוץ עליהם שוב לאחר שהתהפכו
                    DuPic15.Enabled = false;
                    if (one == true)
                    {
                        scorecounter1.Text = Convert.ToString(Convert.ToInt32(scorecounter1.Text) + 10); // מעלים ניקוד
                        one = false;//מכבים את אחד
                        two = true;
                    }
                    else
                        if (one == false)
                    {
                        scorecounter2.Text = Convert.ToString(Convert.ToInt32(scorecounter2.Text) + 10); // מעלים ניקוד
                        one = true;//מכבים את אחד
                        two = false;
                    }

                }
                else // אם הטגים לא שווים
                {
                    timer3.Start(); // מפעילים את טיימר שלוש שהוא 3 שניות ואז 2 תמונות מתהפכות חזרה וכולי
                }
            }
        }

        private void pic16_Click(object sender, EventArgs e)
        {
            pic16.Image = Properties.Resources.pic16;
            if (pendingImage1 == null)
            {
                pendingImage1 = pic16;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = pic16;
            }
            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage2 = null;
                    pendingImage1 = null;
                    pic16.Enabled = false; //שלא נוכל ללחוץ עליהם שוב לאחר שהתהפכו
                    DuPic16.Enabled = false;
                    if (one == true)
                    {
                        scorecounter1.Text = Convert.ToString(Convert.ToInt32(scorecounter1.Text) + 10); // מעלים ניקוד
                        one = false;//מכבים את אחד
                        two = true;
                    }
                    else
                       if (one == false)
                    {
                        scorecounter2.Text = Convert.ToString(Convert.ToInt32(scorecounter2.Text) + 10); // מעלים ניקוד
                        one = true;//מכבים את אחד
                        two = false;
                    }

                }
                else // אם הטגים לא שווים
                {
                    timer3.Start(); // מפעילים את טיימר שלוש שהוא 3 שניות ואז 2 תמונות מתהפכות חזרה וכולי
                }
            }
        }

        private void DuPic16_Click(object sender, EventArgs e)
        {
            DuPic16.Image = Properties.Resources.pic16;
            if (pendingImage1 == null)
            {
                pendingImage1 = DuPic16;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = DuPic16;
            }
            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage2 = null;
                    pendingImage1 = null;
                    pic16.Enabled = false; //שלא נוכל ללחוץ עליהם שוב לאחר שהתהפכו
                    DuPic16.Enabled = false;
                    if (one == true)
                    {
                        scorecounter1.Text = Convert.ToString(Convert.ToInt32(scorecounter1.Text) + 10); // מעלים ניקוד
                        one = false;//מכבים את אחד
                        two = true;
                    }
                    else
                          if (one == false)
                    {
                        scorecounter2.Text = Convert.ToString(Convert.ToInt32(scorecounter2.Text) + 10); // מעלים ניקוד
                        one = true;//מכבים את אחד
                        two = false;
                    }

                }
                else // אם הטגים לא שווים
                {
                    timer3.Start(); // מפעילים את טיימר שלוש שהוא 3 שניות ואז 2 תמונות מתהפכות חזרה וכולי
                }
            }
        }

        private void pic17_Click(object sender, EventArgs e)
        {

            pic17.Image = Properties.Resources.pic17;
            if (pendingImage1 == null)
            {
                pendingImage1 = pic17;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = pic17;
            }
            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage2 = null;
                    pendingImage1 = null;
                    pic17.Enabled = false; //שלא נוכל ללחוץ עליהם שוב לאחר שהתהפכו
                    DuPic17.Enabled = false;
                    if (one == true)
                    {
                        scorecounter1.Text = Convert.ToString(Convert.ToInt32(scorecounter1.Text) + 10); // מעלים ניקוד
                        one = false;//מכבים את אחד
                        two = true;
                    }
                    else
                         if (one == false)
                    {
                        scorecounter2.Text = Convert.ToString(Convert.ToInt32(scorecounter2.Text) + 10); // מעלים ניקוד
                        one = true;//מכבים את אחד
                        two = false;
                    }

                }
                else // אם הטגים לא שווים
                {
                    timer3.Start(); // מפעילים את טיימר שלוש שהוא 3 שניות ואז 2 תמונות מתהפכות חזרה וכולי
                }
            }
        }

        private void DuPic17_Click(object sender, EventArgs e)
        {

            DuPic17.Image = Properties.Resources.pic17;
            if (pendingImage1 == null)
            {
                pendingImage1 = DuPic17;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = DuPic17;
            }
            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage2 = null;
                    pendingImage1 = null;
                    pic17.Enabled = false; //שלא נוכל ללחוץ עליהם שוב לאחר שהתהפכו
                    DuPic17.Enabled = false;
                    if (one == true)
                    {
                        scorecounter1.Text = Convert.ToString(Convert.ToInt32(scorecounter1.Text) + 10); // מעלים ניקוד
                        one = false;//מכבים את אחד
                        two = true;
                    }
                    else
                        if (one == false)
                    {
                        scorecounter2.Text = Convert.ToString(Convert.ToInt32(scorecounter2.Text) + 10); // מעלים ניקוד
                        one = true;//מכבים את אחד
                        two = false;
                    }

                }
                else // אם הטגים לא שווים
                {
                    timer3.Start(); // מפעילים את טיימר שלוש שהוא 3 שניות ואז 2 תמונות מתהפכות חזרה וכולי
                }
            }
        }

        private void pic18_Click(object sender, EventArgs e)
        {
            pic18.Image = Properties.Resources.pic18;
            if (pendingImage1 == null)
            {
                pendingImage1 = pic18;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = pic18;
            }
            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage2 = null;
                    pendingImage1 = null;
                    pic18.Enabled = false; //שלא נוכל ללחוץ עליהם שוב לאחר שהתהפכו
                    DuPic18.Enabled = false;
                    if (one == true)
                    {
                        scorecounter1.Text = Convert.ToString(Convert.ToInt32(scorecounter1.Text) + 10); // מעלים ניקוד
                        one = false;//מכבים את אחד
                        two = true;
                    }
                    else
                        if (one == false)
                    {
                        scorecounter2.Text = Convert.ToString(Convert.ToInt32(scorecounter2.Text) + 10); // מעלים ניקוד
                        one = true;//מכבים את אחד
                        two = false;
                    }

                }
                else // אם הטגים לא שווים
                {
                    timer3.Start(); // מפעילים את טיימר שלוש שהוא 3 שניות ואז 2 תמונות מתהפכות חזרה וכולי
                }
            }
        
    }

        private void DuPic18_Click(object sender, EventArgs e)
        {
            DuPic18.Image = Properties.Resources.pic18;
            if (pendingImage1 == null)
            {
                pendingImage1 = DuPic18;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = DuPic18;
            }
            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage2 = null;
                    pendingImage1 = null;
                    pic18.Enabled = false; //שלא נוכל ללחוץ עליהם שוב לאחר שהתהפכו
                    DuPic18.Enabled = false;
                    if (one == true)
                    {
                        scorecounter1.Text = Convert.ToString(Convert.ToInt32(scorecounter1.Text) + 10); // מעלים ניקוד
                        one = false;//מכבים את אחד
                        two = true;
                    }
                    else
                        if (one == false)
                    {
                        scorecounter2.Text = Convert.ToString(Convert.ToInt32(scorecounter2.Text) + 10); // מעלים ניקוד
                        one = true;//מכבים את אחד
                        two = false;
                    }

                }
                else // אם הטגים לא שווים
                {
                    timer3.Start(); // מפעילים את טיימר שלוש שהוא 3 שניות ואז 2 תמונות מתהפכות חזרה וכולי
                }
            }
        }

        private void pic19_Click(object sender, EventArgs e)
        {

            pic19.Image = Properties.Resources.pic19;
            if (pendingImage1 == null)
            {
                pendingImage1 = pic19;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = pic19;
            }
            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage2 = null;
                    pendingImage1 = null;
                    pic19.Enabled = false; //שלא נוכל ללחוץ עליהם שוב לאחר שהתהפכו
                    DuPic19.Enabled = false;
                    if (one == true)
                    {
                        scorecounter1.Text = Convert.ToString(Convert.ToInt32(scorecounter1.Text) + 10); // מעלים ניקוד
                        one = false;//מכבים את אחד
                        two = true;
                    }
                    else
                        if (one == false)
                    {
                        scorecounter2.Text = Convert.ToString(Convert.ToInt32(scorecounter2.Text) + 10); // מעלים ניקוד
                        one = true;//מכבים את אחד
                        two = false;
                    }

                }
                else // אם הטגים לא שווים
                {
                    timer3.Start(); // מפעילים את טיימר שלוש שהוא 3 שניות ואז 2 תמונות מתהפכות חזרה וכולי
                }
            }
        }

        private void DuPic19_Click(object sender, EventArgs e)
        {
            DuPic19.Image = Properties.Resources.pic19;
            if (pendingImage1 == null)
            {
                pendingImage1 = DuPic19;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = DuPic19;
            }
            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage2 = null;
                    pendingImage1 = null;
                    pic19.Enabled = false; //שלא נוכל ללחוץ עליהם שוב לאחר שהתהפכו
                    DuPic19.Enabled = false;
                    if (one == true)
                    {
                        scorecounter1.Text = Convert.ToString(Convert.ToInt32(scorecounter1.Text) + 10); // מעלים ניקוד
                        one = false;//מכבים את אחד
                        two = true;
                    }
                    else
                       if (one == false)
                    {
                        scorecounter2.Text = Convert.ToString(Convert.ToInt32(scorecounter2.Text) + 10); // מעלים ניקוד
                        one = true;//מכבים את אחד
                        two = false;
                    }

                }
                else // אם הטגים לא שווים
                {
                    timer3.Start(); // מפעילים את טיימר שלוש שהוא 3 שניות ואז 2 תמונות מתהפכות חזרה וכולי
                }
            }
        }

        private void pic20_Click(object sender, EventArgs e)
        {
            pic20.Image = Properties.Resources.pic20;
            if (pendingImage1 == null)
            {
                pendingImage1 = pic20;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = pic20;
            }
            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage2 = null;
                    pendingImage1 = null;
                    pic20.Enabled = false; //שלא נוכל ללחוץ עליהם שוב לאחר שהתהפכו
                    DuPic20.Enabled = false;
                    if (one == true)
                    {
                        scorecounter1.Text = Convert.ToString(Convert.ToInt32(scorecounter1.Text) + 10); // מעלים ניקוד
                        one = false;//מכבים את אחד
                        two = true;
                    }
                    else
                        if (one == false)
                    {
                        scorecounter2.Text = Convert.ToString(Convert.ToInt32(scorecounter2.Text) + 10); // מעלים ניקוד
                        one = true;//מכבים את אחד
                        two = false;
                    }

                }
                else // אם הטגים לא שווים
                {
                    timer3.Start(); // מפעילים את טיימר שלוש שהוא 3 שניות ואז 2 תמונות מתהפכות חזרה וכולי
                }
            }
        }

        private void DuPic20_Click(object sender, EventArgs e)
        {
            DuPic20.Image = Properties.Resources.pic20;
            if (pendingImage1 == null)
            {
                pendingImage1 = DuPic20;
            }
            else if (pendingImage1 != null && pendingImage2 == null)
            {
                pendingImage2 = DuPic20;
            }
            if (pendingImage1 != null && pendingImage2 != null)
            {
                if (pendingImage1.Tag == pendingImage2.Tag)
                {
                    pendingImage2 = null;
                    pendingImage1 = null;
                    pic20.Enabled = false; //שלא נוכל ללחוץ עליהם שוב לאחר שהתהפכו
                    DuPic20.Enabled = false;
                    if (one == true)
                    {
                        scorecounter1.Text = Convert.ToString(Convert.ToInt32(scorecounter1.Text) + 10); // מעלים ניקוד
                        one = false;//מכבים את אחד
                        two = true;
                    }
                    else
                        if (one == false)
                    {
                        scorecounter2.Text = Convert.ToString(Convert.ToInt32(scorecounter2.Text) + 10); // מעלים ניקוד
                        one = true;//מכבים את אחד
                        two = false;
                    }

                }
                else // אם הטגים לא שווים
                {
                    timer3.Start(); // מפעילים את טיימר שלוש שהוא 3 שניות ואז 2 תמונות מתהפכות חזרה וכולי
                }
            }
        }
        #endregion

    }
}