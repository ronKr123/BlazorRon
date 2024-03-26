using Model;

namespace BlazorAppMyLibrary
{
    public class MangerService
    {
        public MangerLibrary CurrentManger { get; set; }

        public void SetCurrentManger(MangerLibrary manger)
        {
            CurrentManger = manger;
        }


    }
}
