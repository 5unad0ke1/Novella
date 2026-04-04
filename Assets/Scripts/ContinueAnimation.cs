using LitMotion;
using LitMotion.Extensions;
using UnityEngine;
using UnityEngine.UI;
namespace Novella.Runtime
{
    public sealed class ContinueAnimation : MonoBehaviour
    {
        [SerializeField] private Image _image;

        private MotionHandle _handle;
        private void Start()
        {
            _handle = LMotion.Create(1f, 0f, 0.5f)
                .WithLoops(-1, LoopType.Flip)
                .BindToColorA(_image);
        }
        private void OnDestroy()
        {
            _handle.TryCancel();
        }
    }
}