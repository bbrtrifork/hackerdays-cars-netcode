using Unity.Netcode;

public class PlayerRacePosition : NetworkBehaviour
{
    public NetworkVariable<int> labNumber = new NetworkVariable<int>(0);
    public NetworkVariable<int> checkpointNumber = new NetworkVariable<int>(0);

    public override void OnNetworkSpawn()
    {
        if (!IsClient) return;
        
        labNumber.OnValueChanged += OnLabChanged;
        checkpointNumber.OnValueChanged += OnCheckpointChanged;

        Setup();
    }

    private void OnCheckpointChanged(int previousvalue, int newvalue)
    {
        UpdateRacePosition(labNumber.Value, newvalue);
    }

    private void OnLabChanged(int previousvalue, int newvalue)
    {
        UpdateRacePosition(newvalue, checkpointNumber.Value);
    }

    private void Setup()
    {
        
    }

    private void UpdateRacePosition(int lab, int checkpoint)
    {
        
    }
}