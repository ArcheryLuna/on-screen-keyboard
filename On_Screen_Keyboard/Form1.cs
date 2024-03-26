using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace On_Screen_Keyboard
{
    public partial class Form1 : Form
    {
        public Boolean ShiftKeyToggle = false;
        public Boolean CapsLockToggle = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void key_numpad_forward_slash_Click(object sender, EventArgs e)
        {

        }

        private void toggle_left_shift_Click(object sender, EventArgs e)
        {
            ShiftKeyToggle = !ShiftKeyToggle;

            if (ShiftKeyToggle) {
                toggle_left_shift.ForeColor = Color.Green;
                toggle_right_shift.ForeColor = Color.Green;

                // Change the color of the keys so the user knows that the shift key has been pressed
                key_a.ForeColor = Color.Green;
                key_b.ForeColor = Color.Green;
                key_c.ForeColor = Color.Green;
                key_d.ForeColor = Color.Green;
                key_e.ForeColor = Color.Green;
                key_f.ForeColor = Color.Green;
                key_g.ForeColor = Color.Green;
                key_h.ForeColor = Color.Green;
                key_i.ForeColor = Color.Green;
                key_j.ForeColor = Color.Green;
                key_k.ForeColor = Color.Green;
                key_l.ForeColor = Color.Green;
                key_m.ForeColor = Color.Green;
                key_n.ForeColor = Color.Green;
                key_o.ForeColor = Color.Green;
                key_p.ForeColor = Color.Green;
                key_q.ForeColor = Color.Green;
                key_r.ForeColor = Color.Green;
                key_s.ForeColor = Color.Green;
                key_t.ForeColor = Color.Green;
                key_u.ForeColor = Color.Green;
                key_v.ForeColor = Color.Green;
                key_w.ForeColor = Color.Green;
                key_x.ForeColor = Color.Green;
                key_y.ForeColor = Color.Green;
                key_z.ForeColor = Color.Green;
                
                // Handle the moddifiers
                key_backtick.ForeColor = Color.Green;
                key_backtick.Text = "¬";
                key_one.ForeColor = Color.Green;
                key_one.Text = "!";
                key_two.ForeColor = Color.Green;
                key_two.Text = "\"";
                key_three.ForeColor = Color.Green;
                key_three.Text = "£";
                key_four.ForeColor = Color.Green;
                key_four.Text = "$";
                key_five.ForeColor = Color.Green;
                key_five.Text = "%";
                key_six.ForeColor = Color.Green;
                key_six.Text = "^";
                key_seven.ForeColor = Color.Green;
                key_seven.Text = "&";
                key_eight.ForeColor = Color.Green;
                key_eight.Text = "*";
                key_nine.ForeColor = Color.Green;
                key_nine.Text = "(";
                key_zero.ForeColor = Color.Green;
                key_zero.Text = ")";
                key_minus.ForeColor = Color.Green;
                key_minus.Text = "_";
                key_equals.ForeColor = Color.Green;
                key_equals.Text = "+";

                // Keyboard side keys
                key_opening_brackets.ForeColor = Color.Green;
                key_opening_brackets.Text = "{";
                key_closing_brackets.ForeColor = Color.Green;
                key_closing_brackets.Text = "}";
                key_semicolon.ForeColor = Color.Green;
                key_semicolon.Text = ":";
                key_apos.ForeColor = Color.Green;
                key_apos.Text = "@";
                key_hashtag.ForeColor = Color.Green;
                key_hashtag.Text = "~";
                key_comma.ForeColor = Color.Green;
                key_comma.Text = "<";
                key_period.ForeColor = Color.Green;
                key_period.Text = ">";
                key_forward_slash.ForeColor = Color.Green;
                key_forward_slash.Text = "?";
                key_backslash.ForeColor = Color.Green;
                key_backslash.Text = "|";

            } 
            else {
                toggle_left_shift.ForeColor = Color.Black;
                toggle_right_shift.ForeColor = Color.Black;

                // Change color back to default
                key_a.ForeColor = Color.Black;
                key_b.ForeColor = Color.Black;
                key_c.ForeColor = Color.Black;
                key_d.ForeColor = Color.Black;
                key_e.ForeColor = Color.Black;
                key_f.ForeColor = Color.Black;
                key_g.ForeColor = Color.Black;
                key_h.ForeColor = Color.Black;
                key_i.ForeColor = Color.Black;
                key_j.ForeColor = Color.Black;
                key_k.ForeColor = Color.Black;
                key_l.ForeColor = Color.Black;
                key_m.ForeColor = Color.Black;
                key_n.ForeColor = Color.Black;
                key_o.ForeColor = Color.Black;
                key_p.ForeColor = Color.Black;
                key_q.ForeColor = Color.Black;
                key_r.ForeColor = Color.Black;
                key_s.ForeColor = Color.Black;
                key_t.ForeColor = Color.Black;
                key_u.ForeColor = Color.Black;
                key_v.ForeColor = Color.Black;
                key_w.ForeColor = Color.Black;
                key_x.ForeColor = Color.Black;
                key_y.ForeColor = Color.Black;
                key_z.ForeColor = Color.Black;

                // Handle the moddifiers
                key_backtick.ForeColor = Color.Black;
                key_backtick.Text = "`";
                key_one.ForeColor = Color.Black;
                key_one.Text = "1";
                key_two.ForeColor = Color.Black;
                key_two.Text = "2";
                key_three.ForeColor = Color.Black;
                key_three.Text = "3";
                key_four.ForeColor = Color.Black;
                key_four.Text = "4";
                key_five.ForeColor = Color.Black;
                key_five.Text = "5";
                key_six.ForeColor = Color.Black;
                key_six.Text = "6";
                key_seven.ForeColor = Color.Black;
                key_seven.Text = "7";
                key_eight.ForeColor = Color.Black;
                key_eight.Text = "8";
                key_nine.ForeColor = Color.Black;
                key_nine.Text = "9";
                key_zero.ForeColor = Color.Black;
                key_zero.Text = "0";
                key_minus.ForeColor = Color.Black;
                key_minus.Text = "-";
                key_equals.ForeColor = Color.Black;
                key_equals.Text = "=";

                // Keyboard side keys
                key_opening_brackets.ForeColor = Color.Black;
                key_opening_brackets.Text = "[";
                key_closing_brackets.ForeColor = Color.Black;
                key_closing_brackets.Text = "]";
                key_semicolon.ForeColor = Color.Black;
                key_semicolon.Text = ";";
                key_apos.ForeColor = Color.Black;
                key_apos.Text = "'";
                key_hashtag.ForeColor = Color.Black;
                key_hashtag.Text = "#";
                key_comma.ForeColor = Color.Black;
                key_comma.Text = ",";
                key_period.ForeColor = Color.Black;
                key_period.Text = ".";
                key_forward_slash.ForeColor = Color.Black;
                key_forward_slash.Text = "/";
                key_backslash.ForeColor = Color.Black;
                key_backslash.Text = "\\";

            }
        }

        private void toggle_caps_lock_Click(object sender, EventArgs e)
        {
            CapsLockToggle = !CapsLockToggle;

            if ( CapsLockToggle ) {
                toggle_caps_lock.ForeColor = Color.Green;

                // Change the color of the keys so the user knows that the shift key has been pressed
                key_a.ForeColor = Color.Green;
                key_b.ForeColor = Color.Green;
                key_c.ForeColor = Color.Green;
                key_d.ForeColor = Color.Green;
                key_e.ForeColor = Color.Green;
                key_f.ForeColor = Color.Green;
                key_g.ForeColor = Color.Green;
                key_h.ForeColor = Color.Green;
                key_i.ForeColor = Color.Green;
                key_j.ForeColor = Color.Green;
                key_k.ForeColor = Color.Green;
                key_l.ForeColor = Color.Green;
                key_m.ForeColor = Color.Green;
                key_n.ForeColor = Color.Green;
                key_o.ForeColor = Color.Green;
                key_p.ForeColor = Color.Green;
                key_q.ForeColor = Color.Green;
                key_r.ForeColor = Color.Green;
                key_s.ForeColor = Color.Green;
                key_t.ForeColor = Color.Green;
                key_u.ForeColor = Color.Green;
                key_v.ForeColor = Color.Green;
                key_w.ForeColor = Color.Green;
                key_x.ForeColor = Color.Green;
                key_y.ForeColor = Color.Green;
                key_z.ForeColor = Color.Green;
            } else
            {
                toggle_caps_lock.ForeColor = Color.Black;

                // Change color back to default
                key_a.ForeColor = Color.Black;
                key_b.ForeColor = Color.Black;
                key_c.ForeColor = Color.Black;
                key_d.ForeColor = Color.Black;
                key_e.ForeColor = Color.Black;
                key_f.ForeColor = Color.Black;
                key_g.ForeColor = Color.Black;
                key_h.ForeColor = Color.Black;
                key_i.ForeColor = Color.Black;
                key_j.ForeColor = Color.Black;
                key_k.ForeColor = Color.Black;
                key_l.ForeColor = Color.Black;
                key_m.ForeColor = Color.Black;
                key_n.ForeColor = Color.Black;
                key_o.ForeColor = Color.Black;
                key_p.ForeColor = Color.Black;
                key_q.ForeColor = Color.Black;
                key_r.ForeColor = Color.Black;
                key_s.ForeColor = Color.Black;
                key_t.ForeColor = Color.Black;
                key_u.ForeColor = Color.Black;
                key_v.ForeColor = Color.Black;
                key_w.ForeColor = Color.Black;
                key_x.ForeColor = Color.Black;
                key_y.ForeColor = Color.Black;
                key_z.ForeColor = Color.Black;
            }
        }
    }
}
