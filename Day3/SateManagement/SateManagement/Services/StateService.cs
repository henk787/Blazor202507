
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

namespace SateManagement.Services
{
    public class StateService(ProtectedSessionStorage ProtectedSessionStore)
    {        
        public ValueTask SetCounter(int counterValue)
        {            
            return ProtectedSessionStore.SetAsync(nameof(StateService), "Counter", counterValue);
        }

        public async ValueTask<int> GetCounter()
        {            
            var result = await ProtectedSessionStore.GetAsync<int>(nameof(StateService), "Counter");

            return result.Success ? result.Value : 0;
        }

    }
}
