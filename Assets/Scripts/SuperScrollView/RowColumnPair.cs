using UnityEngine;

namespace SuperScrollView
{
    public struct RowColumnPair
    {
        // Fields
        public int mRow;
        public int mColumn;
        
        // Methods
        public RowColumnPair(int row1, int column1)
        {
            this = row1;
            this.mColumn = column1;
        }
        public bool Equals(SuperScrollView.RowColumnPair other)
        {
            if(new SuperScrollView.RowColumnPair() != other.mRow)
            {
                    return false;
            }
            
            return (bool)(this.mColumn == (other.mRow >> 32)) ? 1 : 0;
        }
        public static bool op_Equality(SuperScrollView.RowColumnPair a, SuperScrollView.RowColumnPair b)
        {
            a.mRow = ((a.mRow == b.mRow) ? 1 : 0) & (((a.mRow >> 32) == (b.mRow >> 32)) ? 1 : 0);
            return (bool)a.mRow;
        }
        public static bool op_Inequality(SuperScrollView.RowColumnPair a, SuperScrollView.RowColumnPair b)
        {
            a.mRow = ((a.mRow != b.mRow) ? 1 : 0) | (((a.mRow >> 32) != (b.mRow >> 32)) ? 1 : 0);
            return (bool)a.mRow;
        }
        public override int GetHashCode()
        {
            return 0;
        }
        public override bool Equals(object obj)
        {
            var val_2;
            if(((obj != null) && (null == null)) && (new SuperScrollView.RowColumnPair() == null))
            {
                    var val_1 = (this.mColumn == 0) ? 1 : 0;
                return (bool)val_2;
            }
            
            val_2 = 0;
            return (bool)val_2;
        }
    
    }

}
