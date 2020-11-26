namespace MobileLib
{
    using System;

    public class Camera
    {
        public Camera()
        {
        }

        virtual public bool On()
        {
            Console.WriteLine("Camera -on method interacts with camera hardware");
            return true;
        }
    }
}
