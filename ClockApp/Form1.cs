using ClockLibary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ClockApp
{
    public partial class Form1 : Form
    {
        private Clock _clock = new Clock();
        private bool _alert = false;
        private AlarmEffect _effect = new AlarmEffect();
        private Alarm _alarm = new Alarm(0,0), _alarm2 = new Alarm(0,0);
        private int _hour = 0, _minute = 0;
        
        
        public Form1()
        {
            InitializeComponent();
            _alarm.State = AlarmState.Off;
            _alarm2.State = AlarmState.Off;
            _clock.Interval = 1000;
            _clock.Elapsed += Clock_Elapsed;
            _clock.SynchronizingObject = this;
        }

        private void Clock_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            _alert = false;
            // Fomraterar clock labeln så att den visar XX:XX
            if(_clock.Hour < 10)
            {
                if(_clock.Minute < 10)
                {
                    clockLabel.Text = $"0{_clock.Hour}:0{_clock.Minute}"; 
                }
                else
                    clockLabel.Text = $"0{_clock.Hour}:{_clock.Minute}";
            }
            else if(_clock.Minute < 10)
                clockLabel.Text = $"{_clock.Hour}:0{_clock.Minute}";
            else
                clockLabel.Text = $"{_clock.Hour}:{_clock.Minute}";

            _alarm.UpdateState(_clock);
            _alarm2.UpdateState(_clock);

            _alert = _alarm.State == AlarmState.Alert || _alarm2.State  == AlarmState.Alert;


            if (_alert)
            {
                if (_effect.IsDisposed)
                {
                    _effect = new AlarmEffect();
                    _effect.Show();
                }
                else if (!_effect.Visible)
                {
                    _effect.Show();
                }
            }
            else
            {
                if (!_effect.IsDisposed)
                {
                    _effect.Hide();
                }
            }
            SetAlarmLabels();




        }

        #region Buttons
        private void StartButton_Click(object sender, EventArgs e)
        {
            
            if (StartButton.Text == "Start")
            {
                StartButton.Text = "Stop";
                SetHourTextBox.Enabled = false;
                SetMinutesTextBox.Enabled = false;
                //check = MakeToInt("clock");

                if(checkInput(SetHourTextBox.Text, SetMinutesTextBox.Text))
                {
                    _clock.Set(_hour, _minute);
                    Clock_Elapsed(null, null);
                    _clock.Start();
                }
                else
                {
                    SetHourTextBox.Enabled = true;
                    SetMinutesTextBox.Enabled = true;
                    StartButton.Text = "Start";
                }
            }
            else
            {
                _clock.Stop();
                if (!_effect.IsDisposed)
                {
                    _effect.Hide();
                    if(_alarm.State == AlarmState.Alert)
                    {
                        _alarm.State = AlarmState.On;
                        SetAlarmLabels();
                    }
                    else if(_alarm2.State == AlarmState.Alert)
                    {
                        _alarm2.State = AlarmState.On;
                        SetAlarmLabels();
                    }
                }
                SetHourTextBox.Enabled = true;
                SetMinutesTextBox.Enabled = true;
                StartButton.Text = "Start";
            }

        }

      
        private void SetButton2_Click(object sender, EventArgs e)
        {

            if (SetButton2.Text == "Set")
            {
                SetButton2.Text = "Unset";
                if (checkInput(SetHourAlarmTxtBox2.Text, SetMinutesAlarmTxtBox2.Text))
                {
                    SetHourAlarmTxtBox2.Enabled = false;
                    SetMinutesAlarmTxtBox2.Enabled = false;
                    _alarm2 = new Alarm(_hour, _minute); //starta alarm 1
                    _alarm2.State = AlarmState.On;



                }
                else
                    SetButton2.Text = "Set"; 

            }
            else
            {
                SetButton2.Text = "Set";
                _alarm2.State = AlarmState.Off;
                SetHourAlarmTxtBox2.Enabled = true;
                SetMinutesAlarmTxtBox2.Enabled = true;
                

            }
            SetAlarmLabels();



        }

        private void SetButton_Click(object sender, EventArgs e)
        {
            
            if (SetButton.Text == "Set")
            {
                SetButton.Text = "Unset";
                if (checkInput(SetHoursAlarmTxtBox.Text, SetMinutesAlarmTxtBox.Text))
                {
                    SetHoursAlarmTxtBox.Enabled = false;
                    SetMinutesAlarmTxtBox.Enabled = false;
                    _alarm = new Alarm(_hour, _minute); //starta alarm 1
                    _alarm.State = AlarmState.On;
                    

                }
                else
                    SetButton.Text = "Set";
            }
            else 
            {
                SetButton.Text = "Set";
                _alarm.State = AlarmState.Off;
                SetHoursAlarmTxtBox.Enabled = true;
                SetMinutesAlarmTxtBox.Enabled = true;
                
            }
            SetAlarmLabels();
        }
        #endregion

        
        private void SetAlarmLabels()
        {
            if (_alarm.State == AlarmState.On)
            {
                label5.Text = "Alarm 1 is on";
                label5.BackColor = Color.Green;
            }
            else if (_alarm.State == AlarmState.Alert)
            {
                label5.Text = "Alarm 1 is active";
                label5.BackColor = Color.Red;
            }
            else
            {
                label5.Text = "Alarm 1 is off";
                label5.BackColor = SystemColors.Control;
            }

            if (_alarm2.State == AlarmState.On)
            {
                label6.Text = "Alarm 2 is on";
                label6.BackColor = Color.Green;

            }
            else if (_alarm2.State == AlarmState.Alert)
            {
                label6.Text = "Alarm 2 is active";
                label6.BackColor = Color.Red;
            }
            else
            {
                label6.Text = "Alarm 2 is off";
                label6.BackColor = SystemColors.Control;
            }
               
            
        }
        private bool checkInput(string hourInput, string minuteInput)
        {
            int hour;
            int minute;
            try
            {
                hour = Convert.ToInt32(hourInput);
                minute = Convert.ToInt32(minuteInput);

                if (minute >= 0 && minute <= 60 && hour >= 0 && hour <= 23)
                { 
                    _hour = hour;
                    _minute = minute;
                    return true;
                }
                else
                {
                    MessageBox.Show("Enter a valid time like: 00:00 - 23:00");
                }
            }
            catch
            {
                MessageBox.Show("ERROR! Wrong input, enter a digit..");
                return false;
            }
            return false;
        }

    }
}
