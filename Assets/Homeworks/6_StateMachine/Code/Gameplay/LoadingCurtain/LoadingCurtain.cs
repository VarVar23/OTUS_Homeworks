using DG.Tweening;
using System.Threading.Tasks;

namespace StateMachine
{
    public class LoadingCurtain 
    {
        private LoadingCurtainView _view;
        private LoadingCurtainData _data;

        public LoadingCurtain(LoadingCurtainView loadingCurtainView, LoadingCurtainData data)
        {
            _view = loadingCurtainView;
            _data = data;
        }

        public async Task Open()
        {
            await _view.CanvasGroup.DOFade(0, _data.TimeOpen).AsyncWaitForCompletion();
        }

        public async Task Close()
        {
            await _view.CanvasGroup.DOFade(1, _data.TimeClose).AsyncWaitForCompletion();
        }
    }
}