using UnityEditor;
using Sirenix.OdinInspector;
using Sirenix.OdinInspector.Editor;

namespace Liver {
    public class SomeWindow : OdinEditorWindow
    {
        [MenuItem("Tools/Liver/Grid")]
        private static void OpenWindow()
        {
            GetWindow<SomeWindow>().Show();
        }
	
        [PropertyOrder(-10)]
        [HorizontalGroup]
        [Button(ButtonSizes.Large)]
        public void SomeButton1() { }

        [HorizontalGroup]
        [Button(ButtonSizes.Large)]
        public void SomeButton2() { }

        [HorizontalGroup]
        [Button(ButtonSizes.Large)]
        public void SomeButton3() { }

        [HorizontalGroup]
        [Button(ButtonSizes.Large), GUIColor(0, 1, 0)]
        public void SomeButton4() { }

        [HorizontalGroup]
        [Button(ButtonSizes.Large), GUIColor(1, 0.5f, 0)]
        public void SomeButton5() { }
    }
}