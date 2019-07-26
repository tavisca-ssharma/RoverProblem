namespace RoverProblem
{
    public class Initialisation
    {
        private int __limitX, __limitY, __currX, __currY;
        private string __facingDirection;

        public Initialisation()
        {
            __limitX = __limitY = __currX = __currY = 0;
            __facingDirection = "N";
        }

        public int LimitX
        {
            get => __limitX;
            set => __limitX = value;
        }

        public int LimitY
        {
            get => __limitY;
            set => __limitY = value;
        }

        public int CurrX
        {
            get => __currX;
            set => __currX = value;
        }

        public int CurrY
        {
            get => __currY;
            set => __currY = value;
        }

        public string FacingDirection
        {
            get => __facingDirection;
            set => __facingDirection = value;
        }
    }
}
