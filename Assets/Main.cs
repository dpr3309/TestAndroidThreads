
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"[Main.Start] start in thread: {Thread.CurrentThread.ManagedThreadId}");
        DebugAsyncMethod();

        Task.Run(() =>
        {
            Debug.Log($"[Main.lambda] in thread: {Thread.CurrentThread.ManagedThreadId}");
        });
        Debug.Log($"[Main.Start] end in thread: {Thread.CurrentThread.ManagedThreadId}");
    }

    private async Task DebugAsyncMethod()
    {
        await Task.Delay(1000);
        Debug.Log($"[Main.DebugAsyncMethod] in thread: {Thread.CurrentThread.ManagedThreadId}");
    }
}
