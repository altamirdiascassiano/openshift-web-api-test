namespace openshift_web_api_test.Models
{
    public class HealthStatus
    {
        public bool IsHealthy { get; set; } = true;

        public void ToggleHealth()
        {
            IsHealthy = !IsHealthy;
        }
    }
}
