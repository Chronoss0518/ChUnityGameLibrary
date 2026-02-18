
namespace ChStd
{
    abstract public class FileBase
    {
        public virtual void Open(string _fileName, bool _updateFlg = false)
        {
            fileName = _fileName;
            updateFlg = _updateFlg;
        }

        public virtual void Close()
        {
            fileName = "";
            isOpen = false;
        }

        protected string fileName { get; private set; } = "";

        //FileのClose自にFileの内容を更新するかしないかのフラグ//
        protected bool updateFlg { get; private set; } = false;

        public bool isOpen { get; private set; } = false;
    }

}