using System;

namespace UdemyAspNet.Models.ViewModels
{
    public class ErrorViewModel
    {
        #region Cria��o do m�todo
        public string RequestId { get; set; }
        #endregion
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}