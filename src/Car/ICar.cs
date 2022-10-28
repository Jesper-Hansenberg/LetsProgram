public interface ICar {
    public void Accelerate();
    public void Break();
    public void Autodrive(float longtitude, float latitude, bool enable = false);
    public void Turn(TurnDirection direction);
}