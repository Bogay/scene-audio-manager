using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Bogay.SceneAudioManager
{
    // 讓我們可以直接在 unity 介面創建此 class 的實例
    [CreateAssetMenu]
    public class AudioClipArray : ScriptableObject, IEnumerable<Sound>
    {
        // 建立一個 Sound 的陣列
        public Sound[] sounds;

        public Sound this[int i] { get { return this.sounds[i]; } }
        public IEnumerator<Sound> GetEnumerator() { return this.sounds.Cast<Sound>().GetEnumerator(); }
        IEnumerator IEnumerable.GetEnumerator() { return this.GetEnumerator(); }
    }
}