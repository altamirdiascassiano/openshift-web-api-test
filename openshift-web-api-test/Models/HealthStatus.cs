namespace openshift_web_api_test.Models
{

    public class HealthStatus
    {
        public bool IsHealthy { get; set; } = true;

        //função para testar o readinessProbe
        public HealthStatus()
        {            
            var isPar = DateTime.Now.Minute % 2 == 0;
            IsHealthy = isPar ? true : false;
        }

        public void ToggleHealth()
        {
            IsHealthy = !IsHealthy;
        }
    }
}
