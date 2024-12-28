namespace EOM.TSHotelManager.FormUI
{
    public class LoadingProgress
    {
        private FrmProgress _frmProgress;

        // 显示加载窗口
        public void Show()
        {
            if (_frmProgress == null || _frmProgress.IsDisposed)
            {
                _frmProgress = new FrmProgress();
            }

            // 异步显示窗体以确保不阻塞调用线程
            Task.Run(() => _frmProgress.ShowDialog());
        }

        // 关闭加载窗口
        public void Close()
        {
            if (_frmProgress != null && !_frmProgress.IsDisposed)
            {
                _frmProgress.Invoke(new Action(() =>
                {
                    _frmProgress.Close();
                }));
            }
        }
    }
}
