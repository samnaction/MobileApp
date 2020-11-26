namespace MobileLib
{
    using System;

    public class Mobile
    {
        private Camera camera;

        public Mobile(Camera camera)
        {
            this.camera = camera;
        }

        public bool powerOn()
        {
            if (camera.On())
            {
                Console.WriteLine("Mobile - powerOn Positive code path");
                return true;
            }
            Console.WriteLine("Mobile - PowerOn Negative code path");
            return false;
        }
    }
}
