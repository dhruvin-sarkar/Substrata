using UnityEngine;

namespace Substrata
{
    [CreateAssetMenu(fileName = "BlockData", menuName = "Substrata/Blocks/Block Data")]
    public class BlockData : ScriptableObject
    {
        public BlockType blockType;
        public int maxHealth = 1;
        public int resourceValue = 1;
        public bool restoresFuel;
        public Color minimapColor = Color.white;
    }
}
