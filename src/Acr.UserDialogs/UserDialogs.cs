using System;

namespace Acr.UserDialogs
{
    public partial class UserDialogs : IUserDialogs
    {
        static IUserDialogs currentInstance;
        public static IUserDialogs Instance
        {
            get
            {
                if (currentInstance == null)
                    currentInstance = new Acr.UserDialogs.UserDialogs();

                return currentInstance;
            }
            set => currentInstance = value;
        }

        public IDisposable ActionSheet(ActionSheetConfig config)
        {
            return Instance.ActionSheet(config);
        }

        public Task<string> ActionSheetAsync(string title, string cancel, string destructive, CancellationToken? cancelToken = null, params string[] buttons)
        {
            return Instance.ActionSheetAsync(title, cancel, destructive, cancelToken, buttons);
        }

        public IDisposable Alert(string message, string title = null, string okText = null)
        {
            return Instance.Alert(message, title, okText);
        }

        public IDisposable Alert(AlertConfig config)
        {
            return Instance.Alert(config);
        }

        public Task AlertAsync(string message, string title = null, string okText = null, CancellationToken? cancelToken = null)
        {
            return Instance.AlertAsync(message, title, okText, cancelToken);
        }

        public Task AlertAsync(AlertConfig config, CancellationToken? cancelToken = null)
        {
            return Instance.AlertAsync(config, cancelToken);
        }

        public IDisposable Confirm(ConfirmConfig config)
        {
            return Instance.Confirm(config);
        }

        public Task<bool> ConfirmAsync(string message, string title = null, string okText = null, string cancelText = null, CancellationToken? cancelToken = null)
        {
            return Instance.ConfirmAsync(message, title, okText, cancelText, cancelToken);
        }

        public Task<bool> ConfirmAsync(ConfirmConfig config, CancellationToken? cancelToken = null)
        {
            return Instance.ConfirmAsync(config, cancelToken);
        }

        public IDisposable DatePrompt(DatePromptConfig config)
        {
            return Instance.DatePrompt(config);
        }

        public Task<DatePromptResult> DatePromptAsync(DatePromptConfig config, CancellationToken? cancelToken = null)
        {
            return Instance.DatePromptAsync(config, cancelToken);
        }

        public Task<DatePromptResult> DatePromptAsync(string title = null, DateTime? selectedDate = null, CancellationToken? cancelToken = null)
        {
            return Instance.DatePromptAsync(title, selectedDate, cancelToken);
        }

        public void HideLoading()
        {
            Instance.HideLoading();
        }

        public IProgressDialog Loading(string title = null, Action onCancel = null, string cancelText = null, bool show = true, MaskType? maskType = null)
        {
            return Instance.Loading(title, onCancel, cancelText, show, maskType);
        }

        public IDisposable Login(LoginConfig config)
        {
            return Instance.Login(config);
        }

        public Task<LoginResult> LoginAsync(string title = null, string message = null, CancellationToken? cancelToken = null)
        {
            return Instance.LoginAsync(title, message, cancelToken);
        }

        public Task<LoginResult> LoginAsync(LoginConfig config, CancellationToken? cancelToken = null)
        {
            return Instance.LoginAsync(config, cancelToken);
        }

        public IProgressDialog Progress(ProgressDialogConfig config)
        {
            return Instance.Progress(config);
        }

        public IProgressDialog Progress(string title = null, Action onCancel = null, string cancelText = null, bool show = true, MaskType? maskType = null)
        {
            return Instance.Progress(title, onCancel, cancelText, show, maskType);
        }

        public IDisposable Prompt(PromptConfig config)
        {
            return Instance.Prompt(config);
        }

        public Task<PromptResult> PromptAsync(string message, string title = null, string okText = null, string cancelText = null, string placeholder = "", InputType inputType = InputType.Default, CancellationToken? cancelToken = null)
        {
            return Instance.PromptAsync(message, title, okText, cancelText, placeholder, inputType, cancelToken);
        }

        public Task<PromptResult> PromptAsync(PromptConfig config, CancellationToken? cancelToken = null)
        {
            return Instance.PromptAsync(config, cancelToken);
        }

        public void ShowLoading(string title = null, MaskType? maskType = null)
        {
            Instance.ShowLoading(title, maskType);
        }

        public IDisposable TimePrompt(TimePromptConfig config)
        {
            return Instance.TimePrompt(config);
        }

        public Task<TimePromptResult> TimePromptAsync(TimePromptConfig config, CancellationToken? cancelToken = null)
        {
            return Instance.TimePromptAsync(config, cancelToken);
        }

        public Task<TimePromptResult> TimePromptAsync(string title = null, TimeSpan? selectedTime = null, CancellationToken? cancelToken = null)
        {
            return Instance.TimePromptAsync(title, selectedTime, cancelToken);
        }

        public IDisposable Toast(string title, TimeSpan? dismissTimer = null)
        {
            return Instance.Toast(title, dismissTimer);
        }

        public IDisposable Toast(ToastConfig cfg)
        {
            return Instance.Toast(cfg);
        }
    }
}
