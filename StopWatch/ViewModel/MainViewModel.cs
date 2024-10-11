using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using System.Windows.Threading;

namespace StopWatch.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public StopWatchModel _stopwatchModel = new StopWatchModel();
        public DispatcherTimer _dispatcherTimer;
        public DateTime _startTime;
        public bool _isRunning;

        public ObservableCollection<string> Records { get; set; } = new ObservableCollection<string>();
        public string TimeDisplay => _stopwatchModel.Time.ToString(@"hh\:mm\:ss\.ff");

        public ICommand StartCommand { get; set; }
        public ICommand StopCommand { get; set; }
        public ICommand RecordCommand { get; set; }
        public ICommand ResetCommand { get; set; }

        public MainViewModel()
        {
            _dispatcherTimer = new DispatcherTimer
            {
                Interval = TimeSpan.FromMilliseconds(100)
            };
            _dispatcherTimer.Tick += OnStopWatchTick;

            StartCommand = new RelayCommand(StartStopWatch);
            StopCommand = new RelayCommand(StopStopWatch);
            RecordCommand = new RelayCommand(RecordStopWatch);
            ResetCommand = new RelayCommand(ResetStopWatch);
        }

        public void OnStopWatchTick(object sender, EventArgs e)
        {
            _stopwatchModel.Time = DateTime.Now - _startTime;
            OnPropertyChanged(nameof(TimeDisplay));
        }

        public void StartStopWatch()
        {
            if (!_isRunning)
            {
                _startTime = DateTime.Now - _stopwatchModel.Time; 
                _dispatcherTimer.Start();
                _isRunning = true;
            }
        }

        public void StopStopWatch()
        {
            if (_isRunning)
            {
                _dispatcherTimer.Stop();
                _isRunning = false;
            }
        }

        public void RecordStopWatch()
        {
            Records.Add(_stopwatchModel.Time.ToString(@"hh\:mm\:ss\.ff"));
        }

        public void ResetStopWatch()
        {
            StopStopWatch();
            _stopwatchModel.Reset();
            Records.Clear();
            OnPropertyChanged(nameof(TimeDisplay));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
