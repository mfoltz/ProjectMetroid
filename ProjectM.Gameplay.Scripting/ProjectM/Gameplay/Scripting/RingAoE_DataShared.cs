// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.RingAoE_DataShared
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using ProjectM.Scripting;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct RingAoE_DataShared
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_StartRadius;
    private static readonly System.IntPtr NativeFieldInfoPtr_EndRadius;
    private static readonly System.IntPtr NativeFieldInfoPtr_Duration;
    private static readonly System.IntPtr NativeFieldInfoPtr_RingThickness;
    private static readonly System.IntPtr NativeFieldInfoPtr_TimeBetweenHits;
    private static readonly System.IntPtr NativeFieldInfoPtr_RingSequence;
    private static readonly System.IntPtr NativeFieldInfoPtr_RingSequenceState;
    private static readonly System.IntPtr NativeFieldInfoPtr_GameplayEventId;
    private static readonly System.IntPtr NativeFieldInfoPtr_HitFilter;
    [FieldOffset(0)]
    public float StartRadius;
    [FieldOffset(4)]
    public float EndRadius;
    [FieldOffset(8)]
    public float Duration;
    [FieldOffset(12)]
    public float RingThickness;
    [FieldOffset(16)]
    public float TimeBetweenHits;
    [FieldOffset(20)]
    public SequenceGUID RingSequence;
    [FieldOffset(24)]
    public SequenceState RingSequenceState;
    [FieldOffset(32)]
    public GameplayEventId GameplayEventId;
    [FieldOffset(40)]
    public HitFilter HitFilter;

    static RingAoE_DataShared()
    {
      Il2CppClassPointerStore<RingAoE_DataShared>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (RingAoE_DataShared));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RingAoE_DataShared>.NativeClassPtr);
      RingAoE_DataShared.NativeFieldInfoPtr_StartRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RingAoE_DataShared>.NativeClassPtr, nameof (StartRadius));
      RingAoE_DataShared.NativeFieldInfoPtr_EndRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RingAoE_DataShared>.NativeClassPtr, nameof (EndRadius));
      RingAoE_DataShared.NativeFieldInfoPtr_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RingAoE_DataShared>.NativeClassPtr, nameof (Duration));
      RingAoE_DataShared.NativeFieldInfoPtr_RingThickness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RingAoE_DataShared>.NativeClassPtr, nameof (RingThickness));
      RingAoE_DataShared.NativeFieldInfoPtr_TimeBetweenHits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RingAoE_DataShared>.NativeClassPtr, nameof (TimeBetweenHits));
      RingAoE_DataShared.NativeFieldInfoPtr_RingSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RingAoE_DataShared>.NativeClassPtr, nameof (RingSequence));
      RingAoE_DataShared.NativeFieldInfoPtr_RingSequenceState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RingAoE_DataShared>.NativeClassPtr, nameof (RingSequenceState));
      RingAoE_DataShared.NativeFieldInfoPtr_GameplayEventId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RingAoE_DataShared>.NativeClassPtr, nameof (GameplayEventId));
      RingAoE_DataShared.NativeFieldInfoPtr_HitFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RingAoE_DataShared>.NativeClassPtr, nameof (HitFilter));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RingAoE_DataShared>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
