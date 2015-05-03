    public ApplicationViewModelBase CurrentViewModelBase
        {
            get { return _currentViewModelBase; }
            set
            {
                _currentViewModelBase = value;
                RaisePropertyChanged(() => CurrentViewModelBase);
            }
        }