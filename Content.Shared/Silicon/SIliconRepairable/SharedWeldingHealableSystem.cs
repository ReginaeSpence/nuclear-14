using Content.Shared.DoAfter;
using Robust.Shared.Serialization;

namespace Content.Shared.Silicon.WeldingHealing;

public abstract partial class SharedWeldingHealableSystem : EntitySystem
{
    [Serializable, NetSerializable]
    protected sealed partial class SiliconRepairFinishedEvent : SimpleDoAfterEvent
    {
        public float Delay;
    }
}
