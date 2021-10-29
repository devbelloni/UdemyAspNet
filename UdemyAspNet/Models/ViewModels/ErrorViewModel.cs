using System;

namespace UdemyAspNet.Models.ViewModels
{
    public class ErrorViewModel
    {
        #region Criação do método
        public string RequestId { get; set; }
        #endregion
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}