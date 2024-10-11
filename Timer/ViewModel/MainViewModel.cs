using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;
using Timer;

namespace Timer.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public TimerModel _timermodel = new TimerModel();
        public DispatcherTimer _dispatcherTimer;
        public bool _isRunning;

        public string TimeDisplay => _timermodel.Time.ToString(@"hh\:mm\:ss");

        public ICommand StartCommand { get; set; }
        public ICommand PauseCommand { get; set; }
        public ICommand ResetCommand { get; set; }
        public ICommand IncreaseHourCommand { get; set; }
        public ICommand IncreaseMinuteCommand { get; set; }
        public ICommand IncreaseSecondCommand { get; set; }
        public ICommand DecreaseHourCommand { get; set; }
        public ICommand DecreaseMinuteCommand { get; set; }
        public ICommand DecreaseSecondCommand { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public MainViewModel()
        {
            _dispatcherTimer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1)
            };
            _dispatcherTimer.Tick += OnTimerTick;

            StartCommand = new RelayCommand(StartTimer);
            PauseCommand = new RelayCommand(PauseTimer);
            ResetCommand = new RelayCommand(ResetTimer);
            IncreaseHourCommand = new RelayCommand(IncreaseHour);
            IncreaseMinuteCommand = new RelayCommand(IncreaseMinute);
            IncreaseSecondCommand = new RelayCommand(IncreaseSecond);
            DecreaseHourCommand = new RelayCommand(DecreaseHour);
            DecreaseMinuteCommand = new RelayCommand(DecreaseMinute);
            DecreaseSecondCommand = new RelayCommand(DecreaseSecond);
        }

        public void OnTimerTick(object sender, EventArgs e)
        {
            if (_timermodel.Time.TotalSeconds > 0)
            {
                _timermodel.SubtractSecond();
                OnPropertyChanged(nameof(TimeDisplay));
            }
            else
            {
                _dispatcherTimer.Stop();
                _isRunning = false;
                MessageBox.Show("끝났습니다!");
            }
        }

        public void StartTimer(object obj)
        {
            if (!_isRunning)
            {
                _dispatcherTimer.Start();
                _isRunning = true;
            }
        }

        public void PauseTimer(object obj)
        {
            if (_isRunning)
            {
                _dispatcherTimer.Stop();
                _isRunning = false;
            }
        }

        public void ResetTimer(object obj)
        {
            PauseTimer(null);
            _timermodel.Reset();
            OnPropertyChanged(nameof(TimeDisplay));
        }

        public void IncreaseHour(object obj)
        {
            _timermodel.AddHour(); 
            OnPropertyChanged(nameof(TimeDisplay));
        }

        public void IncreaseMinute(object obj)
        {
            _timermodel.AddMinute(); 
            OnPropertyChanged(nameof(TimeDisplay));
        }

        public void IncreaseSecond(object obj)
        {
            _timermodel.AddSecond(); 
            OnPropertyChanged(nameof(TimeDisplay));
        }

        public void DecreaseHour(object obj)
        {
            _timermodel.SubtractHour(); 
            OnPropertyChanged(nameof(TimeDisplay));
        }

        public void DecreaseMinute(object obj)
        {
            _timermodel.SubtractMinute(); 
            OnPropertyChanged(nameof(TimeDisplay)); ;
        }

        public void DecreaseSecond(object obj)
        {
            _timermodel.SubtractSecond();
            OnPropertyChanged(nameof(TimeDisplay));
        }

        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}